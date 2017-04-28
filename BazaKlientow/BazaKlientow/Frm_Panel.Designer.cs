namespace BazaKlientow
{
    partial class Frm_Panel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Panel));
            this.btn_przegladaj = new System.Windows.Forms.Button();
            this.btn_dodaj = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_przegladaj
            // 
            this.btn_przegladaj.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btn_przegladaj.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_przegladaj.Font = new System.Drawing.Font("Open Sans", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btn_przegladaj.Location = new System.Drawing.Point(55, 90);
            this.btn_przegladaj.Name = "btn_przegladaj";
            this.btn_przegladaj.Size = new System.Drawing.Size(308, 267);
            this.btn_przegladaj.TabIndex = 0;
            this.btn_przegladaj.Text = "Przeglądaj";
            this.btn_przegladaj.UseVisualStyleBackColor = false;
            // 
            // btn_dodaj
            // 
            this.btn_dodaj.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btn_dodaj.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_dodaj.Font = new System.Drawing.Font("Open Sans", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btn_dodaj.Location = new System.Drawing.Point(397, 90);
            this.btn_dodaj.Name = "btn_dodaj";
            this.btn_dodaj.Size = new System.Drawing.Size(308, 267);
            this.btn_dodaj.TabIndex = 2;
            this.btn_dodaj.Text = "Dodaj";
            this.btn_dodaj.UseVisualStyleBackColor = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.pictureBox2.Image = global::BazaKlientow.Properties.Resources.plus;
            this.pictureBox2.Location = new System.Drawing.Point(458, 197);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(64, 54);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.pictureBox1.Image = global::BazaKlientow.Properties.Resources.lupa;
            this.pictureBox1.Location = new System.Drawing.Point(95, 197);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(64, 54);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // Frm_Panel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(763, 461);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.btn_dodaj);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btn_przegladaj);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Frm_Panel";
            this.Text = "BazaKlienta - Panel";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_przegladaj;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btn_dodaj;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}