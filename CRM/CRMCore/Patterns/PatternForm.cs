using System.Windows.Forms;

namespace CRMCore.Patterns
{
    public partial class PatternForm : Form
    {
        /// <summary>
        /// Order not using dialof for closing form
        /// </summary>
        protected bool forceClosing;

        public PatternForm()
        {
            InitializeComponent();
        }

        private void PatternForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!forceClosing && e.CloseReason == CloseReason.UserClosing)
            {
                var res = MessageBox.Show("Do you really want to close the window?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                e.Cancel = res != DialogResult.Yes;
            }
        }

        private void PatternForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            forceClosing = false;
        }

        /// <summary>
        /// Messege user some information withpout caption
        /// </summary>
        /// <param name="messege"> showing messege </param>
        public void Inform(string messege)
        { 
            MessageBox.Show(messege, "", MessageBoxButtons.OK, MessageBoxIcon.Information); 
        }
    }
}
