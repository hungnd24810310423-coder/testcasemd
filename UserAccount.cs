namespace FormDangKyDangNhap
{
    public static class UserAccount
    {
        public static string Username = "admin";
        public static string Password = "123456";
        public static string FullName = "Quản trị viên";

        public static void Register(string username, string password, string fullName)
        {
            Username = username;
            Password = password;
            FullName = fullName;
        }
    }
}
