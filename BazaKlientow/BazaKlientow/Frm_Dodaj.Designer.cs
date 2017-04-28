namespace BazaKlientow
{
    partial class Frm_Dodaj
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Dodaj));
            this.label2 = new System.Windows.Forms.Label();
            this.txt_imie = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_nazwisko = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_marka = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_model = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cbo_silnik = new System.Windows.Forms.ComboBox();
            this.txt_pojemnosc = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txt_vin = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txt_symbol = new System.Windows.Forms.TextBox();
            this.txt_rok = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txt_uwagi = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.btn_dodaj = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Open Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(18, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Imię";
            // 
            // txt_imie
            // 
            this.txt_imie.Location = new System.Drawing.Point(89, 78);
            this.txt_imie.Name = "txt_imie";
            this.txt_imie.Size = new System.Drawing.Size(135, 20);
            this.txt_imie.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Open Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(18, 108);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 18);
            this.label3.TabIndex = 3;
            this.label3.Text = "Nazwisko";
            // 
            // txt_nazwisko
            // 
            this.txt_nazwisko.Location = new System.Drawing.Point(89, 108);
            this.txt_nazwisko.Name = "txt_nazwisko";
            this.txt_nazwisko.Size = new System.Drawing.Size(135, 20);
            this.txt_nazwisko.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("OpenSymbol", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(11, 153);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 19);
            this.label4.TabIndex = 5;
            this.label4.Text = "Samochód";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Open Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.Location = new System.Drawing.Point(12, 175);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 18);
            this.label5.TabIndex = 6;
            this.label5.Text = "Marka";
            // 
            // txt_marka
            // 
            this.txt_marka.Location = new System.Drawing.Point(89, 175);
            this.txt_marka.Name = "txt_marka";
            this.txt_marka.Size = new System.Drawing.Size(135, 20);
            this.txt_marka.TabIndex = 7;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Open Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label6.Location = new System.Drawing.Point(12, 201);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 18);
            this.label6.TabIndex = 8;
            this.label6.Text = "Model";
            // 
            // txt_model
            // 
            this.txt_model.Location = new System.Drawing.Point(89, 201);
            this.txt_model.Name = "txt_model";
            this.txt_model.Size = new System.Drawing.Size(135, 20);
            this.txt_model.TabIndex = 9;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Open Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label7.Location = new System.Drawing.Point(12, 227);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(75, 18);
            this.label7.TabIndex = 10;
            this.label7.Text = "Silnik (sym)";
            // 
            // cbo_silnik
            // 
            this.cbo_silnik.DisplayMember = "Diesel";
            this.cbo_silnik.FormattingEnabled = true;
            this.cbo_silnik.Items.AddRange(new object[] {
            "Diesel",
            "Benzyna"});
            this.cbo_silnik.Location = new System.Drawing.Point(89, 227);
            this.cbo_silnik.Name = "cbo_silnik";
            this.cbo_silnik.Size = new System.Drawing.Size(60, 21);
            this.cbo_silnik.TabIndex = 11;
            this.cbo_silnik.Text = "Diesel";
            // 
            // txt_pojemnosc
            // 
            this.txt_pojemnosc.Location = new System.Drawing.Point(89, 254);
            this.txt_pojemnosc.Name = "txt_pojemnosc";
            this.txt_pojemnosc.Size = new System.Drawing.Size(50, 20);
            this.txt_pojemnosc.TabIndex = 13;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Open Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label8.Location = new System.Drawing.Point(12, 254);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(74, 18);
            this.label8.TabIndex = 12;
            this.label8.Text = "Pojemność";
            // 
            // txt_vin
            // 
            this.txt_vin.Location = new System.Drawing.Point(89, 280);
            this.txt_vin.Name = "txt_vin";
            this.txt_vin.Size = new System.Drawing.Size(135, 20);
            this.txt_vin.TabIndex = 15;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Open Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label9.Location = new System.Drawing.Point(12, 280);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(30, 18);
            this.label9.TabIndex = 14;
            this.label9.Text = "VIN";
            // 
            // txt_symbol
            // 
            this.txt_symbol.Location = new System.Drawing.Point(155, 227);
            this.txt_symbol.Name = "txt_symbol";
            this.txt_symbol.Size = new System.Drawing.Size(59, 20);
            this.txt_symbol.TabIndex = 16;
            // 
            // txt_rok
            // 
            this.txt_rok.Location = new System.Drawing.Point(89, 306);
            this.txt_rok.Name = "txt_rok";
            this.txt_rok.Size = new System.Drawing.Size(60, 20);
            this.txt_rok.TabIndex = 18;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Open Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label10.Location = new System.Drawing.Point(12, 306);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(31, 18);
            this.label10.TabIndex = 17;
            this.label10.Text = "Rok";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("OpenSymbol", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(11, 56);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(50, 19);
            this.label11.TabIndex = 19;
            this.label11.Text = "Klient";
            // 
            // txt_uwagi
            // 
            this.txt_uwagi.Location = new System.Drawing.Point(89, 332);
            this.txt_uwagi.Multiline = true;
            this.txt_uwagi.Name = "txt_uwagi";
            this.txt_uwagi.Size = new System.Drawing.Size(374, 107);
            this.txt_uwagi.TabIndex = 21;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Open Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label12.Location = new System.Drawing.Point(12, 332);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(44, 18);
            this.label12.TabIndex = 20;
            this.label12.Text = "Uwagi";
            // 
            // btn_dodaj
            // 
            this.btn_dodaj.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btn_dodaj.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_dodaj.Font = new System.Drawing.Font("Open Sans", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btn_dodaj.Location = new System.Drawing.Point(15, 451);
            this.btn_dodaj.Name = "btn_dodaj";
            this.btn_dodaj.Size = new System.Drawing.Size(91, 28);
            this.btn_dodaj.TabIndex = 22;
            this.btn_dodaj.Text = "Dodaj";
            this.btn_dodaj.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Open Sans", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(97, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nowe dane";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Open Sans", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button1.Location = new System.Drawing.Point(0, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(43, 39);
            this.button1.TabIndex = 28;
            this.button1.Text = "<";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // Frm_Dodaj
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(501, 492);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btn_dodaj);
            this.Controls.Add(this.txt_uwagi);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txt_rok);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txt_symbol);
            this.Controls.Add(this.txt_vin);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txt_pojemnosc);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.cbo_silnik);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txt_model);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txt_marka);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_nazwisko);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_imie);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Frm_Dodaj";
            this.Text = "BazaKlientów - Dodaj klienta";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_imie;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_nazwisko;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_marka;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_model;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cbo_silnik;
        private System.Windows.Forms.TextBox txt_pojemnosc;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txt_vin;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txt_symbol;
        private System.Windows.Forms.TextBox txt_rok;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txt_uwagi;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button btn_dodaj;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
    }
}