using FaceAI.Azure.AI;
using FaceAI.Azure.Database;
using FaceAI.Classes;
using FaceAI.Exceptions;
using FaceAI.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FaceAI
{
    public partial class HomePage : Form
    {
        private readonly string PATH_TO_TEMP;
        private User currentUser;
        private Database dbs;
        private Bitmap userImage;
        private Bitmap compareImage;
        private RecognitionActions recognitionModel;
        private List<string> tempFaces;
        private List<User> foundUsers;

        internal User CurrentUser { get => currentUser;}

        public HomePage(string tempPath)
        {
            this.PATH_TO_TEMP = tempPath;
            dbs = new Database();
            InitializeComponent();
            recognitionModel = new RecognitionActions(PATH_TO_TEMP);

            pctCompare.SizeMode = PictureBoxSizeMode.Zoom;
            tempFaces = new List<string>();
            foundUsers = new List<User>();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            // Allow the user to sign up by opening a form and hiding this one
            SignUp signup = new SignUp(this, PATH_TO_TEMP);

            signup.Show();
            this.Hide();
        }

        private void HomePage_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Delete the temp path
            try
            {
                userImage = null;
                currentUser = null;
                if (pctUser.Image != null) { pctUser.Image.Dispose(); }
                foundUsers = null;

                Directory.Delete(PATH_TO_TEMP, true);
            }
            catch (Exception)
            {
            }
        }

        private void btnLogIn_Click(object sender, EventArgs e)
        {
            // Get username and Password
            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text.Trim();

            // Try to log the user in
            try
            {
                currentUser = dbs.GetUser(username, password);
                currentUser.Images = dbs.GetImageFiles(username);
                setFace(currentUser.Images[0], pctUser);

                grpLogin.Visible = false;
                pnlUser.Visible = true;
                txtPassword.Text = "";
                txtUsername.Text = "";
            } catch (UserExistsException ex)
            {
                MessageBox.Show(ex.Message, "Login Issue!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            } finally // Clear all user data
            {
                password = null;
                username = null;
            }
        }

        private async void setFace(string file, PictureBox picBox)
        {
            string path = PATH_TO_TEMP + file;
            if (!File.Exists(path))
            {
                await BlobHandler.DownloadToTemp(path, file);
            }
            picBox.SizeMode = PictureBoxSizeMode.Zoom; // Setting the picture box type
            picBox.Image = new Bitmap(path);
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            grpLogin.Visible = true;
            pnlUser.Visible = false;
        }

        private void pnlUser_VisibleChanged(object sender, EventArgs e)
        {
            if (pnlUser.Visible)
            {
                lblWelcome.Text = String.Format("Welcome {0} {1}", currentUser.First_name, currentUser.Surname);
            }
        }

        private void btnNewProfile_Click(object sender, EventArgs e)
        {
            Form profile = new NewProfile(this);
            profile.Show();
            this.Hide();
        }

        private async void btnUpload_Click(object sender, EventArgs e)
        {
            lstSimilarFaces.Items.Clear();
            OpenFileDialog filedialog = new OpenFileDialog();
            filedialog.Filter = "JPEG files(*.jpg)| *.jpg |PNG files(*.png)| *.png|All files (*.*)|*.*";
            if (filedialog.ShowDialog() == DialogResult.OK)
            {
                pbarProgress.Value = 0;
                pbarProgress.Show();
                string filePath = filedialog.FileName;
                compareImage = new Bitmap(filePath);
                pctCompare.Image = compareImage;

                bool result = await recognitionModel.ImageisFaceAsync(compareImage);
                if (!result)
                {
                    pbarProgress.Value = 100;
                    MessageBox.Show("No face detected");
                }

                pbarProgress.Value = 10;
                List<FaceSimilarity> results = await recognitionModel.FindSimilar(compareImage, pbarProgress);

                foreach(FaceSimilarity face in results)
                {
                    if(face.Similarity > 0)
                    {
                        User matching = dbs.FindUser(face.Filename);
                        if(matching != null)
                        {
                            // If the user already exists just add an image
                            if (foundUsers.Any(item => item.Username == matching.Username))
                            {
                                foreach (User usr in foundUsers.Where(item => item.Username == matching.Username))
                                {
                                    usr.Images.Add(matching.Images[0]);
                                }
                            }
                            else
                            {
                                foundUsers.Add(matching);
                                lstSimilarFaces.Items.Add($"{matching.First_name}\t{matching.Surname}\t{matching.Images[0]}");
                            }
                        }
                    }
                }
                pbarProgress.Value = 100;
            }
        }

        private void lstSimilarFaces_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = lstSimilarFaces.SelectedIndex;
            User selected = foundUsers[index];

            lblSelectedUser.Text = String.Format("{0} {1}", selected.First_name, selected.Surname);

            setFace(selected.Images[0], pctSelected);
        }
    }
}
