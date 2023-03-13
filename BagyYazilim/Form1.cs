using System.Security.Cryptography.X509Certificates;

namespace BagyYazilim;

public partial class Form1 : Form
{
    public Form1()
    {
        InitializeComponent();
    }

    private void ekleToolStripMenuItem_Click(object sender, EventArgs e)
    {
        flpKat.Controls.Clear();
        for (int kat = 1; kat < 7; kat++)
        {

            int sonrakiKat = kat;

            string btnText = $"{kat}";
            Button yeniButon = ButonUret(btnText);
            flpKat.Controls.Add(yeniButon);

        }

    }

    private void ekleToolStripMenuItem2_Click(object sender, EventArgs e)
    {
        flpMasa.Controls.Clear();
        int katSayisi = int.Parse()
        for (int kat = 1; kat <=katSayisi; kat++)
        {

            int sonrakiKat = kat;

            string btnText = $"{kat}";
            Button yeniButon = ButonUret(btnText);
            flpMasa.Controls.Add(yeniButon);
        }
    }
    private Button ButonUret(string btnText)
    {
        Button btn = new Button()
        {
            Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point),
            Text = btnText,
            Size = new Size(50, 50),
        };
        btn.Click += BtnKatEkle_Click;
        return btn;
    }

    private void BtnKatEkle_Click(object? sender, EventArgs e)
    {
        Button basilanButon = (Button)sender;
        this.Text = basilanButon.Text;
    }
}