using AracTakip.Forms;

namespace AracTakip
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private MarkaForm _markaForm;
        private void markaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (_markaForm == null || _markaForm.IsDisposed)
            {
                _markaForm = new MarkaForm();
                _markaForm.MdiParent = this;
                _markaForm.Show();
            }
        }
    }
}