namespace FormDangKyDangNhap
{
    public class Course
    {
        public string DisplayMember { get; set; }
        public string ValueMember { get; set; }

        public Course(string name, string code)
        {
            DisplayMember = name;
            ValueMember = code;
        }

        public override string ToString()
        {
            return DisplayMember;
        }
    }
}
