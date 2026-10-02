using System;
using System.Drawing;
using System.Windows.Forms;

namespace FormDangKyDangNhap
{
    public partial class FormDangNhap : Form
    {
        public FormDangNhap()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text;

            if (username == "" || password == "")
            {
                MessageBox.Show(
                    "Vui lòng nhập đầy đủ tên đăng nhập và mật khẩu.",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }

            if (username == UserAccount.Username && password == UserAccount.Password)
            {
                MessageBox.Show(
                    "Đăng nhập thành công!",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                FormDangKy form = new FormDangKy();
                form.FormClosed += (s, args) => this.Close();
                form.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show(
                    "Sai tên đăng nhập hoặc mật khẩu.",
                    "Đăng nhập",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            using (FormDangKyTaiKhoan form = new FormDangKyTaiKhoan())
            {
                form.ShowDialog();
            }
        }

        private void chkShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            txtPassword.PasswordChar = chkShowPassword.Checked ? '\0' : '*';
        }
    }

    public class FormDangKyTaiKhoan : Form
    {
        private TextBox txtUsername;
        private TextBox txtPassword;
        private TextBox txtConfirm;
        private TextBox txtFullName;

        public FormDangKyTaiKhoan()
        {
            Text = "Đăng ký tài khoản";
            StartPosition = FormStartPosition.CenterScreen;
            ClientSize = new Size(430, 330);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;

            Label title = new Label
            {
                Text = "ĐĂNG KÝ TÀI KHOẢN",
                Font = new Font("Segoe UI", 14, FontStyle.Bold),
                AutoSize = true,
                Location = new Point(110, 25)
            };

            Label l1 = new Label { Text = "Tên đăng nhập:", AutoSize = true, Location = new Point(45, 85) };
            Label l2 = new Label { Text = "Mật khẩu:", AutoSize = true, Location = new Point(45, 125) };
            Label l3 = new Label { Text = "Nhập lại mật khẩu:", AutoSize = true, Location = new Point(45, 165) };
            Label l4 = new Label { Text = "Họ và tên:", AutoSize = true, Location = new Point(45, 205) };

            txtUsername = new TextBox { Location = new Point(165, 82), Size = new Size(210, 23) };
            txtPassword = new TextBox { Location = new Point(165, 122), Size = new Size(210, 23), PasswordChar = '*' };
            txtConfirm = new TextBox { Location = new Point(165, 162), Size = new Size(210, 23), PasswordChar = '*' };
            txtFullName = new TextBox { Location = new Point(165, 202), Size = new Size(210, 23) };

            Button btnRegister = new Button
            {
                Text = "Đăng ký",
                Location = new Point(165, 250),
                Size = new Size(90, 30)
            };
            btnRegister.Click += btnRegister_Click;

            Button btnCancel = new Button
            {
                Text = "Hủy",
                Location = new Point(265, 250),
                Size = new Size(90, 30)
            };
            btnCancel.Click += (s, e) => Close();

            Controls.AddRange(new Control[]
            {
                title, l1, l2, l3, l4,
                txtUsername, txtPassword, txtConfirm, txtFullName,
                btnRegister, btnCancel
            });
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text;
            string confirm = txtConfirm.Text;
            string fullName = txtFullName.Text.Trim();

            if (username == "" || password == "" || confirm == "" || fullName == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin.");
                return;
            }

            if (password != confirm)
            {
                MessageBox.Show("Mật khẩu nhập lại không khớp.");
                return;
            }

            UserAccount.Register(username, password, fullName);

            MessageBox.Show(
                "Đăng ký thành công!\nTên đăng nhập: " + username,
                "Thông báo",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);

            Close();
        }
    }
}
