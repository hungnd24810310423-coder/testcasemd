using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace FormDangKyDangNhap
{
    public partial class FormDangKy : Form
    {
        private List<Course> courses = new List<Course>();

        public FormDangKy()
        {
            InitializeComponent();
        }

        private void FormDangKy_Load(object sender, EventArgs e)
        {
            courses.Add(new Course("Lập trình C#", "CSHARP"));
            courses.Add(new Course("Lập trình Java", "JAVA"));
            courses.Add(new Course("Lập trình C++", "CPP"));
            courses.Add(new Course("Python", "PYTHON"));

            cboCourse.DataSource = courses;
            cboCourse.DisplayMember = "DisplayMember";
            cboCourse.ValueMember = "ValueMember";
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            string gender;

            if (rdoMale.Checked)
                gender = "Nam";
            else if (rdoFemale.Checked)
                gender = "Nữ";
            else
                gender = "Chưa chọn";

            string hobbies = "";

            if (chkHobby1.Checked)
                hobbies += "Tư duy, ";

            if (chkHobby2.Checked)
                hobbies += "Phân tích, ";

            if (chkHobby3.Checked)
                hobbies += "Sáng tạo, ";

            hobbies = hobbies.TrimEnd(',', ' ');

            if (hobbies == "")
                hobbies = "Không có";

            if (txtFullName.Text.Trim() == "")
            {
                MessageBox.Show("Vui lòng nhập họ và tên.");
                txtFullName.Focus();
                return;
            }

            string birthDate = dtpBirthDate.Value.ToString("dd/MM/yyyy");
            string courseName = cboCourse.Text;
            string courseCode = cboCourse.SelectedValue.ToString();

            MessageBox.Show(
                "Họ và tên: " + txtFullName.Text + "\n" +
                "Số điện thoại: " + mtxtPhone.Text + "\n" +
                "Ngày sinh: " + birthDate + "\n" +
                "Giới tính: " + gender + "\n" +
                "Khóa học: " + courseName + "\n" +
                "Mã khóa học: " + courseCode + "\n" +
                "Sở thích: " + hobbies,
                "Thông tin đăng ký",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }
    }
}
