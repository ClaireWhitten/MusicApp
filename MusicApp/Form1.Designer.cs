
namespace MusicApp
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblMusicApp = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_FirstName = new System.Windows.Forms.TextBox();
            this.txt_createEmail = new System.Windows.Forms.TextBox();
            this.txt_createPassword = new System.Windows.Forms.TextBox();
            this.txt_LoginPassword = new System.Windows.Forms.TextBox();
            this.txtLoginEmail = new System.Windows.Forms.TextBox();
            this.btn_createAccount = new System.Windows.Forms.Button();
            this.btn_login = new System.Windows.Forms.Button();
            this.txt_LastName = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblMusicApp
            // 
            this.lblMusicApp.AutoSize = true;
            this.lblMusicApp.Location = new System.Drawing.Point(445, 53);
            this.lblMusicApp.Name = "lblMusicApp";
            this.lblMusicApp.Size = new System.Drawing.Size(37, 13);
            this.lblMusicApp.TabIndex = 0;
            this.lblMusicApp.Text = "Log In";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(96, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Create account";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(46, 211);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Email";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(46, 103);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "First Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(46, 254);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Password";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(368, 103);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Email";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(368, 157);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Password";
            // 
            // txt_FirstName
            // 
            this.txt_FirstName.Location = new System.Drawing.Point(110, 103);
            this.txt_FirstName.Name = "txt_FirstName";
            this.txt_FirstName.Size = new System.Drawing.Size(100, 20);
            this.txt_FirstName.TabIndex = 6;
            // 
            // txt_createEmail
            // 
            this.txt_createEmail.Location = new System.Drawing.Point(110, 211);
            this.txt_createEmail.Name = "txt_createEmail";
            this.txt_createEmail.Size = new System.Drawing.Size(100, 20);
            this.txt_createEmail.TabIndex = 6;
            // 
            // txt_createPassword
            // 
            this.txt_createPassword.Location = new System.Drawing.Point(110, 254);
            this.txt_createPassword.Name = "txt_createPassword";
            this.txt_createPassword.Size = new System.Drawing.Size(100, 20);
            this.txt_createPassword.TabIndex = 6;
            // 
            // txt_LoginPassword
            // 
            this.txt_LoginPassword.Location = new System.Drawing.Point(433, 157);
            this.txt_LoginPassword.Name = "txt_LoginPassword";
            this.txt_LoginPassword.Size = new System.Drawing.Size(100, 20);
            this.txt_LoginPassword.TabIndex = 7;
            // 
            // txtLoginEmail
            // 
            this.txtLoginEmail.Location = new System.Drawing.Point(433, 100);
            this.txtLoginEmail.Name = "txtLoginEmail";
            this.txtLoginEmail.Size = new System.Drawing.Size(100, 20);
            this.txtLoginEmail.TabIndex = 8;
            // 
            // btn_createAccount
            // 
            this.btn_createAccount.Location = new System.Drawing.Point(99, 304);
            this.btn_createAccount.Name = "btn_createAccount";
            this.btn_createAccount.Size = new System.Drawing.Size(92, 30);
            this.btn_createAccount.TabIndex = 9;
            this.btn_createAccount.Text = "Create";
            this.btn_createAccount.UseVisualStyleBackColor = true;
            this.btn_createAccount.Click += new System.EventHandler(this.btn_createAccount_Click);
            // 
            // btn_login
            // 
            this.btn_login.Location = new System.Drawing.Point(417, 211);
            this.btn_login.Name = "btn_login";
            this.btn_login.Size = new System.Drawing.Size(92, 30);
            this.btn_login.TabIndex = 10;
            this.btn_login.Text = "Log in";
            this.btn_login.UseVisualStyleBackColor = true;
            this.btn_login.Click += new System.EventHandler(this.btn_login_Click);
            // 
            // txt_LastName
            // 
            this.txt_LastName.Location = new System.Drawing.Point(110, 157);
            this.txt_LastName.Name = "txt_LastName";
            this.txt_LastName.Size = new System.Drawing.Size(100, 20);
            this.txt_LastName.TabIndex = 11;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(46, 160);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(58, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "Last Name";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(643, 360);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txt_LastName);
            this.Controls.Add(this.btn_login);
            this.Controls.Add(this.btn_createAccount);
            this.Controls.Add(this.txtLoginEmail);
            this.Controls.Add(this.txt_LoginPassword);
            this.Controls.Add(this.txt_createPassword);
            this.Controls.Add(this.txt_createEmail);
            this.Controls.Add(this.txt_FirstName);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblMusicApp);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMusicApp;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_FirstName;
        private System.Windows.Forms.TextBox txt_createEmail;
        private System.Windows.Forms.TextBox txt_createPassword;
        private System.Windows.Forms.TextBox txt_LoginPassword;
        private System.Windows.Forms.TextBox txtLoginEmail;
        private System.Windows.Forms.Button btn_createAccount;
        private System.Windows.Forms.Button btn_login;
        private System.Windows.Forms.TextBox txt_LastName;
        private System.Windows.Forms.Label label7;
    }
}

