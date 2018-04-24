namespace PI_t18024_Maza
{
    partial class Prijava
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
            this.uiUnosKorisnickogImena = new System.Windows.Forms.TextBox();
            this.uiUnosLozinke = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.uiActionOdustani = new System.Windows.Forms.Button();
            this.uiActionPrijava = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // uiUnosKorisnickogImena
            // 
            this.uiUnosKorisnickogImena.Location = new System.Drawing.Point(162, 131);
            this.uiUnosKorisnickogImena.Name = "uiUnosKorisnickogImena";
            this.uiUnosKorisnickogImena.Size = new System.Drawing.Size(184, 20);
            this.uiUnosKorisnickogImena.TabIndex = 0;
            // 
            // uiUnosLozinke
            // 
            this.uiUnosLozinke.Location = new System.Drawing.Point(162, 168);
            this.uiUnosLozinke.Name = "uiUnosLozinke";
            this.uiUnosLozinke.Size = new System.Drawing.Size(184, 20);
            this.uiUnosLozinke.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(46, 131);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Korisničko ime";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(46, 168);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Lozinka";
            // 
            // uiActionOdustani
            // 
            this.uiActionOdustani.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.uiActionOdustani.Location = new System.Drawing.Point(271, 212);
            this.uiActionOdustani.Name = "uiActionOdustani";
            this.uiActionOdustani.Size = new System.Drawing.Size(75, 23);
            this.uiActionOdustani.TabIndex = 4;
            this.uiActionOdustani.Text = "Odustani";
            this.uiActionOdustani.UseVisualStyleBackColor = true;
            // 
            // uiActionPrijava
            // 
            this.uiActionPrijava.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.uiActionPrijava.Location = new System.Drawing.Point(174, 212);
            this.uiActionPrijava.Name = "uiActionPrijava";
            this.uiActionPrijava.Size = new System.Drawing.Size(75, 23);
            this.uiActionPrijava.TabIndex = 5;
            this.uiActionPrijava.Text = "Prijava";
            this.uiActionPrijava.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Location = new System.Drawing.Point(-5, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(391, 113);
            this.panel1.TabIndex = 6;
            // 
            // Prijava
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 261);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.uiActionPrijava);
            this.Controls.Add(this.uiActionOdustani);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.uiUnosLozinke);
            this.Controls.Add(this.uiUnosKorisnickogImena);
            this.Name = "Prijava";
            this.Text = "Prijava";
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
    }
}