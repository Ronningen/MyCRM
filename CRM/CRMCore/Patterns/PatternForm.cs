using System.Windows.Forms;

namespace CRMCore.Patterns
{
    abstract public partial class PatternForm : Form
    {
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
    }
}
