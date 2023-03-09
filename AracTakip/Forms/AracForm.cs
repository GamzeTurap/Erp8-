using AracTakip.Data;
using AracTakip.Helpers;
using AracTakip.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AracTakip.Forms;

public partial class AracForm : Form
{
    public AracForm()
    {
        InitializeComponent();
    }
    public EnvanterContext DataContext { get; set; }
    private void AracForm_Load(object sender, EventArgs e)
    {
        cmbMarka.DataSource = DataContext.Markalar;
        cmbModel.DataSource = DataContext.Modeller;
    }

    private void cmbMarka_SelectedIndexChanged(object sender, EventArgs e)
    {
        if (cmbMarka.SelectedIndex == -1) return;
        Marka seciliMarka = (Marka)cmbMarka.SelectedItem;
        cmbModel.DataSource = DataContext.Modeller.Where(x => x.Marka.Id == seciliMarka.Id).ToList();
    }

    private void btnKaydet_Click(object sender, EventArgs e)
    {
        try
        {
            Arac arac = new Arac()
            {
                Plaka = txtPlaka.Text,
                Model = (Model)cmbModel.SelectedItem
            };
            DataContext.Araclar.Add(arac);
            lstListe.DataSource = null;
            lstListe.DataSource = DataContext.Araclar;
            DataHelper.Save(DataContext);
        }
        catch (Exception ex)
        {
            MessageBox.Show($"Bir hata oluştu:{ex.Message}");
        }
    }

    private void lstListe_SelectedIndexChanged(object sender, EventArgs e)
    {
        if (lstListe.SelectedIndex == -1) return;
        Arac seciliArac = (Arac)lstListe.SelectedItem;
        txtPlaka.Text = seciliArac.Plaka;
        cmbMarka.SelectedItem = DataContext.Markalar.First(x => x.Id == seciliArac.Model.Marka.Id);
        //First bulamazsa hata veriyor.Kesin emin isek First kullanılmalıdır.
        //Find bulamazsa null döndürüyor.
        //FirstOfDifault find e teknik olarak benzer. Null değil bir değer atar.
        cmbModel.SelectedItem = DataContext.Modeller.First(x => x.Id == seciliArac.Model.Id);
    }
}
