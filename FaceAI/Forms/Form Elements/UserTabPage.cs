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

        public UserTabPage(string name, string text, User user, Bitmap image)
        {
            this.user = user;
            SetupImage(name);
            SetupLabel(name);
            this.Controls.Add(this.ProfileImage);
            this.Controls.Add(this.UserLabel);
            this.Name = name;
            this.Padding = new Padding(3);
            this.Size = new System.Drawing.Size(475, 187);
            this.TabIndex = 0;
            this.Text = text;
            this.UseVisualStyleBackColor = true;

            // Add context to the user
            this.UserLabel.Text = String.Format("{0} {1}", this.user.First_name, this.user.Surname);
            this.ProfileImage.SizeMode = PictureBoxSizeMode.Zoom;
            this.ProfileImage.Image = image;
        }

        internal Label UserLabel { get => userLabel; set => userLabel = value; }
        internal PictureBox ProfileImage { get => profileImage; set => profileImage = value; }

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
            this.UserLabel.Text = $"{this.user.First_name} {this.user.Surname}";
        }
    }
}
