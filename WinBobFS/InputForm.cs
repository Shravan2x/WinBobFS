using System.Windows.Forms;

namespace WinBobFS
{
    public partial class InputForm : Form
    {
        public string Input { get; private set; }

        public InputForm(string message)
        {
            InitializeComponent();

            MessageLabel.Text = message;
            Input = null;
        }

        private void OkButton_Click(object sender, System.EventArgs e)
        {
            Input = InputBox.Text;
            Visible = false;
        }

        private void CancelButton_Click(object sender, System.EventArgs e)
        {
            Input = null;
            Visible = false;
        }

        private void InputBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode != Keys.Enter)
                return;

            Input = InputBox.Text;
            Visible = false;
        }
    }
}
