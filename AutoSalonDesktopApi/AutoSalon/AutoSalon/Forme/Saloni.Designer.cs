namespace AutoSalon.Forme
{
    partial class Saloni
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
            this.components = new System.ComponentModel.Container();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnBezFiltera = new System.Windows.Forms.Button();
            this.btnKombinovani = new System.Windows.Forms.Button();
            this.btnPolovni = new System.Windows.Forms.Button();
            this.btnNovi = new System.Windows.Forms.Button();
            this.Naziv = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Adresa = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Telefon = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Radno_vreme = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Broj_zaposlenih = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Proizvodjac = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.listViewSaloni = new System.Windows.Forms.ListView();
            this.Id = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnZaposleni = new System.Windows.Forms.Button();
            this.btnObrisiSalon = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip2 = new System.Windows.Forms.ToolTip(this.components);
            this.btnDodajSalon = new System.Windows.Forms.Button();
            this.btnAzurirajSalon = new System.Windows.Forms.Button();
            this.btnVozila = new System.Windows.Forms.Button();
            this.btnIzadji = new System.Windows.Forms.Button();
            this.btnKupci = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnBezFiltera);
            this.groupBox1.Controls.Add(this.btnKombinovani);
            this.groupBox1.Controls.Add(this.btnPolovni);
            this.groupBox1.Controls.Add(this.btnNovi);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(571, 33);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(160, 248);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filtriraj salone";
            // 
            // btnBezFiltera
            // 
            this.btnBezFiltera.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnBezFiltera.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnBezFiltera.Location = new System.Drawing.Point(16, 186);
            this.btnBezFiltera.Name = "btnBezFiltera";
            this.btnBezFiltera.Padding = new System.Windows.Forms.Padding(5, 0, 3, 0);
            this.btnBezFiltera.Size = new System.Drawing.Size(138, 47);
            this.btnBezFiltera.TabIndex = 3;
            this.btnBezFiltera.Text = "Osvezi";
            this.btnBezFiltera.UseVisualStyleBackColor = false;
            this.btnBezFiltera.Click += new System.EventHandler(this.btnBezFiltera_Click);
            // 
            // btnKombinovani
            // 
            this.btnKombinovani.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnKombinovani.Location = new System.Drawing.Point(16, 133);
            this.btnKombinovani.Name = "btnKombinovani";
            this.btnKombinovani.Size = new System.Drawing.Size(138, 47);
            this.btnKombinovani.TabIndex = 2;
            this.btnKombinovani.Text = "Kombinovani";
            this.btnKombinovani.UseVisualStyleBackColor = false;
            this.btnKombinovani.Click += new System.EventHandler(this.btnKombinovani_Click);
            // 
            // btnPolovni
            // 
            this.btnPolovni.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnPolovni.Location = new System.Drawing.Point(16, 80);
            this.btnPolovni.Name = "btnPolovni";
            this.btnPolovni.Size = new System.Drawing.Size(138, 47);
            this.btnPolovni.TabIndex = 1;
            this.btnPolovni.Text = "Polovni";
            this.btnPolovni.UseVisualStyleBackColor = false;
            this.btnPolovni.Click += new System.EventHandler(this.btnPolovni_Click);
            // 
            // btnNovi
            // 
            this.btnNovi.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnNovi.Location = new System.Drawing.Point(16, 27);
            this.btnNovi.Name = "btnNovi";
            this.btnNovi.Size = new System.Drawing.Size(138, 47);
            this.btnNovi.TabIndex = 0;
            this.btnNovi.Text = "Novi";
            this.btnNovi.UseVisualStyleBackColor = false;
            this.btnNovi.Click += new System.EventHandler(this.btnNovi_Click);
            // 
            // Naziv
            // 
            this.Naziv.Text = "Naziv";
            // 
            // Adresa
            // 
            this.Adresa.Text = "Adresa";
            this.Adresa.Width = 130;
            // 
            // Telefon
            // 
            this.Telefon.Text = "Telefon";
            this.Telefon.Width = 120;
            // 
            // Radno_vreme
            // 
            this.Radno_vreme.Text = "Radno_vreme";
            this.Radno_vreme.Width = 120;
            // 
            // Broj_zaposlenih
            // 
            this.Broj_zaposlenih.Text = "Broj_zaposlenih";
            this.Broj_zaposlenih.Width = 80;
            // 
            // Proizvodjac
            // 
            this.Proizvodjac.Text = "Proizvodjac";
            this.Proizvodjac.Width = 80;
            // 
            // listViewSaloni
            // 
            this.listViewSaloni.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Id,
            this.Naziv,
            this.Adresa,
            this.Telefon,
            this.Radno_vreme,
            this.Broj_zaposlenih,
            this.Proizvodjac});
            this.listViewSaloni.FullRowSelect = true;
            this.listViewSaloni.HideSelection = false;
            this.listViewSaloni.Location = new System.Drawing.Point(12, 33);
            this.listViewSaloni.Name = "listViewSaloni";
            this.listViewSaloni.Size = new System.Drawing.Size(553, 429);
            this.listViewSaloni.TabIndex = 0;
            this.listViewSaloni.UseCompatibleStateImageBehavior = false;
            this.listViewSaloni.View = System.Windows.Forms.View.Details;
            // 
            // Id
            // 
            this.Id.Text = "Id";
            this.Id.Width = 30;
            // 
            // btnZaposleni
            // 
            this.btnZaposleni.BackColor = System.Drawing.Color.Teal;
            this.btnZaposleni.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnZaposleni.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnZaposleni.Location = new System.Drawing.Point(571, 342);
            this.btnZaposleni.Name = "btnZaposleni";
            this.btnZaposleni.Size = new System.Drawing.Size(160, 57);
            this.btnZaposleni.TabIndex = 2;
            this.btnZaposleni.Text = "Zaposleni";
            this.toolTip1.SetToolTip(this.btnZaposleni, "Vidi zaposlene\r\n");
            this.btnZaposleni.UseVisualStyleBackColor = false;
            this.btnZaposleni.Click += new System.EventHandler(this.btnZaposleni_Click);
            // 
            // btnObrisiSalon
            // 
            this.btnObrisiSalon.BackColor = System.Drawing.Color.Teal;
            this.btnObrisiSalon.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnObrisiSalon.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnObrisiSalon.Location = new System.Drawing.Point(383, 483);
            this.btnObrisiSalon.Name = "btnObrisiSalon";
            this.btnObrisiSalon.Size = new System.Drawing.Size(160, 58);
            this.btnObrisiSalon.TabIndex = 3;
            this.btnObrisiSalon.Text = "Obrisi salon";
            this.btnObrisiSalon.UseVisualStyleBackColor = false;
            this.btnObrisiSalon.Click += new System.EventHandler(this.btnObrisiSalon_Click);
            // 
            // btnDodajSalon
            // 
            this.btnDodajSalon.BackColor = System.Drawing.Color.Teal;
            this.btnDodajSalon.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDodajSalon.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnDodajSalon.Location = new System.Drawing.Point(25, 484);
            this.btnDodajSalon.Name = "btnDodajSalon";
            this.btnDodajSalon.Size = new System.Drawing.Size(160, 57);
            this.btnDodajSalon.TabIndex = 4;
            this.btnDodajSalon.Text = "Dodaj salon";
            this.toolTip2.SetToolTip(this.btnDodajSalon, "Vidi vozila");
            this.btnDodajSalon.UseVisualStyleBackColor = false;
            this.btnDodajSalon.Click += new System.EventHandler(this.btnDodajSalon_Click);
            // 
            // btnAzurirajSalon
            // 
            this.btnAzurirajSalon.BackColor = System.Drawing.Color.Teal;
            this.btnAzurirajSalon.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAzurirajSalon.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnAzurirajSalon.Location = new System.Drawing.Point(202, 484);
            this.btnAzurirajSalon.Name = "btnAzurirajSalon";
            this.btnAzurirajSalon.Size = new System.Drawing.Size(160, 57);
            this.btnAzurirajSalon.TabIndex = 5;
            this.btnAzurirajSalon.Text = "Azuriraj salon";
            this.toolTip2.SetToolTip(this.btnAzurirajSalon, "Vidi vozila");
            this.btnAzurirajSalon.UseVisualStyleBackColor = false;
            this.btnAzurirajSalon.Click += new System.EventHandler(this.btnAzurirajSalon_Click);
            // 
            // btnVozila
            // 
            this.btnVozila.BackColor = System.Drawing.Color.Teal;
            this.btnVozila.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVozila.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnVozila.Location = new System.Drawing.Point(571, 405);
            this.btnVozila.Name = "btnVozila";
            this.btnVozila.Size = new System.Drawing.Size(160, 57);
            this.btnVozila.TabIndex = 6;
            this.btnVozila.Text = "Vozila";
            this.toolTip2.SetToolTip(this.btnVozila, "Vidi vozila");
            this.btnVozila.UseVisualStyleBackColor = false;
            this.btnVozila.Click += new System.EventHandler(this.btnVozila_Click);
            // 
            // btnIzadji
            // 
            this.btnIzadji.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnIzadji.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIzadji.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnIzadji.Location = new System.Drawing.Point(571, 483);
            this.btnIzadji.Name = "btnIzadji";
            this.btnIzadji.Size = new System.Drawing.Size(160, 58);
            this.btnIzadji.TabIndex = 7;
            this.btnIzadji.Text = "Izadji";
            this.btnIzadji.UseVisualStyleBackColor = false;
            this.btnIzadji.Click += new System.EventHandler(this.btnIzadji_Click);
            // 
            // btnKupci
            // 
            this.btnKupci.BackColor = System.Drawing.Color.Teal;
            this.btnKupci.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKupci.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnKupci.Location = new System.Drawing.Point(571, 279);
            this.btnKupci.Name = "btnKupci";
            this.btnKupci.Size = new System.Drawing.Size(160, 57);
            this.btnKupci.TabIndex = 8;
            this.btnKupci.Text = "Kupci";
            this.toolTip1.SetToolTip(this.btnKupci, "Vidi zaposlene\r\n");
            this.btnKupci.UseVisualStyleBackColor = false;
            this.btnKupci.Click += new System.EventHandler(this.btnKupci_Click);
            // 
            // Saloni
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(743, 553);
            this.Controls.Add(this.btnKupci);
            this.Controls.Add(this.btnIzadji);
            this.Controls.Add(this.btnVozila);
            this.Controls.Add(this.btnAzurirajSalon);
            this.Controls.Add(this.btnDodajSalon);
            this.Controls.Add(this.btnObrisiSalon);
            this.Controls.Add(this.btnZaposleni);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.listViewSaloni);
            this.Name = "Saloni";
            this.Text = "Saloni";
            this.Load += new System.EventHandler(this.Saloni_Load);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnKombinovani;
        private System.Windows.Forms.Button btnPolovni;
        private System.Windows.Forms.Button btnNovi;
        private System.Windows.Forms.ColumnHeader Naziv;
        private System.Windows.Forms.ColumnHeader Adresa;
        private System.Windows.Forms.ColumnHeader Telefon;
        private System.Windows.Forms.ColumnHeader Radno_vreme;
        private System.Windows.Forms.ColumnHeader Broj_zaposlenih;
        private System.Windows.Forms.ColumnHeader Proizvodjac;
        private System.Windows.Forms.ListView listViewSaloni;
        private System.Windows.Forms.Button btnZaposleni;
        private System.Windows.Forms.Button btnObrisiSalon;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.ToolTip toolTip2;
        private System.Windows.Forms.ColumnHeader Id;
        private System.Windows.Forms.Button btnDodajSalon;
        private System.Windows.Forms.Button btnAzurirajSalon;
        private System.Windows.Forms.Button btnVozila;
        private System.Windows.Forms.Button btnIzadji;
        private System.Windows.Forms.Button btnBezFiltera;
        private System.Windows.Forms.Button btnKupci;
    }
}