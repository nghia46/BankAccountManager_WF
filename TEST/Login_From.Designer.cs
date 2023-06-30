namespace Managerment
{
    partial class Login_From
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
            txtUsername = new TextBox();
            txtPassword = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            cbshowpass = new CheckBox();
            btnLogin = new Button();
            btnAdmin = new Button();
            SuspendLayout();
            // 
            // txtUsername
            // 
            txtUsername.Location = new Point(219, 201);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(352, 23);
            txtUsername.TabIndex = 0;
            txtUsername.KeyDown += txtUsername_KeyDown;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(219, 245);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(352, 23);
            txtPassword.TabIndex = 1;
            txtPassword.KeyDown += txtPassword_KeyDown;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 50F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(308, 73);
            label1.Name = "label1";
            label1.Size = new Size(202, 89);
            label1.TabIndex = 2;
            label1.Text = "Login";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(105, 196);
            label2.Name = "label2";
            label2.Size = new Size(108, 28);
            label2.TabIndex = 3;
            label2.Text = "User Name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(120, 240);
            label3.Name = "label3";
            label3.Size = new Size(93, 28);
            label3.TabIndex = 4;
            label3.Text = "Password";
            // 
            // cbshowpass
            // 
            cbshowpass.AutoSize = true;
            cbshowpass.Location = new Point(577, 247);
            cbshowpass.Name = "cbshowpass";
            cbshowpass.Size = new Size(108, 19);
            cbshowpass.TabIndex = 5;
            cbshowpass.Text = "Show password";
            cbshowpass.UseVisualStyleBackColor = true;
            cbshowpass.CheckedChanged += cbshowpass_CheckedChanged;
            // 
            // btnLogin
            // 
            btnLogin.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            btnLogin.Location = new Point(308, 274);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(141, 48);
            btnLogin.TabIndex = 6;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += btnLogin_Click;
            // 
            // btnAdmin
            // 
            btnAdmin.Location = new Point(687, 391);
            btnAdmin.Name = "btnAdmin";
            btnAdmin.Size = new Size(101, 47);
            btnAdmin.TabIndex = 7;
            btnAdmin.Text = "ADMIN";
            btnAdmin.UseVisualStyleBackColor = true;
            btnAdmin.Click += btnAdmin_Click;
            // 
            // Login_From
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnAdmin);
            Controls.Add(btnLogin);
            Controls.Add(cbshowpass);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtPassword);
            Controls.Add(txtUsername);
            Name = "Login_From";
            Text = "Login_From";
            KeyDown += Login_From_KeyDown;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtUsername;
        private TextBox txtPassword;
        private Label label1;
        private Label label2;
        private Label label3;
        private CheckBox cbshowpass;
        private Button btnLogin;
        private Button btnAdmin;
    }
}