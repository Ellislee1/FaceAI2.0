
namespace FaceAI
{
    partial class HomePage
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnRegister = new System.Windows.Forms.Button();
            this.btnLogIn = new System.Windows.Forms.Button();
            this.grpLogin = new System.Windows.Forms.GroupBox();
            this.pnlUser = new System.Windows.Forms.Panel();
            this.btnEdit = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.lstProfiles = new System.Windows.Forms.ListBox();
            this.btnNewProfile = new System.Windows.Forms.Button();
            this.pctUser = new System.Windows.Forms.PictureBox();
            this.btnLogout = new System.Windows.Forms.Button();
            this.lblWelcome = new System.Windows.Forms.Label();
            this.pctCompare = new System.Windows.Forms.PictureBox();
            this.btnUpload = new System.Windows.Forms.Button();
            this.lstSimilarFaces = new System.Windows.Forms.ListBox();
            this.pbarProgress = new System.Windows.Forms.ProgressBar();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label5 = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.ctxClose = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.mnuClose = new System.Windows.Forms.ToolStripMenuItem();
            this.grpLogin.SuspendLayout();
            this.pnlUser.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctUser)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctCompare)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.ctxClose.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtUsername
            // 
            this.txtUsername.Location = new System.Drawing.Point(87, 31);
            this.txtUsername.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtUsername.MaxLength = 20;
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(140, 27);
            this.txtUsername.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Username";
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(87, 87);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtPassword.MaxLength = 20;
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(140, 27);
            this.txtPassword.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Password";
            // 
            // btnRegister
            // 
            this.btnRegister.Location = new System.Drawing.Point(15, 125);
            this.btnRegister.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(86, 31);
            this.btnRegister.TabIndex = 4;
            this.btnRegister.Text = "Register";
            this.btnRegister.UseVisualStyleBackColor = true;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // btnLogIn
            // 
            this.btnLogIn.Location = new System.Drawing.Point(142, 125);
            this.btnLogIn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnLogIn.Name = "btnLogIn";
            this.btnLogIn.Size = new System.Drawing.Size(86, 31);
            this.btnLogIn.TabIndex = 5;
            this.btnLogIn.Text = "Login";
            this.btnLogIn.UseVisualStyleBackColor = true;
            this.btnLogIn.Click += new System.EventHandler(this.btnLogIn_Click);
            // 
            // grpLogin
            // 
            this.grpLogin.Controls.Add(this.txtPassword);
            this.grpLogin.Controls.Add(this.btnLogIn);
            this.grpLogin.Controls.Add(this.txtUsername);
            this.grpLogin.Controls.Add(this.btnRegister);
            this.grpLogin.Controls.Add(this.label1);
            this.grpLogin.Controls.Add(this.label2);
            this.grpLogin.Location = new System.Drawing.Point(14, 16);
            this.grpLogin.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.grpLogin.Name = "grpLogin";
            this.grpLogin.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.grpLogin.Size = new System.Drawing.Size(234, 172);
            this.grpLogin.TabIndex = 6;
            this.grpLogin.TabStop = false;
            this.grpLogin.Text = "Login";
            // 
            // pnlUser
            // 
            this.pnlUser.Controls.Add(this.btnEdit);
            this.pnlUser.Controls.Add(this.label3);
            this.pnlUser.Controls.Add(this.lstProfiles);
            this.pnlUser.Controls.Add(this.btnNewProfile);
            this.pnlUser.Controls.Add(this.pctUser);
            this.pnlUser.Controls.Add(this.btnLogout);
            this.pnlUser.Controls.Add(this.lblWelcome);
            this.pnlUser.Location = new System.Drawing.Point(14, 16);
            this.pnlUser.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pnlUser.Name = "pnlUser";
            this.pnlUser.Size = new System.Drawing.Size(317, 568);
            this.pnlUser.TabIndex = 7;
            this.pnlUser.Visible = false;
            this.pnlUser.VisibleChanged += new System.EventHandler(this.pnlUser_VisibleChanged);
            // 
            // btnEdit
            // 
            this.btnEdit.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnEdit.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnEdit.Location = new System.Drawing.Point(213, 533);
            this.btnEdit.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(86, 31);
            this.btnEdit.TabIndex = 11;
            this.btnEdit.Text = "Edit Profile";
            this.btnEdit.UseVisualStyleBackColor = false;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 296);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 20);
            this.label3.TabIndex = 8;
            this.label3.Text = "Your Profiles";
            // 
            // lstProfiles
            // 
            this.lstProfiles.FormattingEnabled = true;
            this.lstProfiles.ItemHeight = 20;
            this.lstProfiles.Location = new System.Drawing.Point(11, 320);
            this.lstProfiles.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lstProfiles.Name = "lstProfiles";
            this.lstProfiles.Size = new System.Drawing.Size(286, 204);
            this.lstProfiles.TabIndex = 10;
            // 
            // btnNewProfile
            // 
            this.btnNewProfile.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnNewProfile.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnNewProfile.Location = new System.Drawing.Point(120, 533);
            this.btnNewProfile.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnNewProfile.Name = "btnNewProfile";
            this.btnNewProfile.Size = new System.Drawing.Size(86, 31);
            this.btnNewProfile.TabIndex = 9;
            this.btnNewProfile.Text = "Add Profile";
            this.btnNewProfile.UseVisualStyleBackColor = false;
            this.btnNewProfile.Click += new System.EventHandler(this.btnNewProfile_Click);
            // 
            // pctUser
            // 
            this.pctUser.Location = new System.Drawing.Point(11, 43);
            this.pctUser.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pctUser.Name = "pctUser";
            this.pctUser.Size = new System.Drawing.Size(287, 240);
            this.pctUser.TabIndex = 8;
            this.pctUser.TabStop = false;
            this.pctUser.Click += new System.EventHandler(this.pctUser_Click);
            // 
            // btnLogout
            // 
            this.btnLogout.BackColor = System.Drawing.Color.Red;
            this.btnLogout.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnLogout.Location = new System.Drawing.Point(3, 533);
            this.btnLogout.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(86, 31);
            this.btnLogout.TabIndex = 1;
            this.btnLogout.Text = "Log Out";
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // lblWelcome
            // 
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblWelcome.Location = new System.Drawing.Point(17, 11);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(321, 28);
            this.lblWelcome.TabIndex = 0;
            this.lblWelcome.Text = "Welcome <Firstname> <Surname>";
            this.lblWelcome.Click += new System.EventHandler(this.lblWelcome_Click);
            // 
            // pctCompare
            // 
            this.pctCompare.Location = new System.Drawing.Point(349, 16);
            this.pctCompare.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pctCompare.Name = "pctCompare";
            this.pctCompare.Size = new System.Drawing.Size(362, 240);
            this.pctCompare.TabIndex = 9;
            this.pctCompare.TabStop = false;
            // 
            // btnUpload
            // 
            this.btnUpload.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnUpload.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnUpload.Location = new System.Drawing.Point(349, 264);
            this.btnUpload.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnUpload.Name = "btnUpload";
            this.btnUpload.Size = new System.Drawing.Size(86, 31);
            this.btnUpload.TabIndex = 10;
            this.btnUpload.Text = "Upload";
            this.btnUpload.UseVisualStyleBackColor = false;
            this.btnUpload.Click += new System.EventHandler(this.btnUpload_Click);
            // 
            // lstSimilarFaces
            // 
            this.lstSimilarFaces.FormattingEnabled = true;
            this.lstSimilarFaces.ItemHeight = 20;
            this.lstSimilarFaces.Location = new System.Drawing.Point(718, 16);
            this.lstSimilarFaces.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lstSimilarFaces.Name = "lstSimilarFaces";
            this.lstSimilarFaces.Size = new System.Drawing.Size(182, 244);
            this.lstSimilarFaces.TabIndex = 11;
            this.lstSimilarFaces.SelectedIndexChanged += new System.EventHandler(this.lstSimilarFaces_SelectedIndexChanged);
            // 
            // pbarProgress
            // 
            this.pbarProgress.Location = new System.Drawing.Point(441, 264);
            this.pbarProgress.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pbarProgress.Name = "pbarProgress";
            this.pbarProgress.Size = new System.Drawing.Size(459, 31);
            this.pbarProgress.TabIndex = 12;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Location = new System.Drawing.Point(349, 303);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(552, 287);
            this.tabControl1.TabIndex = 13;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.listBox1);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.pictureBox1);
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabPage1.Size = new System.Drawing.Size(544, 254);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(191, 104);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(120, 23);
            this.label5.TabIndex = 15;
            this.label5.Text = "Online Profiles";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 20;
            this.listBox1.Location = new System.Drawing.Point(191, 131);
            this.listBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(345, 104);
            this.listBox1.TabIndex = 14;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(7, 4);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(137, 23);
            this.label4.TabIndex = 13;
            this.label4.Text = "No user selected";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(7, 31);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(177, 205);
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // ctxClose
            // 
            this.ctxClose.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.ctxClose.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuClose});
            this.ctxClose.Name = "ctxClose";
            this.ctxClose.Size = new System.Drawing.Size(142, 28);
            this.ctxClose.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.ctxClose_ItemClicked);
            // 
            // mnuClose
            // 
            this.mnuClose.Name = "mnuClose";
            this.mnuClose.Size = new System.Drawing.Size(141, 24);
            this.mnuClose.Text = "Close Tab";
            // 
            // HomePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(915, 608);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.pbarProgress);
            this.Controls.Add(this.lstSimilarFaces);
            this.Controls.Add(this.btnUpload);
            this.Controls.Add(this.pctCompare);
            this.Controls.Add(this.pnlUser);
            this.Controls.Add(this.grpLogin);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "HomePage";
            this.Text = "Home";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.HomePage_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.HomePage_FormClosed);
            this.grpLogin.ResumeLayout(false);
            this.grpLogin.PerformLayout();
            this.pnlUser.ResumeLayout(false);
            this.pnlUser.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctUser)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctCompare)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ctxClose.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.Button btnLogIn;
        private System.Windows.Forms.GroupBox grpLogin;
        private System.Windows.Forms.Panel pnlUser;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.PictureBox pctUser;
        private System.Windows.Forms.Button btnNewProfile;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox lstProfiles;
        private System.Windows.Forms.PictureBox pctCompare;
        private System.Windows.Forms.Button btnUpload;
        private System.Windows.Forms.ListBox lstSimilarFaces;
        private System.Windows.Forms.ProgressBar pbarProgress;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ContextMenuStrip ctxClose;
        private System.Windows.Forms.ToolStripMenuItem mnuClose;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnEdit;
    }
}

