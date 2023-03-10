namespace CafeBaGY
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnBahce = new Button();
            btnSalon = new Button();
            btnTeras = new Button();
            SuspendLayout();
            // 
            // btnBahce
            // 
            btnBahce.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            btnBahce.Location = new Point(92, 298);
            btnBahce.Name = "btnBahce";
            btnBahce.Size = new Size(112, 33);
            btnBahce.TabIndex = 2;
            btnBahce.Text = "BAHÇE";
            btnBahce.UseVisualStyleBackColor = true;
            // 
            // btnSalon
            // 
            btnSalon.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            btnSalon.Location = new Point(395, 217);
            btnSalon.Name = "btnSalon";
            btnSalon.Size = new Size(112, 33);
            btnSalon.TabIndex = 2;
            btnSalon.Text = "SALON";
            btnSalon.UseVisualStyleBackColor = true;
            // 
            // btnTeras
            // 
            btnTeras.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            btnTeras.Location = new Point(259, 94);
            btnTeras.Name = "btnTeras";
            btnTeras.Size = new Size(112, 33);
            btnTeras.TabIndex = 2;
            btnTeras.Text = "TERAS";
            btnTeras.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Adsız;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(627, 383);
            Controls.Add(btnTeras);
            Controls.Add(btnSalon);
            Controls.Add(btnBahce);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion
        private Button btnBahce;
        private Button btnSalon;
        private Button btnTeras;
    }
}