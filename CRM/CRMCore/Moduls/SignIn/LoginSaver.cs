using System.IO;

namespace CRMCore.Moduls.SignIn
{
    static class LoginSaver
    {
        private const string path = "savedLogin";
        public static void SaveLogin(string login)
        {
            File.WriteAllText(path, login);
        }

        public static string LoadLogin()
        {
            if (File.Exists(path))
                return File.ReadAllText(path);
            return "";
        }
    }
}
