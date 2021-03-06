﻿using System.Windows.Forms;

namespace CRMCore.Extansions
{
    public static class FormExtension
    {
        /// <summary>
        /// Hides sender, showes dialogForm as modal dialog form and showes sender after closing dialogForm
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="dialogForm"></param>
        public static void OpenAsDialog(this Form sender, Form dialogForm)
        {
            sender.Hide();
            dialogForm.ShowDialog();
            sender.Show();
        }
    }
}
