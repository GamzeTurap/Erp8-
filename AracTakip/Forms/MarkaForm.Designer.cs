namespace AracTakip.Forms
{
    partial class MarkaForm
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
            label1 = new Label();
            txtAd = new TextBox();
            pbResim = new PictureBox();
            lstListe = new ListBox();
            btnKaydet = new Button();
            btnGuncelle = new Button();
            ((System.ComponentModel.ISupportInitialize)pbResim).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label1.Location = new Point(12, 19);
            label1.Name = "label1";
            label1.Size = new Size(80, 17);
            label1.TabIndex = 0;
            label1.Text = "Marka Adı :";
            // 
            // txtAd
            // 
            txtAd.Location = new Point(98, 19);
            txtAd.Name = "txtAd";
            txtAd.Size = new Size(152, 23);
            txtAd.TabIndex = 0;
            // 
            // pbResim
            // 
            pbResim.BorderStyle = BorderStyle.Fixed3D;
            pbResim.Location = new Point(98, 58);
            pbResim.Name = "pbResim";
            pbResim.Size = new Size(152, 85);
            pbResim.SizeMode = PictureBoxSizeMode.StretchImage;
            pbResim.TabIndex = 2;
            pbResim.TabStop = false;
            pbResim.Click += pbResim_Click;
            // 
            // lstListe
            // 
            lstListe.FormattingEnabled = true;
            lstListe.ItemHeight = 15;
            lstListe.Location = new Point(270, 19);
            lstListe.Name = "lstListe";
            lstListe.Size = new Size(107, 124);
            lstListe.TabIndex = 3;
            lstListe.SelectedIndexChanged += lstListe_SelectedIndexChanged;
            // 
            // btnKaydet
            // 
            btnKaydet.BackColor = SystemColors.ActiveCaption;
            btnKaydet.Location = new Point(98, 162);
            btnKaydet.Name = "btnKaydet";
            btnKaydet.Size = new Size(77, 26);
            btnKaydet.TabIndex = 1;
            btnKaydet.Text = "Kaydet";
            btnKaydet.UseVisualStyleBackColor = false;
            btnKaydet.Click += btnKaydet_Click;
            // 
            // btnGuncelle
            // 
            btnGuncelle.BackColor = SystemColors.ActiveCaption;
            btnGuncelle.Location = new Point(181, 162);
            btnGuncelle.Name = "btnGuncelle";
            btnGuncelle.Size = new Size(77, 26);
            btnGuncelle.TabIndex = 2;
            btnGuncelle.Text = "Güncelle";
            btnGuncelle.UseVisualStyleBackColor = false;
            btnGuncelle.Click += btnGuncelle_Click;
            // 
            // MarkaForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(417, 208);
            Controls.Add(btnGuncelle);
            Controls.Add(btnKaydet);
            Controls.Add(lstListe);
            Controls.Add(pbResim);
            Controls.Add(txtAd);
            Controls.Add(label1);
            Name = "MarkaForm";
            Text = "MarkaForm";
            Load += MarkaForm_Load;
            ((System.ComponentModel.ISupportInitialize)pbResim).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtAd;
        private PictureBox pbResim;
        private ListBox lstListe;
        private Button btnKaydet;
        private Button btnGuncelle;
    }
}