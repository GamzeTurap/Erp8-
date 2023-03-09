namespace AracTakip.Forms
{
    partial class AracForm
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
            cmbMarka = new ComboBox();
            cmbModel = new ComboBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            btnKaydet = new Button();
            btnGüncelle = new Button();
            lstListe = new ListBox();
            txtPlaka = new TextBox();
            SuspendLayout();
            // 
            // cmbMarka
            // 
            cmbMarka.FormattingEnabled = true;
            cmbMarka.Location = new Point(94, 33);
            cmbMarka.Name = "cmbMarka";
            cmbMarka.Size = new Size(121, 23);
            cmbMarka.TabIndex = 0;
            cmbMarka.SelectedIndexChanged += cmbMarka_SelectedIndexChanged;
            // 
            // cmbModel
            // 
            cmbModel.FormattingEnabled = true;
            cmbModel.Location = new Point(94, 76);
            cmbModel.Name = "cmbModel";
            cmbModel.Size = new Size(121, 23);
            cmbModel.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label1.Location = new Point(19, 34);
            label1.Name = "label1";
            label1.Size = new Size(55, 17);
            label1.TabIndex = 2;
            label1.Text = "Marka :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label2.Location = new Point(21, 74);
            label2.Name = "label2";
            label2.Size = new Size(53, 17);
            label2.TabIndex = 3;
            label2.Text = "Model :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label3.Location = new Point(23, 114);
            label3.Name = "label3";
            label3.Size = new Size(51, 17);
            label3.TabIndex = 3;
            label3.Text = "Plaka :";
            // 
            // btnKaydet
            // 
            btnKaydet.BackColor = SystemColors.ActiveCaption;
            btnKaydet.Location = new Point(59, 160);
            btnKaydet.Name = "btnKaydet";
            btnKaydet.Size = new Size(75, 23);
            btnKaydet.TabIndex = 4;
            btnKaydet.Text = "Kaydet";
            btnKaydet.UseVisualStyleBackColor = false;
            btnKaydet.Click += btnKaydet_Click;
            // 
            // btnGüncelle
            // 
            btnGüncelle.BackColor = SystemColors.ActiveCaption;
            btnGüncelle.Location = new Point(153, 160);
            btnGüncelle.Name = "btnGüncelle";
            btnGüncelle.Size = new Size(75, 23);
            btnGüncelle.TabIndex = 5;
            btnGüncelle.Text = "Güncelle";
            btnGüncelle.UseVisualStyleBackColor = false;
            btnGüncelle.Click += btnGüncelle_Click;
            // 
            // lstListe
            // 
            lstListe.FormattingEnabled = true;
            lstListe.ItemHeight = 15;
            lstListe.Location = new Point(247, 28);
            lstListe.Name = "lstListe";
            lstListe.Size = new Size(120, 109);
            lstListe.TabIndex = 6;
            lstListe.SelectedIndexChanged += lstListe_SelectedIndexChanged;
            // 
            // txtPlaka
            // 
            txtPlaka.Location = new Point(94, 114);
            txtPlaka.Name = "txtPlaka";
            txtPlaka.Size = new Size(121, 23);
            txtPlaka.TabIndex = 7;
            // 
            // AracForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(394, 231);
            Controls.Add(txtPlaka);
            Controls.Add(lstListe);
            Controls.Add(btnGüncelle);
            Controls.Add(btnKaydet);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(cmbModel);
            Controls.Add(cmbMarka);
            Name = "AracForm";
            Text = "AracForm";
            Load += AracForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cmbMarka;
        private ComboBox cmbModel;
        private Label label1;
        private Label label2;
        private Label label3;
        private Button btnKaydet;
        private Button btnGüncelle;
        private ListBox lstListe;
        private TextBox txtPlaka;
    }
}