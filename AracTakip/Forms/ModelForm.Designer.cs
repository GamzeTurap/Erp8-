namespace AracTakip.Forms
{
    partial class ModelForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnGuncelle = new Button();
            btnKaydet = new Button();
            lstListe = new ListBox();
            txtAd = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            cmbMarka = new ComboBox();
            cmbKasaTipi = new ComboBox();
            label4 = new Label();
            SuspendLayout();
            // 
            // btnGuncelle
            // 
            btnGuncelle.BackColor = SystemColors.ActiveCaption;
            btnGuncelle.Location = new Point(196, 238);
            btnGuncelle.Name = "btnGuncelle";
            btnGuncelle.Size = new Size(77, 26);
            btnGuncelle.TabIndex = 7;
            btnGuncelle.Text = "Güncelle";
            btnGuncelle.UseVisualStyleBackColor = false;
            btnGuncelle.Click += btnGuncelle_Click;
            // 
            // btnKaydet
            // 
            btnKaydet.BackColor = SystemColors.ActiveCaption;
            btnKaydet.Location = new Point(102, 238);
            btnKaydet.Name = "btnKaydet";
            btnKaydet.Size = new Size(77, 26);
            btnKaydet.TabIndex = 6;
            btnKaydet.Text = "Kaydet";
            btnKaydet.UseVisualStyleBackColor = false;
            btnKaydet.Click += btnKaydet_Click;
            // 
            // lstListe
            // 
            lstListe.FormattingEnabled = true;
            lstListe.ItemHeight = 15;
            lstListe.Location = new Point(311, 51);
            lstListe.Name = "lstListe";
            lstListe.Size = new Size(130, 154);
            lstListe.TabIndex = 9;
            lstListe.SelectedIndexChanged += lstListe_SelectedIndexChanged;
            // 
            // txtAd
            // 
            txtAd.Location = new Point(102, 117);
            txtAd.Name = "txtAd";
            txtAd.Size = new Size(171, 23);
            txtAd.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(59, 69);
            label1.Name = "label1";
            label1.Size = new Size(0, 15);
            label1.TabIndex = 5;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label2.Location = new Point(12, 117);
            label2.Name = "label2";
            label2.Size = new Size(78, 17);
            label2.TabIndex = 5;
            label2.Text = "Model Adı :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label3.Location = new Point(35, 52);
            label3.Name = "label3";
            label3.Size = new Size(55, 17);
            label3.TabIndex = 5;
            label3.Text = "Marka :";
            // 
            // cmbMarka
            // 
            cmbMarka.FormattingEnabled = true;
            cmbMarka.Location = new Point(102, 51);
            cmbMarka.Name = "cmbMarka";
            cmbMarka.Size = new Size(171, 23);
            cmbMarka.TabIndex = 10;
            // 
            // cmbKasaTipi
            // 
            cmbKasaTipi.FormattingEnabled = true;
            cmbKasaTipi.Location = new Point(102, 181);
            cmbKasaTipi.Name = "cmbKasaTipi";
            cmbKasaTipi.Size = new Size(171, 23);
            cmbKasaTipi.TabIndex = 11;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label4.Location = new Point(16, 182);
            label4.Name = "label4";
            label4.Size = new Size(74, 17);
            label4.TabIndex = 12;
            label4.Text = "Kasa Tipi :";
            // 
            // ModelForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(453, 329);
            Controls.Add(label4);
            Controls.Add(cmbKasaTipi);
            Controls.Add(cmbMarka);
            Controls.Add(btnGuncelle);
            Controls.Add(btnKaydet);
            Controls.Add(lstListe);
            Controls.Add(txtAd);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "ModelForm";
            Text = "ModelForm";
            Load += ModelForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnGuncelle;
        private Button btnKaydet;
        private ListBox lstListe;
        private TextBox txtAd;
        private Label label1;
        private Label label2;
        private Label label3;
        private ComboBox cmbMarka;
        private ComboBox cmbKasaTipi;
        private Label label4;
    }
}