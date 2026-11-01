namespace AutoSalon.Forme
{
    partial class KupciPoSalonu
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
            this.btnIzadji = new System.Windows.Forms.Button();
            this.listViewKupci = new System.Windows.Forms.ListView();
            this.chTip = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chIme = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chPrezime = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chNaziv = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chAdresa = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chMarka = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chModel = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // btnIzadji
            // 
            this.btnIzadji.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnIzadji.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnIzadji.Location = new System.Drawing.Point(308, 391);
            this.btnIzadji.Name = "btnIzadji";
            this.btnIzadji.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnIzadji.Size = new System.Drawing.Size(140, 37);
            this.btnIzadji.TabIndex = 13;
            this.btnIzadji.Text = "Izadji";
            this.btnIzadji.UseVisualStyleBackColor = false;
            this.btnIzadji.Click += new System.EventHandler(this.btnIzadji_Click);
            // 
            // listViewKupci
            // 
            this.listViewKupci.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chTip,
            this.chIme,
            this.chPrezime,
            this.chNaziv,
            this.chAdresa,
            this.chMarka,
            this.chModel});
            this.listViewKupci.HideSelection = false;
            this.listViewKupci.Location = new System.Drawing.Point(12, 22);
            this.listViewKupci.Name = "listViewKupci";
            this.listViewKupci.Size = new System.Drawing.Size(776, 336);
            this.listViewKupci.TabIndex = 12;
            this.listViewKupci.UseCompatibleStateImageBehavior = false;
            this.listViewKupci.View = System.Windows.Forms.View.Details;
            // 
            // chTip
            // 
            this.chTip.Text = "Tip kupca";
            // 
            // chIme
            // 
            this.chIme.Text = "Ime";
            // 
            // chPrezime
            // 
            this.chPrezime.Text = "Prezime";
            // 
            // chNaziv
            // 
            this.chNaziv.Text = "Naziv firme";
            // 
            // chAdresa
            // 
            this.chAdresa.Text = "Adresa";
            // 
            // chMarka
            // 
            this.chMarka.Text = "Marka vozila";
            // 
            // chModel
            // 
            this.chModel.Text = "Model vozila";
            // 
            // KupciPoSalonu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnIzadji);
            this.Controls.Add(this.listViewKupci);
            this.Name = "KupciPoSalonu";
            this.Text = "KupciPoSalonu";
            this.Load += new System.EventHandler(this.KupciPoSalonu_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnIzadji;
        private System.Windows.Forms.ListView listViewKupci;
        private System.Windows.Forms.ColumnHeader chTip;
        private System.Windows.Forms.ColumnHeader chIme;
        private System.Windows.Forms.ColumnHeader chPrezime;
        private System.Windows.Forms.ColumnHeader chNaziv;
        private System.Windows.Forms.ColumnHeader chAdresa;
        private System.Windows.Forms.ColumnHeader chMarka;
        private System.Windows.Forms.ColumnHeader chModel;
    }
}