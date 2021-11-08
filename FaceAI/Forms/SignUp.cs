﻿using FaceAI.Azure.Database;
using FaceAI.Classes;
using FaceAI.Exceptions;
using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FaceAI.Forms
{
    public partial class SignUp : Form
    {
        private Form parent;
        private Database database;
        private Camera camera;
        private Bitmap image;

        private readonly string PATH_TO_TEMP;

        public SignUp(Form parent, string PATH_TO_TEMP)
        {
            InitializeComponent();
            this.parent = parent; // The parent form to be able to reopen without spawning a new form.
            database = new Database();

            this.PATH_TO_TEMP = PATH_TO_TEMP;

            // Initilize the camera and start it
            camera = new Camera(pctUser);
            camera.Run();
        }

        private void SignUp_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Close the thread running the camera.
            camera.CloseCamera();
            parent.Show();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (txtPassword.Text != txtRePassword.Text) // Check that both the passwords match if they don't throw Display message to user
            {
                MessageBox.Show("The passwords do not match, please re-enter your passwords.", "Passwords do not match!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            } else if (this.image == null) { // Ensure that a user image has been taken for connection query
                MessageBox.Show("No image has been taken. Please take an image", "No user image!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            } else
            {
                // Generate a new user object
                User newUser = new User(txtUsername.Text.Trim(), txtPassword.Text.Trim(), txtFirstName.Text.Trim(), txtSurname.Text.Trim());

                // Try to save the user to the database
                try
                {
                    string file_name = SaveImage();
                    database.NewUser(newUser, file_name);
                    MessageBox.Show("User has been added!", "Success!", MessageBoxButtons.OK);
                    // Resolve the signup by returning the user to the home screen.
                    parent.Show();
                    this.Close();
                } catch (Exception ex) when (ex is DatabaseInsertException || ex is UserExistsException) // Catch errors 
                {
                    MessageBox.Show(ex.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

            }
        }

        private void btnTakePicture_Click(object sender, EventArgs e)
        {
            try
            {
                // Take a picture of the User 
                image = camera.TakePicture(stop: true);

                // Hide buttons and allow user to retake image
                btnTakePicture.Visible = false;
                btnRetake.Visible = true;
            } catch (CameraNotActiveException ex)
            {
                MessageBox.Show(ex.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnRetake_Click(object sender, EventArgs e)
        {
            // Restart the camera
            camera.Run();
            btnTakePicture.Visible = true;
            btnRetake.Visible = false;
        }


        private string SaveImage()
        {
                     // Generate a filename as a hash of the current datetime and some random number
            DateTime foo = DateTime.Now;
            Random rnd = new Random();
            long val = rnd.Next(1111111, 779999999);
            long unixTime = ((DateTimeOffset)foo).ToUnixTimeSeconds()+val;
            string file_name = unixTime.ToString() + ".jpg";
            // Path to temporary save location
            string path = PATH_TO_TEMP + file_name;

            // Save the bitmat as a jpg to the temporary llocation
            ImageEncoder.Encoder(image, path);
            

            // Upload this to the blob
            BlobHandler.UploadToStorage(path, file_name).GetAwaiter();

            // Return the filename to access
            return file_name;
        }

        // Image encoder function
       
    }
}