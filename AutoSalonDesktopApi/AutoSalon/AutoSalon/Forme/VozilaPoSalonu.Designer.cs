namespace AutoSalon.Forme
{
    partial class VozilaPoSalonu
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
            this.btnDodaj = new System.Windows.Forms.Button();
            this.btnAzuriraj = new System.Windows.Forms.Button();
            this.btnObrisi = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnOsvezi = new System.Windows.Forms.Button();
            this.rbPolovna = new System.Windows.Forms.RadioButton();
            this.rbNova = new System.Windows.Forms.RadioButton();
            this.lvVozila = new System.Windows.Forms.ListView();
            this.chBrSasije = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chMarka = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chModel = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chGodProizvodnje = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chSnagaMotora = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chKilometraza = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chBrVrata = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chBoja = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chTipGoriva = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chDatumPoslReg = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chServisnaIst = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chBrPrethVlasnika = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chTip = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnIzadji = new System.Windows.Forms.Button();
            this.btnTestiraj = new System.Windows.Forms.Button();
            this.btnKupi = new System.Windows.Forms.Button();
            this.chCena = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnDodaj
            // 
            this.btnDodaj.Location = new System.Drawing.Point(524, 342);
            this.btnDodaj.Name = "btnDodaj";
            this.btnDodaj.Size = new System.Drawing.Size(140, 37);
            this.btnDodaj.TabIndex = 9;
            this.btnDodaj.Text = "Dodaj vozilo";
            this.btnDodaj.UseVisualStyleBackColor = true;
            this.btnDodaj.Click += new System.EventHandler(this.btnDodaj_Click);
            // 
            // btnAzuriraj
            // 
            this.btnAzuriraj.Location = new System.Drawing.Point(378, 342);
            this.btnAzuriraj.Name = "btnAzuriraj";
            this.btnAzuriraj.Size = new System.Drawing.Size(140, 37);
            this.btnAzuriraj.TabIndex = 8;
            this.btnAzuriraj.Text = "Azuriraj vozilo";
            this.btnAzuriraj.UseVisualStyleBackColor = true;
            this.btnAzuriraj.Click += new System.EventHandler(this.btnAzuriraj_Click);
            // 
            // btnObrisi
            // 
            this.btnObrisi.Location = new System.Drawing.Point(232, 342);
            this.btnObrisi.Name = "btnObrisi";
            this.btnObrisi.Size = new System.Drawing.Size(140, 37);
            this.btnObrisi.TabIndex = 7;
            this.btnObrisi.Text = "Obrisi vozilo";
            this.btnObrisi.UseVisualStyleBackColor = true;
            this.btnObrisi.Click += new System.EventHandler(this.btnObrisi_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnOsvezi);
            this.groupBox1.Controls.Add(this.rbPolovna);
            this.groupBox1.Controls.Add(this.rbNova);
            this.groupBox1.Location = new System.Drawing.Point(12, 320);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 118);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Vozila:";
            // 
            // btnOsvezi
            // 
            this.btnOsvezi.Location = new System.Drawing.Point(7, 74);
            this.btnOsvezi.Name = "btnOsvezi";
            this.btnOsvezi.Size = new System.Drawing.Size(103, 34);
            this.btnOsvezi.TabIndex = 3;
            this.btnOsvezi.Text = "Osvezi";
            this.btnOsvezi.UseVisualStyleBackColor = true;
            this.btnOsvezi.Click += new System.EventHandler(this.btnOsvezi_Click);
            // 
            // rbPolovna
            // 
            this.rbPolovna.AutoSize = true;
            this.rbPolovna.Location = new System.Drawing.Point(7, 48);
            this.rbPolovna.Name = "rbPolovna";
            this.rbPolovna.Size = new System.Drawing.Size(116, 20);
            this.rbPolovna.TabIndex = 1;
            this.rbPolovna.TabStop = true;
            this.rbPolovna.Text = "Polovna vozila";
            this.rbPolovna.UseVisualStyleBackColor = true;
            this.rbPolovna.CheckedChanged += new System.EventHandler(this.rbPolovna_CheckedChanged);
            // 
            // rbNova
            // 
            this.rbNova.AutoSize = true;
            this.rbNova.Location = new System.Drawing.Point(7, 22);
            this.rbNova.Name = "rbNova";
            this.rbNova.Size = new System.Drawing.Size(99, 20);
            this.rbNova.TabIndex = 0;
            this.rbNova.TabStop = true;
            this.rbNova.Text = "Nova vozila";
            this.rbNova.UseVisualStyleBackColor = true;
            this.rbNova.CheckedChanged += new System.EventHandler(this.rbNova_CheckedChanged);
            // 
            // lvVozila
            // 
            this.lvVozila.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chBrSasije,
            this.chMarka,
            this.chModel,
            this.chGodProizvodnje,
            this.chSnagaMotora,
            this.chKilometraza,
            this.chBrVrata,
            this.chBoja,
            this.chTipGoriva,
            this.chDatumPoslReg,
            this.chServisnaIst,
            this.chBrPrethVlasnika,
            this.chTip,
            this.chCena});
            this.lvVozila.FullRowSelect = true;
            this.lvVozila.HideSelection = false;
            this.lvVozila.Location = new System.Drawing.Point(12, 12);
            this.lvVozila.Name = "lvVozila";
            this.lvVozila.Size = new System.Drawing.Size(776, 302);
            this.lvVozila.TabIndex = 5;
            this.lvVozila.UseCompatibleStateImageBehavior = false;
            this.lvVozila.View = System.Windows.Forms.View.Details;
            this.lvVozila.SelectedIndexChanged += new System.EventHandler(this.lvVozila_SelectedIndexChanged);
            // 
            // chBrSasije
            // 
            this.chBrSasije.Text = "Broj sasije";
            // 
            // chMarka
            // 
            this.chMarka.Text = "Marka";
            // 
            // chModel
            // 
            this.chModel.Text = "Model";
            // 
            // chGodProizvodnje
            // 
            this.chGodProizvodnje.Text = "God. proizvodnje";
            // 
            // chSnagaMotora
            // 
            this.chSnagaMotora.Text = "Snaga motora";
            // 
            // chKilometraza
            // 
            this.chKilometraza.Text = "Kilometraza";
            // 
            // chBrVrata
            // 
            this.chBrVrata.Text = "Broj vrata";
            // 
            // chBoja
            // 
            this.chBoja.Text = "Boja";
            // 
            // chTipGoriva
            // 
            this.chTipGoriva.Text = "Tip goriva";
            // 
            // chDatumPoslReg
            // 
            this.chDatumPoslReg.Text = "Datum poslednje reg";
            // 
            // chServisnaIst
            // 
            this.chServisnaIst.Text = "Servisna istorija";
            // 
            // chBrPrethVlasnika
            // 
            this.chBrPrethVlasnika.Text = "Br. preth. vlasnika";
            // 
            // chTip
            // 
            this.chTip.Text = "Tip";
            // 
            // btnIzadji
            // 
            this.btnIzadji.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnIzadji.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnIzadji.Location = new System.Drawing.Point(524, 382);
            this.btnIzadji.Name = "btnIzadji";
            this.btnIzadji.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnIzadji.Size = new System.Drawing.Size(140, 37);
            this.btnIzadji.TabIndex = 10;
            this.btnIzadji.Text = "Izadji";
            this.btnIzadji.UseVisualStyleBackColor = false;
            this.btnIzadji.Click += new System.EventHandler(this.btnIzadji_Click);
            // 
            // btnTestiraj
            // 
            this.btnTestiraj.Location = new System.Drawing.Point(232, 385);
            this.btnTestiraj.Name = "btnTestiraj";
            this.btnTestiraj.Size = new System.Drawing.Size(140, 34);
            this.btnTestiraj.TabIndex = 11;
            this.btnTestiraj.Text = "Testiraj";
            this.btnTestiraj.UseVisualStyleBackColor = true;
            this.btnTestiraj.Click += new System.EventHandler(this.btnTestiraj_Click);
            // 
            // btnKupi
            // 
            this.btnKupi.Location = new System.Drawing.Point(378, 385);
            this.btnKupi.Name = "btnKupi";
            this.btnKupi.Size = new System.Drawing.Size(140, 34);
            this.btnKupi.TabIndex = 12;
            this.btnKupi.Text = "Kupi";
            this.btnKupi.UseVisualStyleBackColor = true;
            this.btnKupi.Click += new System.EventHandler(this.btnKupi_Click);
            // 
            // chCena
            // 
            this.chCena.Text = "Cena";
            // 
            // VozilaPoSalonu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnKupi);
            this.Controls.Add(this.btnTestiraj);
            this.Controls.Add(this.btnIzadji);
            this.Controls.Add(this.btnDodaj);
            this.Controls.Add(this.btnAzuriraj);
            this.Controls.Add(this.btnObrisi);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lvVozila);
            this.Name = "VozilaPoSalonu";
            this.Text = "Vozila";
            this.Load += new System.EventHandler(this.VozilaPoSalonu_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnDodaj;
        private System.Windows.Forms.Button btnAzuriraj;
        private System.Windows.Forms.Button btnObrisi;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbPolovna;
        private System.Windows.Forms.RadioButton rbNova;
        private System.Windows.Forms.ListView lvVozila;
        private System.Windows.Forms.ColumnHeader chBrSasije;
        private System.Windows.Forms.ColumnHeader chMarka;
        private System.Windows.Forms.ColumnHeader chModel;
        private System.Windows.Forms.ColumnHeader chGodProizvodnje;
        private System.Windows.Forms.ColumnHeader chSnagaMotora;
        private System.Windows.Forms.ColumnHeader chKilometraza;
        private System.Windows.Forms.ColumnHeader chBrVrata;
        private System.Windows.Forms.ColumnHeader chBoja;
        private System.Windows.Forms.ColumnHeader chTipGoriva;
        private System.Windows.Forms.ColumnHeader chDatumPoslReg;
        private System.Windows.Forms.ColumnHeader chServisnaIst;
        private System.Windows.Forms.ColumnHeader chBrPrethVlasnika;
        private System.Windows.Forms.ColumnHeader chTip;
        private System.Windows.Forms.Button btnIzadji;
        private System.Windows.Forms.Button btnOsvezi;
        private System.Windows.Forms.Button btnTestiraj;
        private System.Windows.Forms.Button btnKupi;
        private System.Windows.Forms.ColumnHeader chCena;
    }
}