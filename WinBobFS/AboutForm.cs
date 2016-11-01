using System.Diagnostics;
using System.Windows.Forms;

namespace WinBobFS
{
    public partial class AboutForm : Form
    {
        public AboutForm()
        {
            InitializeComponent();
            VersionLabel.Text = $"WinBobFS {Program.VersionName}";
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://github.com/Shravan2x/WinBobFS");
        }
    }
}
