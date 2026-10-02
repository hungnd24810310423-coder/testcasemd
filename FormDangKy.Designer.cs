namespace FormDangKyDangNhap
{
    partial class FormDangKy
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label lblFullName;
        private System.Windows.Forms.TextBox txtFullName;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.MaskedTextBox mtxtPhone;
        private System.Windows.Forms.Label lblBirthDate;
        private System.Windows.Forms.DateTimePicker dtpBirthDate;
        private System.Windows.Forms.Label lblGender;
        private System.Windows.Forms.RadioButton rdoMale;
        private System.Windows.Forms.RadioButton rdoFemale;
        private System.Windows.Forms.Label lblHobby;
        private System.Windows.Forms.CheckBox chkHobby1;
        private System.Windows.Forms.CheckBox chkHobby2;
        private System.Windows.Forms.CheckBox chkHobby3;
        private System.Windows.Forms.Label lblCourse;
        private System.Windows.Forms.ComboBox cboCourse;
        private System.Windows.Forms.Button btnRegister;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            lblFullName = new System.Windows.Forms.Label();
            txtFullName = new System.Windows.Forms.TextBox();
            lblPhone = new System.Windows.Forms.Label();
            mtxtPhone = new System.Windows.Forms.MaskedTextBox();
            lblBirthDate = new System.Windows.Forms.Label();
            dtpBirthDate = new System.Windows.Forms.DateTimePicker();
            lblGender = new System.Windows.Forms.Label();
            rdoMale = new System.Windows.Forms.RadioButton();
            rdoFemale = new System.Windows.Forms.RadioButton();
            lblHobby = new System.Windows.Forms.Label();
            chkHobby1 = new System.Windows.Forms.CheckBox();
            chkHobby2 = new System.Windows.Forms.CheckBox();
            chkHobby3 = new System.Windows.Forms.CheckBox();
            lblCourse = new System.Windows.Forms.Label();
            cboCourse = new System.Windows.Forms.ComboBox();
            btnRegister = new System.Windows.Forms.Button();

            SuspendLayout();

            lblFullName.AutoSize = true;
            lblFullName.Location = new System.Drawing.Point(245, 60);
            lblFullName.Text = "Họ và tên:";

            txtFullName.Location = new System.Drawing.Point(330, 54);
            txtFullName.Size = new System.Drawing.Size(255, 23);

            lblPhone.AutoSize = true;
            lblPhone.Location = new System.Drawing.Point(245, 110);
            lblPhone.Text = "Số điện thoại:";

            mtxtPhone.Location = new System.Drawing.Point(330, 104);
            mtxtPhone.Mask = "(000) 000-0000";
            mtxtPhone.Size = new System.Drawing.Size(255, 23);

            lblBirthDate.AutoSize = true;
            lblBirthDate.Location = new System.Drawing.Point(245, 160);
            lblBirthDate.Text = "Ngày sinh:";

            dtpBirthDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            dtpBirthDate.Location = new System.Drawing.Point(330, 154);
            dtpBirthDate.Size = new System.Drawing.Size(255, 23);

            lblGender.AutoSize = true;
            lblGender.Location = new System.Drawing.Point(245, 210);
            lblGender.Text = "Giới tính:";

            rdoMale.AutoSize = true;
            rdoMale.Location = new System.Drawing.Point(388, 207);
            rdoMale.Text = "Nam";

            rdoFemale.AutoSize = true;
            rdoFemale.Location = new System.Drawing.Point(485, 207);
            rdoFemale.Text = "Nữ";

            lblHobby.AutoSize = true;
            lblHobby.Location = new System.Drawing.Point(245, 250);
            lblHobby.Text = "Sở thích:";

            chkHobby1.AutoSize = true;
            chkHobby1.Location = new System.Drawing.Point(330, 248);
            chkHobby1.Text = "Tư duy";

            chkHobby2.AutoSize = true;
            chkHobby2.Location = new System.Drawing.Point(410, 248);
            chkHobby2.Text = "Phân tích";

            chkHobby3.AutoSize = true;
            chkHobby3.Location = new System.Drawing.Point(500, 248);
            chkHobby3.Text = "Sáng tạo";

            lblCourse.AutoSize = true;
            lblCourse.Location = new System.Drawing.Point(245, 290);
            lblCourse.Text = "Khóa học:";

            cboCourse.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            cboCourse.Location = new System.Drawing.Point(330, 284);
            cboCourse.Size = new System.Drawing.Size(255, 23);

            btnRegister.Location = new System.Drawing.Point(390, 330);
            btnRegister.Size = new System.Drawing.Size(90, 30);
            btnRegister.Text = "Đăng ký";
            btnRegister.UseVisualStyleBackColor = true;
            btnRegister.Click += btnRegister_Click;

            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(840, 480);
            Controls.Add(lblFullName);
            Controls.Add(txtFullName);
            Controls.Add(lblPhone);
            Controls.Add(mtxtPhone);
            Controls.Add(lblBirthDate);
            Controls.Add(dtpBirthDate);
            Controls.Add(lblGender);
            Controls.Add(rdoMale);
            Controls.Add(rdoFemale);
            Controls.Add(lblHobby);
            Controls.Add(chkHobby1);
            Controls.Add(chkHobby2);
            Controls.Add(chkHobby3);
            Controls.Add(lblCourse);
            Controls.Add(cboCourse);
            Controls.Add(btnRegister);
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "Đăng ký học viên";

            Load += FormDangKy_Load;

            ResumeLayout(false);
            PerformLayout();
        }
    }
}
