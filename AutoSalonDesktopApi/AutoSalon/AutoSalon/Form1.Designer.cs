namespace AutoSalon
{
    partial class Form1
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
            this.cmdUcitavanje = new System.Windows.Forms.Button();
            this.cmdDodavanje = new System.Windows.Forms.Button();
            this.cmdUcitajZaposlenog = new System.Windows.Forms.Button();
            this.cmdDodajZaposlenog = new System.Windows.Forms.Button();
            this.cmdDodajFizicko = new System.Windows.Forms.Button();
            this.cmdDodajPravno = new System.Windows.Forms.Button();
            this.cmdDodajKupovinu = new System.Windows.Forms.Button();
            this.cmdDodajVozilo = new System.Windows.Forms.Button();
            this.cmdDodajVoznju = new System.Windows.Forms.Button();
            this.cmbTipVozila = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // cmdUcitavanje
            // 
            this.cmdUcitavanje.Location = new System.Drawing.Point(77, 51);
            this.cmdUcitavanje.Name = "cmdUcitavanje";
            this.cmdUcitavanje.Size = new System.Drawing.Size(158, 40);
            this.cmdUcitavanje.TabIndex = 0;
            this.cmdUcitavanje.Text = "Ucitavanje salona";
            this.cmdUcitavanje.UseVisualStyleBackColor = true;
            this.cmdUcitavanje.Click += new System.EventHandler(this.cmdUcitavanje_Click);
            // 
            // cmdDodavanje
            // 
            this.cmdDodavanje.Location = new System.Drawing.Point(77, 107);
            this.cmdDodavanje.Name = "cmdDodavanje";
            this.cmdDodavanje.Size = new System.Drawing.Size(158, 36);
            this.cmdDodavanje.TabIndex = 1;
            this.cmdDodavanje.Text = "Dodavanje salona";
            this.cmdDodavanje.UseVisualStyleBackColor = true;
            this.cmdDodavanje.Click += new System.EventHandler(this.cmdDodavanje_Click);
            // 
            // cmdUcitajZaposlenog
            // 
            this.cmdUcitajZaposlenog.Location = new System.Drawing.Point(77, 160);
            this.cmdUcitajZaposlenog.Name = "cmdUcitajZaposlenog";
            this.cmdUcitajZaposlenog.Size = new System.Drawing.Size(158, 36);
            this.cmdUcitajZaposlenog.TabIndex = 2;
            this.cmdUcitajZaposlenog.Text = "Ucitaj zaposlenog";
            this.cmdUcitajZaposlenog.UseVisualStyleBackColor = true;
            this.cmdUcitajZaposlenog.Click += new System.EventHandler(this.cmdUcitajZaposlenog_Click);
            // 
            // cmdDodajZaposlenog
            // 
            this.cmdDodajZaposlenog.Location = new System.Drawing.Point(77, 216);
            this.cmdDodajZaposlenog.Name = "cmdDodajZaposlenog";
            this.cmdDodajZaposlenog.Size = new System.Drawing.Size(158, 36);
            this.cmdDodajZaposlenog.TabIndex = 3;
            this.cmdDodajZaposlenog.Text = "Dodaj zaposlenog";
            this.cmdDodajZaposlenog.UseVisualStyleBackColor = true;
            this.cmdDodajZaposlenog.Click += new System.EventHandler(this.cmdDodajZaposlenog_Click);
            // 
            // cmdDodajFizicko
            // 
            this.cmdDodajFizicko.Location = new System.Drawing.Point(77, 270);
            this.cmdDodajFizicko.Name = "cmdDodajFizicko";
            this.cmdDodajFizicko.Size = new System.Drawing.Size(158, 36);
            this.cmdDodajFizicko.TabIndex = 4;
            this.cmdDodajFizicko.Text = "Dodaj fizicko lice";
            this.cmdDodajFizicko.UseVisualStyleBackColor = true;
            this.cmdDodajFizicko.Click += new System.EventHandler(this.cmdDodajFizicko_Click);
            // 
            // cmdDodajPravno
            // 
            this.cmdDodajPravno.Location = new System.Drawing.Point(77, 312);
            this.cmdDodajPravno.Name = "cmdDodajPravno";
            this.cmdDodajPravno.Size = new System.Drawing.Size(158, 36);
            this.cmdDodajPravno.TabIndex = 5;
            this.cmdDodajPravno.Text = "Dodaj pravno lice";
            this.cmdDodajPravno.UseVisualStyleBackColor = true;
            this.cmdDodajPravno.Click += new System.EventHandler(this.cmdDodajPravno_Click);
            // 
            // cmdDodajKupovinu
            // 
            this.cmdDodajKupovinu.Location = new System.Drawing.Point(77, 366);
            this.cmdDodajKupovinu.Name = "cmdDodajKupovinu";
            this.cmdDodajKupovinu.Size = new System.Drawing.Size(158, 36);
            this.cmdDodajKupovinu.TabIndex = 6;
            this.cmdDodajKupovinu.Text = "Dodaj kupovinu";
            this.cmdDodajKupovinu.UseVisualStyleBackColor = true;
            this.cmdDodajKupovinu.Click += new System.EventHandler(this.cmdDodajKupovinu_Click);
            // 
            // cmdDodajVozilo
            // 
            this.cmdDodajVozilo.Location = new System.Drawing.Point(294, 53);
            this.cmdDodajVozilo.Name = "cmdDodajVozilo";
            this.cmdDodajVozilo.Size = new System.Drawing.Size(158, 36);
            this.cmdDodajVozilo.TabIndex = 7;
            this.cmdDodajVozilo.Text = "Dodaj vozilo";
            this.cmdDodajVozilo.UseVisualStyleBackColor = true;
            this.cmdDodajVozilo.Click += new System.EventHandler(this.cmdDodajVozilo_Click);
            // 
            // cmdDodajVoznju
            // 
            this.cmdDodajVoznju.Location = new System.Drawing.Point(294, 107);
            this.cmdDodajVoznju.Name = "cmdDodajVoznju";
            this.cmdDodajVoznju.Size = new System.Drawing.Size(158, 36);
            this.cmdDodajVoznju.TabIndex = 8;
            this.cmdDodajVoznju.Text = "Dodaj voznju";
            this.cmdDodajVoznju.UseVisualStyleBackColor = true;
            this.cmdDodajVoznju.Click += new System.EventHandler(this.cmdDodajVoznju_Click);
            // 
            // cmbTipVozila
            // 
            this.cmbTipVozila.FormattingEnabled = true;
            this.cmbTipVozila.Location = new System.Drawing.Point(294, 172);
            this.cmbTipVozila.Name = "cmbTipVozila";
            this.cmbTipVozila.Size = new System.Drawing.Size(121, 24);
            this.cmbTipVozila.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cmbTipVozila);
            this.Controls.Add(this.cmdDodajVoznju);
            this.Controls.Add(this.cmdDodajVozilo);
            this.Controls.Add(this.cmdDodajKupovinu);
            this.Controls.Add(this.cmdDodajPravno);
            this.Controls.Add(this.cmdDodajFizicko);
            this.Controls.Add(this.cmdDodajZaposlenog);
            this.Controls.Add(this.cmdUcitajZaposlenog);
            this.Controls.Add(this.cmdDodavanje);
            this.Controls.Add(this.cmdUcitavanje);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button cmdUcitavanje;
        private System.Windows.Forms.Button cmdDodavanje;
        private System.Windows.Forms.Button cmdUcitajZaposlenog;
        private System.Windows.Forms.Button cmdDodajZaposlenog;
        private System.Windows.Forms.Button cmdDodajFizicko;
        private System.Windows.Forms.Button cmdDodajPravno;
        private System.Windows.Forms.Button cmdDodajKupovinu;
        private System.Windows.Forms.Button cmdDodajVozilo;
        private System.Windows.Forms.Button cmdDodajVoznju;
        private System.Windows.Forms.ComboBox cmbTipVozila;
    }
}

