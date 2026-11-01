namespace AutoSalon
{
    partial class Home
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Home));
            this.cmdSaloni = new System.Windows.Forms.Button();
            this.cmdIzadji = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // cmdSaloni
            // 
            this.cmdSaloni.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdSaloni.Location = new System.Drawing.Point(97, 412);
            this.cmdSaloni.Name = "cmdSaloni";
            this.cmdSaloni.Size = new System.Drawing.Size(126, 50);
            this.cmdSaloni.TabIndex = 0;
            this.cmdSaloni.Text = "Saloni";
            this.cmdSaloni.UseVisualStyleBackColor = true;
            this.cmdSaloni.Click += new System.EventHandler(this.cmdSaloni_Click);
            // 
            // cmdIzadji
            // 
            this.cmdIzadji.BackColor = System.Drawing.Color.Red;
            this.cmdIzadji.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdIzadji.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdIzadji.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.cmdIzadji.Location = new System.Drawing.Point(253, 412);
            this.cmdIzadji.Name = "cmdIzadji";
            this.cmdIzadji.Size = new System.Drawing.Size(126, 50);
            this.cmdIzadji.TabIndex = 1;
            this.cmdIzadji.Text = "Izadji";
            this.cmdIzadji.UseVisualStyleBackColor = false;
            this.cmdIzadji.Click += new System.EventHandler(this.cmdIzadji_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(25, 62);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(405, 344);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(137, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(191, 50);
            this.label1.TabIndex = 3;
            this.label1.Text = "Auto Saloni";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(471, 496);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.cmdIzadji);
            this.Controls.Add(this.cmdSaloni);
            this.Name = "Home";
            this.Text = "Auto Salon";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button cmdSaloni;
        private System.Windows.Forms.Button cmdIzadji;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
    }
}