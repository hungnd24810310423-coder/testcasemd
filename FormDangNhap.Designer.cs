namespace FormDangKyDangNhap
{
    partial class FormDangNhap
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.CheckBox chkShowPassword;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Button btnRegister;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            lblTitle = new System.Windows.Forms.Label();
            lblUsername = new System.Windows.Forms.Label();
            lblPassword = new System.Windows.Forms.Label();
            txtUsername = new System.Windows.Forms.TextBox();
            txtPassword = new System.Windows.Forms.TextBox();
            chkShowPassword = new System.Windows.Forms.CheckBox();
            btnLogin = new System.Windows.Forms.Button();
            btnRegister = new System.Windows.Forms.Button();

            SuspendLayout();

            lblTitle.AutoSize = true;
            lblTitle.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            lblTitle.Location = new System.Drawing.Point(135, 35);
            lblTitle.Text = "ĐĂNG NHẬP";

            lblUsername.AutoSize = true;
            lblUsername.Location = new System.Drawing.Point(55, 105);
            lblUsername.Text = "Tên đăng nhập:";

            lblPassword.AutoSize = true;
            lblPassword.Location = new System.Drawing.Point(55, 150);
            lblPassword.Text = "Mật khẩu:";

            txtUsername.Location = new System.Drawing.Point(170, 102);
            txtUsername.Size = new System.Drawing.Size(230, 23);

            txtPassword.Location = new System.Drawing.Point(170, 147);
            txtPassword.Size = new System.Drawing.Size(230, 23);
            txtPassword.PasswordChar = '*';

            chkShowPassword.AutoSize = true;
            chkShowPassword.Location = new System.Drawing.Point(170, 180);
            chkShowPassword.Text = "Hiện mật khẩu";
            chkShowPassword.CheckedChanged += chkShowPassword_CheckedChanged;

            btnLogin.Location = new System.Drawing.Point(170, 220);
            btnLogin.Size = new System.Drawing.Size(105, 32);
            btnLogin.Text = "Đăng nhập";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += btnLogin_Click;

            btnRegister.Location = new System.Drawing.Point(295, 220);
            btnRegister.Size = new System.Drawing.Size(105, 32);
            btnRegister.Text = "Đăng ký";
            btnRegister.UseVisualStyleBackColor = true;
            btnRegister.Click += btnRegister_Click;

            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(470, 300);
            Controls.Add(lblTitle);
            Controls.Add(lblUsername);
            Controls.Add(lblPassword);
            Controls.Add(txtUsername);
            Controls.Add(txtPassword);
            Controls.Add(chkShowPassword);
            Controls.Add(btnLogin);
            Controls.Add(btnRegister);
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "Đăng nhập";

            ResumeLayout(false);
            PerformLayout();
        }
    }
}
