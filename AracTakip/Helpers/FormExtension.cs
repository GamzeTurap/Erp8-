using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Authentication.ExtendedProtection;
using System.Text;
using System.Threading.Tasks;

namespace AracTakip.Helpers;
//static demek hazır asker demek. Değer tutmuyor. Biz istediğimiz zaman çağırıyoruz.
public static class FormExtension //Sınıf tanımı da static olmalı
{
    //Extansin metot
    //Static olarak tanımlanmaktadır.
    public static void FormCleaner(this Form form, Control.ControlCollection conteiner)//this ifadesinden sonra yazılan nesneye extend edilecektir.
    {
        foreach (Control item in conteiner)
            {
            if (item is TextBox)
                item.Text = string.Empty;
            else if (item is ComboBox cmb)
                cmb.SelectedIndex = 0;
            else if (item is NumericUpDown nud)
                nud.Value = 0;
            else if (item is DateTimePicker dtp)
                dtp.Value = DateTime.Now;
            else if (item is CheckBox chk)
                chk.Checked = false;
            else if (item is RadioButton rdb)
                rdb.Checked = false;
            else if (item is PictureBox pic)
                pic.Image = null;
            else if (item is GroupBox gbox)
                FormCleaner(form, gbox.Controls);
            else if (item is Panel pnl)
                FormCleaner(form, pnl.Controls);
        }
    }

}
