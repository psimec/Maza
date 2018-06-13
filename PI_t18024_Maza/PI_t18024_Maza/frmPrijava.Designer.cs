namespace PI_t18024_Maza
{
    partial class frmPrijava
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPrijava));
            this.uiUnosKorisnickogImena = new System.Windows.Forms.TextBox();
            this.uiUnosLozinke = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.uiActionOdustani = new System.Windows.Forms.Button();
            this.uiActionPrijava = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // uiUnosKorisnickogImena
            // 
            this.uiUnosKorisnickogImena.Location = new System.Drawing.Point(162, 143);
            this.uiUnosKorisnickogImena.Name = "uiUnosKorisnickogImena";
            this.uiUnosKorisnickogImena.Size = new System.Drawing.Size(184, 20);
            this.uiUnosKorisnickogImena.TabIndex = 0;
            this.uiUnosKorisnickogImena.TextChanged += new System.EventHandler(this.uiUnosKorisnickogImena_TextChanged);
            this.uiUnosKorisnickogImena.KeyDown += new System.Windows.Forms.KeyEventHandler(this.uiUnosKorisnickogImena_KeyDown);
            // 
            // uiUnosLozinke
            // 
            this.uiUnosLozinke.Location = new System.Drawing.Point(162, 180);
            this.uiUnosLozinke.Name = "uiUnosLozinke";
            this.uiUnosLozinke.Size = new System.Drawing.Size(184, 20);
            this.uiUnosLozinke.TabIndex = 1;
            this.uiUnosLozinke.TextChanged += new System.EventHandler(this.uiUnosLozinke_TextChanged);
            this.uiUnosLozinke.KeyDown += new System.Windows.Forms.KeyEventHandler(this.uiUnosLozinke_KeyDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(35, 144);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 19);
            this.label1.TabIndex = 2;
            this.label1.Text = "Korisničko ime:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(35, 181);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 19);
            this.label2.TabIndex = 3;
            this.label2.Text = "Lozinka:";
            // 
            // uiActionOdustani
            // 
            this.uiActionOdustani.BackColor = System.Drawing.Color.White;
            this.uiActionOdustani.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.uiActionOdustani.FlatAppearance.BorderSize = 0;
            this.uiActionOdustani.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.uiActionOdustani.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.uiActionOdustani.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.uiActionOdustani.Location = new System.Drawing.Point(257, 221);
            this.uiActionOdustani.Name = "uiActionOdustani";
            this.uiActionOdustani.Size = new System.Drawing.Size(75, 23);
            this.uiActionOdustani.TabIndex = 4;
            this.uiActionOdustani.Text = "Odustani";
            this.uiActionOdustani.UseVisualStyleBackColor = false;
            this.uiActionOdustani.Click += new System.EventHandler(this.uiActionOdustani_Click);
            // 
            // uiActionPrijava
            // 
            this.uiActionPrijava.BackColor = System.Drawing.Color.White;
            this.uiActionPrijava.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.uiActionPrijava.FlatAppearance.BorderSize = 0;
            this.uiActionPrijava.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.uiActionPrijava.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.uiActionPrijava.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.uiActionPrijava.Location = new System.Drawing.Point(162, 221);
            this.uiActionPrijava.Name = "uiActionPrijava";
            this.uiActionPrijava.Size = new System.Drawing.Size(75, 23);
            this.uiActionPrijava.TabIndex = 5;
            this.uiActionPrijava.Text = "Prijava";
            this.uiActionPrijava.UseVisualStyleBackColor = false;
            this.uiActionPrijava.Click += new System.EventHandler(this.uiActionPrijava_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(-5, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(391, 129);
            this.panel1.TabIndex = 6;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(31, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(334, 133);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 221);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "mmaric,lozinka";
            // 
            // Prijava
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(127)))), ((int)(((byte)(187)))));
            this.ClientSize = new System.Drawing.Size(385, 262);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.uiActionPrijava);
            this.Controls.Add(this.uiActionOdustani);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.uiUnosLozinke);
            this.Controls.Add(this.uiUnosKorisnickogImena);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Prijava";
            this.Text = "Prijava";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox uiUnosKorisnickogImena;
        private System.Windows.Forms.TextBox uiUnosLozinke;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button uiActionOdustani;
        private System.Windows.Forms.Button uiActionPrijava;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label3;
    }
}