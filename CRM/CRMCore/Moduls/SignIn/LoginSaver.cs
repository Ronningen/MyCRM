using System.IO;

namespace CRMCore.Moduls.SignIn
{
    /// <summary>
    /// Provides tools to save and load login.
    /// </summary>
    static class LoginSaver
    {
        private const string path = "savedLogin";

        /// <summary>
        /// Saves login into public file.
        /// </summary>
        /// <param name="login"></param>
        public static void SaveLogin(string login)
        {
            File.WriteAllText(path, login);
        }

        /// <summary>
        /// Loads login if it had been saved once.
        /// </summary>
        /// <returns> login </returns>
        public static string LoadLogin()
        {
            if (File.Exists(path))
                return File.ReadAllText(path);
            return "";
        }
    }
}
