namespace BazaKlientow
{
    partial class Frm_Przegladaj
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Przegladaj));
            this.label1 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.pct_szukaj = new System.Windows.Forms.PictureBox();
            this.txt_szukaj = new System.Windows.Forms.TextBox();
            this.txt_imie_nazwisko = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_dane_samochod = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pct_szukaj)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Open Sans", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(10, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(166, 26);
            this.label1.TabIndex = 1;
            this.label1.Text = "Przegląd danych";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("OpenSymbol", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(12, 97);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(50, 19);
            this.label11.TabIndex = 20;
            this.label11.Text = "Klient";
            // 
            // pct_szukaj
            // 
            this.pct_szukaj.Image = global::BazaKlientow.Properties.Resources.lupa;
            this.pct_szukaj.Location = new System.Drawing.Point(182, 40);
            this.pct_szukaj.Name = "pct_szukaj";
            this.pct_szukaj.Size = new System.Drawing.Size(47, 24);
            this.pct_szukaj.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pct_szukaj.TabIndex = 21;
            this.pct_szukaj.TabStop = false;
            // 
            // txt_szukaj
            // 
            this.txt_szukaj.Location = new System.Drawing.Point(16, 44);
            this.txt_szukaj.Name = "txt_szukaj";
            this.txt_szukaj.Size = new System.Drawing.Size(160, 20);
            this.txt_szukaj.TabIndex = 22;
            // 
            // txt_imie_nazwisko
            // 
            this.txt_imie_nazwisko.Location = new System.Drawing.Point(16, 120);
            this.txt_imie_nazwisko.Name = "txt_imie_nazwisko";
            this.txt_imie_nazwisko.ReadOnly = true;
            this.txt_imie_nazwisko.Size = new System.Drawing.Size(213, 20);
            this.txt_imie_nazwisko.TabIndex = 23;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("OpenSymbol", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 163);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 19);
            this.label2.TabIndex = 24;
            this.label2.Text = "Samochód";
            // 
            // txt_dane_samochod
            // 
            this.txt_dane_samochod.Location = new System.Drawing.Point(16, 185);
            this.txt_dane_samochod.Name = "txt_dane_samochod";
            this.txt_dane_samochod.ReadOnly = true;
            this.txt_dane_samochod.Size = new System.Drawing.Size(496, 20);
            this.txt_dane_samochod.TabIndex = 25;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(235, 45);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(143, 13);
            this.label3.TabIndex = 26;
            this.label3.Text = "(szukaj po imię lub nazwisko)";
            // 
            // Frm_Przegladaj
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(524, 358);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_dane_samochod);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_imie_nazwisko);
            this.Controls.Add(this.txt_szukaj);
            this.Controls.Add(this.pct_szukaj);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Frm_Przegladaj";
            this.Text = "BazaKlient - Przegląd danych";
            ((System.ComponentModel.ISupportInitialize)(this.pct_szukaj)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.PictureBox pct_szukaj;
        private System.Windows.Forms.TextBox txt_szukaj;
        private System.Windows.Forms.TextBox txt_imie_nazwisko;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_dane_samochod;
        private System.Windows.Forms.Label label3;
    }
}