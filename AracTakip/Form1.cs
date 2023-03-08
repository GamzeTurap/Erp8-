using AracTakip.Forms;
using AracTakip.Models;

namespace AracTakip
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private MarkaForm _markaForm;
        private ModelForm _modelForm;
        private void markaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (_markaForm == null || _markaForm.IsDisposed)
            {
                _markaForm = new MarkaForm();
                _markaForm.MdiParent = this;
                _markaForm.Text = "Marka Formu";
                _markaForm.Show();
            }
        }
        private void modelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _modelForm = new ModelForm();
            _modelForm.MdiParent = this;
            _modelForm.Text = "Model Formu";
            _modelForm.Markalar = new List<Marka>();
            _modelForm.Show();
        }
    }
}