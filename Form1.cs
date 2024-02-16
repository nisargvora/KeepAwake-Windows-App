using System.Windows.Forms;

namespace KeepAwake
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
            timer1.Start();
        }

        protected override void SetVisibleCore(bool value)
        {
            base.SetVisibleCore(false);
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            SendKeys.Send("{F15}");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Hide();
            notifyIcon1.Visible = true;
        }
    }
}
