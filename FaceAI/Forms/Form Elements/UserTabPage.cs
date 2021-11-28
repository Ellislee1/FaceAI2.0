using FaceAI.Classes;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FaceAI.Forms.Form_Elements
{
    class UserTabPage : TabPage
    {
        private User user;
        private PictureBox profileImage;
        private Label userLabel;
        private ListBox onlineProfiles;
        private Label label1, label2, label3;
        private TextBox txtCompany, txtField;

        public UserTabPage(string name, string text, User user, Bitmap image)
        {
            this.User = user;
            SetupImage(name);
            SetupLabel(name);
            SetupListbox(name);
            AddStatic(name);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtCompany);
            this.Controls.Add(this.txtField);
            this.Controls.Add(this.ProfileImage);
            this.Controls.Add(this.UserLabel);
            this.Controls.Add(this.OnlineProfiles);
            this.Name = name;
            this.Padding = new Padding(3);
            this.Size = new System.Drawing.Size(475, 187);
            this.TabIndex = 0;
            this.Text = text;
            this.UseVisualStyleBackColor = true;

            // Add context to the user
            this.UserLabel.Text = String.Format("{0} {1}", this.User.First_name, this.User.Surname);
            this.ProfileImage.SizeMode = PictureBoxSizeMode.Zoom;
            this.ProfileImage.Image = image;

            this.txtCompany.Text= user.Company;
            this.txtField.Text = user.Field;

            foreach(Profiles profile in this.User.Profiles)
            {
                onlineProfiles.Items.Add($"{profile.Site}\t| {profile.Link} \t| {profile.Username}");
            }
        }

        internal ListBox OnlineProfiles { get => onlineProfiles; set => onlineProfiles = value; }
        internal Label UserLabel { get => userLabel; set => userLabel = value; }
        internal PictureBox ProfileImage { get => profileImage; set => profileImage = value; }
        public User User { get => user; private set => user = value; }

        private void SetupImage(string name)
        {
            this.ProfileImage = new PictureBox();
            this.ProfileImage.Location = new System.Drawing.Point(6, 23);
            this.ProfileImage.Name = $"pct{name}";
            this.ProfileImage.Size = new System.Drawing.Size(155, 154);
            this.ProfileImage.TabStop = false;
        }

        private void SetupLabel(string name)
        {
            this.UserLabel = new Label();
            this.UserLabel.AutoSize = true;
            this.UserLabel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.UserLabel.Location = new System.Drawing.Point(6, 3);
            this.UserLabel.Name = $"lbl{name}";
            this.UserLabel.Size = new System.Drawing.Size(107, 17);
            this.UserLabel.Text = $"{this.User.First_name} {this.User.Surname}";
        }

        private void SetupListbox(string name)
        {
            this.OnlineProfiles = new ListBox();
            this.OnlineProfiles.FormattingEnabled = true;
            this.OnlineProfiles.ItemHeight = 15;
            this.OnlineProfiles.Location = new System.Drawing.Point(167, 113);
            this.OnlineProfiles.Name = $"lst{name}";
            this.OnlineProfiles.Size = new System.Drawing.Size(302, 64);
            this.OnlineProfiles.HorizontalScrollbar = true;
        }

        private void AddStatic(string name)
        {
            this.label1 = new Label();
            this.label2 = new Label();
            this.label3 = new Label();
            this.txtCompany = new TextBox();
            this.txtField = new TextBox();

            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(167, 93);
            this.label1.Name = $"lbl{name}1";
            this.label1.Size = new System.Drawing.Size(92, 17);
            this.label1.Text = "Online Profiles";

            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(167, 35);
            this.label2.Name = $"lbl{name}2";
            this.label2.Size = new System.Drawing.Size(59, 15);
            this.label2.TabIndex = 18;
            this.label2.Text = "Company";

            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(319, 35);
            this.label3.Name = $"lbl{name}3";
            this.label3.Size = new System.Drawing.Size(32, 15);
            this.label3.TabIndex = 19;
            this.label3.Text = "Field";

            this.txtField.Location = new System.Drawing.Point(323, 53);
            this.txtField.Name = $"txt{name}1"; ;
            this.txtField.ReadOnly = true;
            this.txtField.Size = new System.Drawing.Size(146, 23);
            this.txtField.TabIndex = 16;

            this.txtCompany.Location = new System.Drawing.Point(167, 53);
            this.txtCompany.Name = $"txt{name}2";
            this.txtCompany.ReadOnly = true;
            this.txtCompany.Size = new System.Drawing.Size(150, 23);
            this.txtCompany.TabIndex = 17;
        }
    }
}
