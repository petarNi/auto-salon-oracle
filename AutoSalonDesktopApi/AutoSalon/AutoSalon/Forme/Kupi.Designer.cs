namespace AutoSalon.Forme
{
    partial class Kupi
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
            this.rbPravno = new System.Windows.Forms.RadioButton();
            this.rbFizicko = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtIme = new System.Windows.Forms.TextBox();
            this.txtPrezime = new System.Windows.Forms.TextBox();
            this.txtAdresa = new System.Windows.Forms.TextBox();
            this.txtJMBG = new System.Windows.Forms.TextBox();
            this.txtTelefonFiz = new System.Windows.Forms.TextBox();
            this.txtEmailFiz = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.gbFizicko = new System.Windows.Forms.GroupBox();
            this.txtEmailpravno = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txtKontakt = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtSediste = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtNaziv = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtPIB = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtTelPravno = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.gbPravno = new System.Windows.Forms.GroupBox();
            this.btnKupi = new System.Windows.Forms.Button();
            this.label14 = new System.Windows.Forms.Label();
            this.cmbPromocije = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rbGotovina = new System.Windows.Forms.RadioButton();
            this.rbKredit = new System.Windows.Forms.RadioButton();
            this.rbLeasing = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            this.gbFizicko.SuspendLayout();
            this.gbPravno.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // rbPravno
            // 
            this.rbPravno.AutoSize = true;
            this.rbPravno.Location = new System.Drawing.Point(16, 39);
            this.rbPravno.Name = "rbPravno";
            this.rbPravno.Size = new System.Drawing.Size(120, 26);
            this.rbPravno.TabIndex = 0;
            this.rbPravno.TabStop = true;
            this.rbPravno.Text = "Pravno lice";
            this.rbPravno.UseVisualStyleBackColor = true;
            this.rbPravno.CheckedChanged += new System.EventHandler(this.rbPravno_CheckedChanged);
            // 
            // rbFizicko
            // 
            this.rbFizicko.AutoSize = true;
            this.rbFizicko.Location = new System.Drawing.Point(16, 81);
            this.rbFizicko.Name = "rbFizicko";
            this.rbFizicko.Size = new System.Drawing.Size(118, 26);
            this.rbFizicko.TabIndex = 1;
            this.rbFizicko.TabStop = true;
            this.rbFizicko.Text = "Fizicko lice";
            this.rbFizicko.UseVisualStyleBackColor = true;
            this.rbFizicko.CheckedChanged += new System.EventHandler(this.rbFizicko_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbFizicko);
            this.groupBox1.Controls.Add(this.rbPravno);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(51, 31);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(189, 124);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ja sam";
            // 
            // txtIme
            // 
            this.txtIme.Location = new System.Drawing.Point(38, 51);
            this.txtIme.Name = "txtIme";
            this.txtIme.Size = new System.Drawing.Size(100, 22);
            this.txtIme.TabIndex = 0;
            // 
            // txtPrezime
            // 
            this.txtPrezime.Location = new System.Drawing.Point(38, 97);
            this.txtPrezime.Name = "txtPrezime";
            this.txtPrezime.Size = new System.Drawing.Size(100, 22);
            this.txtPrezime.TabIndex = 1;
            // 
            // txtAdresa
            // 
            this.txtAdresa.Location = new System.Drawing.Point(38, 144);
            this.txtAdresa.Name = "txtAdresa";
            this.txtAdresa.Size = new System.Drawing.Size(100, 22);
            this.txtAdresa.TabIndex = 2;
            // 
            // txtJMBG
            // 
            this.txtJMBG.Location = new System.Drawing.Point(168, 51);
            this.txtJMBG.Name = "txtJMBG";
            this.txtJMBG.Size = new System.Drawing.Size(100, 22);
            this.txtJMBG.TabIndex = 3;
            // 
            // txtTelefonFiz
            // 
            this.txtTelefonFiz.Location = new System.Drawing.Point(168, 97);
            this.txtTelefonFiz.Name = "txtTelefonFiz";
            this.txtTelefonFiz.Size = new System.Drawing.Size(100, 22);
            this.txtTelefonFiz.TabIndex = 4;
            // 
            // txtEmailFiz
            // 
            this.txtEmailFiz.Location = new System.Drawing.Point(168, 144);
            this.txtEmailFiz.Name = "txtEmailFiz";
            this.txtEmailFiz.Size = new System.Drawing.Size(100, 22);
            this.txtEmailFiz.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(38, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 16);
            this.label2.TabIndex = 6;
            this.label2.Text = "Ime";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(165, 76);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 16);
            this.label3.TabIndex = 7;
            this.label3.Text = "Telefon";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(165, 29);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 16);
            this.label4.TabIndex = 8;
            this.label4.Text = "JMBG";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(38, 125);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 16);
            this.label5.TabIndex = 9;
            this.label5.Text = "Adresa";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(38, 76);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 16);
            this.label6.TabIndex = 10;
            this.label6.Text = "Prezime";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(165, 122);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(41, 16);
            this.label7.TabIndex = 11;
            this.label7.Text = "Email";
            // 
            // gbFizicko
            // 
            this.gbFizicko.Controls.Add(this.label7);
            this.gbFizicko.Controls.Add(this.label6);
            this.gbFizicko.Controls.Add(this.label5);
            this.gbFizicko.Controls.Add(this.label4);
            this.gbFizicko.Controls.Add(this.label3);
            this.gbFizicko.Controls.Add(this.label2);
            this.gbFizicko.Controls.Add(this.txtEmailFiz);
            this.gbFizicko.Controls.Add(this.txtTelefonFiz);
            this.gbFizicko.Controls.Add(this.txtJMBG);
            this.gbFizicko.Controls.Add(this.txtAdresa);
            this.gbFizicko.Controls.Add(this.txtPrezime);
            this.gbFizicko.Controls.Add(this.txtIme);
            this.gbFizicko.Location = new System.Drawing.Point(312, 19);
            this.gbFizicko.Name = "gbFizicko";
            this.gbFizicko.Size = new System.Drawing.Size(441, 186);
            this.gbFizicko.TabIndex = 19;
            this.gbFizicko.TabStop = false;
            this.gbFizicko.Text = "Fizicko";
            // 
            // txtEmailpravno
            // 
            this.txtEmailpravno.Location = new System.Drawing.Point(168, 158);
            this.txtEmailpravno.Name = "txtEmailpravno";
            this.txtEmailpravno.Size = new System.Drawing.Size(100, 22);
            this.txtEmailpravno.TabIndex = 17;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(38, 43);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(28, 16);
            this.label13.TabIndex = 18;
            this.label13.Text = "PIB";
            // 
            // txtKontakt
            // 
            this.txtKontakt.Location = new System.Drawing.Point(168, 65);
            this.txtKontakt.Name = "txtKontakt";
            this.txtKontakt.Size = new System.Drawing.Size(100, 22);
            this.txtKontakt.TabIndex = 15;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(165, 90);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(53, 16);
            this.label12.TabIndex = 19;
            this.label12.Text = "Telefon";
            // 
            // txtSediste
            // 
            this.txtSediste.Location = new System.Drawing.Point(38, 158);
            this.txtSediste.Name = "txtSediste";
            this.txtSediste.Size = new System.Drawing.Size(100, 22);
            this.txtSediste.TabIndex = 14;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(165, 43);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(93, 16);
            this.label11.TabIndex = 20;
            this.label11.Text = "Kontakt osoba";
            // 
            // txtNaziv
            // 
            this.txtNaziv.Location = new System.Drawing.Point(38, 111);
            this.txtNaziv.Name = "txtNaziv";
            this.txtNaziv.Size = new System.Drawing.Size(100, 22);
            this.txtNaziv.TabIndex = 13;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(38, 139);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(85, 16);
            this.label10.TabIndex = 21;
            this.label10.Text = "Sediste firme";
            // 
            // txtPIB
            // 
            this.txtPIB.Location = new System.Drawing.Point(38, 65);
            this.txtPIB.Name = "txtPIB";
            this.txtPIB.Size = new System.Drawing.Size(100, 22);
            this.txtPIB.TabIndex = 12;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(38, 90);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(73, 16);
            this.label9.TabIndex = 22;
            this.label9.Text = "Naziv firme";
            // 
            // txtTelPravno
            // 
            this.txtTelPravno.Location = new System.Drawing.Point(168, 111);
            this.txtTelPravno.Name = "txtTelPravno";
            this.txtTelPravno.Size = new System.Drawing.Size(100, 22);
            this.txtTelPravno.TabIndex = 16;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(165, 136);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(41, 16);
            this.label8.TabIndex = 23;
            this.label8.Text = "Email";
            // 
            // gbPravno
            // 
            this.gbPravno.Controls.Add(this.label8);
            this.gbPravno.Controls.Add(this.txtTelPravno);
            this.gbPravno.Controls.Add(this.label9);
            this.gbPravno.Controls.Add(this.txtPIB);
            this.gbPravno.Controls.Add(this.label10);
            this.gbPravno.Controls.Add(this.txtNaziv);
            this.gbPravno.Controls.Add(this.label11);
            this.gbPravno.Controls.Add(this.txtSediste);
            this.gbPravno.Controls.Add(this.label12);
            this.gbPravno.Controls.Add(this.txtKontakt);
            this.gbPravno.Controls.Add(this.label13);
            this.gbPravno.Controls.Add(this.txtEmailpravno);
            this.gbPravno.Location = new System.Drawing.Point(312, 220);
            this.gbPravno.Name = "gbPravno";
            this.gbPravno.Size = new System.Drawing.Size(441, 211);
            this.gbPravno.TabIndex = 20;
            this.gbPravno.TabStop = false;
            this.gbPravno.Text = "Pravno";
            // 
            // btnKupi
            // 
            this.btnKupi.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnKupi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKupi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKupi.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnKupi.Location = new System.Drawing.Point(51, 395);
            this.btnKupi.Name = "btnKupi";
            this.btnKupi.Size = new System.Drawing.Size(133, 43);
            this.btnKupi.TabIndex = 21;
            this.btnKupi.Text = "Kupi";
            this.btnKupi.UseVisualStyleBackColor = false;
            this.btnKupi.Click += new System.EventHandler(this.btnKupi_Click);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(51, 181);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(128, 16);
            this.label14.TabIndex = 23;
            this.label14.Text = "Dostupne promocije";
            // 
            // cmbPromocije
            // 
            this.cmbPromocije.FormattingEnabled = true;
            this.cmbPromocije.Location = new System.Drawing.Point(51, 200);
            this.cmbPromocije.Name = "cmbPromocije";
            this.cmbPromocije.Size = new System.Drawing.Size(189, 24);
            this.cmbPromocije.TabIndex = 26;
            this.cmbPromocije.SelectedIndexChanged += new System.EventHandler(this.cmbPromocije_SelectedIndexChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rbLeasing);
            this.groupBox2.Controls.Add(this.rbKredit);
            this.groupBox2.Controls.Add(this.rbGotovina);
            this.groupBox2.Location = new System.Drawing.Point(51, 243);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 129);
            this.groupBox2.TabIndex = 27;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Nacin placanja";
            // 
            // rbGotovina
            // 
            this.rbGotovina.AutoSize = true;
            this.rbGotovina.Location = new System.Drawing.Point(7, 22);
            this.rbGotovina.Name = "rbGotovina";
            this.rbGotovina.Size = new System.Drawing.Size(82, 20);
            this.rbGotovina.TabIndex = 0;
            this.rbGotovina.TabStop = true;
            this.rbGotovina.Text = "Gotovina";
            this.rbGotovina.UseVisualStyleBackColor = true;
            this.rbGotovina.CheckedChanged += new System.EventHandler(this.rbGotovina_CheckedChanged);
            // 
            // rbKredit
            // 
            this.rbKredit.AutoSize = true;
            this.rbKredit.Location = new System.Drawing.Point(7, 48);
            this.rbKredit.Name = "rbKredit";
            this.rbKredit.Size = new System.Drawing.Size(62, 20);
            this.rbKredit.TabIndex = 1;
            this.rbKredit.TabStop = true;
            this.rbKredit.Text = "Kredit";
            this.rbKredit.UseVisualStyleBackColor = true;
            this.rbKredit.CheckedChanged += new System.EventHandler(this.rbKredit_CheckedChanged);
            // 
            // rbLeasing
            // 
            this.rbLeasing.AutoSize = true;
            this.rbLeasing.Location = new System.Drawing.Point(7, 74);
            this.rbLeasing.Name = "rbLeasing";
            this.rbLeasing.Size = new System.Drawing.Size(76, 20);
            this.rbLeasing.TabIndex = 2;
            this.rbLeasing.TabStop = true;
            this.rbLeasing.Text = "Leasing";
            this.rbLeasing.UseVisualStyleBackColor = true;
            this.rbLeasing.CheckedChanged += new System.EventHandler(this.rbLeasing_CheckedChanged);
            // 
            // Kupi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.cmbPromocije);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.btnKupi);
            this.Controls.Add(this.gbPravno);
            this.Controls.Add(this.gbFizicko);
            this.Controls.Add(this.groupBox1);
            this.Name = "Kupi";
            this.Text = "Kupi";
            this.Load += new System.EventHandler(this.Kupi_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.gbFizicko.ResumeLayout(false);
            this.gbFizicko.PerformLayout();
            this.gbPravno.ResumeLayout(false);
            this.gbPravno.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rbPravno;
        private System.Windows.Forms.RadioButton rbFizicko;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtIme;
        private System.Windows.Forms.TextBox txtPrezime;
        private System.Windows.Forms.TextBox txtAdresa;
        private System.Windows.Forms.TextBox txtJMBG;
        private System.Windows.Forms.TextBox txtTelefonFiz;
        private System.Windows.Forms.TextBox txtEmailFiz;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox gbFizicko;
        private System.Windows.Forms.TextBox txtEmailpravno;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtKontakt;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtSediste;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtNaziv;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtPIB;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtTelPravno;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox gbPravno;
        private System.Windows.Forms.Button btnKupi;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.ComboBox cmbPromocije;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rbLeasing;
        private System.Windows.Forms.RadioButton rbKredit;
        private System.Windows.Forms.RadioButton rbGotovina;
    }
}