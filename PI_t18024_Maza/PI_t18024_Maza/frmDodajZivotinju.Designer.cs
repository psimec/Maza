﻿namespace PI_t18024_Maza
{
    partial class frmDodajZivotinju
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
            this.lblImeZivotinje = new System.Windows.Forms.Label();
            this.uiIme = new System.Windows.Forms.TextBox();
            this.lblSpol = new System.Windows.Forms.Label();
            this.lblVrsta = new System.Windows.Forms.Label();
            this.uiVrsta = new System.Windows.Forms.TextBox();
            this.lblDatumRodenja = new System.Windows.Forms.Label();
            this.lblBrojCipa = new System.Windows.Forms.Label();
            this.uiBrojCipa = new System.Windows.Forms.TextBox();
            this.lblTezina = new System.Windows.Forms.Label();
            this.uiTezina = new System.Windows.Forms.TextBox();
            this.uiOdabirSpola = new System.Windows.Forms.ComboBox();
            this.uiDatumRodenja = new System.Windows.Forms.DateTimePicker();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.uiAdresa = new System.Windows.Forms.TextBox();
            this.lblAdresa = new System.Windows.Forms.Label();
            this.uiPrezimeVlasnika = new System.Windows.Forms.TextBox();
            this.lblPrezime = new System.Windows.Forms.Label();
            this.uiEmail = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.uiBrojTelefona = new System.Windows.Forms.TextBox();
            this.lblBrojTelefona = new System.Windows.Forms.Label();
            this.uiBrojMobitela = new System.Windows.Forms.TextBox();
            this.lblBrojMobitela = new System.Windows.Forms.Label();
            this.uiImeVlasnika = new System.Windows.Forms.TextBox();
            this.lblIme = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblImeZivotinje
            // 
            this.lblImeZivotinje.AutoSize = true;
            this.lblImeZivotinje.Location = new System.Drawing.Point(10, 24);
            this.lblImeZivotinje.Name = "lblImeZivotinje";
            this.lblImeZivotinje.Size = new System.Drawing.Size(34, 17);
            this.lblImeZivotinje.TabIndex = 0;
            this.lblImeZivotinje.Text = "Ime:";
            // 
            // uiIme
            // 
            this.uiIme.Location = new System.Drawing.Point(90, 21);
            this.uiIme.Name = "uiIme";
            this.uiIme.Size = new System.Drawing.Size(352, 22);
            this.uiIme.TabIndex = 1;
            // 
            // lblSpol
            // 
            this.lblSpol.AutoSize = true;
            this.lblSpol.Location = new System.Drawing.Point(10, 108);
            this.lblSpol.Name = "lblSpol";
            this.lblSpol.Size = new System.Drawing.Size(40, 17);
            this.lblSpol.TabIndex = 0;
            this.lblSpol.Text = "Spol:";
            // 
            // lblVrsta
            // 
            this.lblVrsta.AutoSize = true;
            this.lblVrsta.Location = new System.Drawing.Point(10, 67);
            this.lblVrsta.Name = "lblVrsta";
            this.lblVrsta.Size = new System.Drawing.Size(45, 17);
            this.lblVrsta.TabIndex = 0;
            this.lblVrsta.Text = "Vrsta:";
            // 
            // uiVrsta
            // 
            this.uiVrsta.Location = new System.Drawing.Point(90, 64);
            this.uiVrsta.Name = "uiVrsta";
            this.uiVrsta.Size = new System.Drawing.Size(87, 22);
            this.uiVrsta.TabIndex = 1;
            this.uiVrsta.TextChanged += new System.EventHandler(this.uiVrsta_TextChanged);
            // 
            // lblDatumRodenja
            // 
            this.lblDatumRodenja.AutoSize = true;
            this.lblDatumRodenja.Location = new System.Drawing.Point(85, 157);
            this.lblDatumRodenja.Name = "lblDatumRodenja";
            this.lblDatumRodenja.Size = new System.Drawing.Size(101, 17);
            this.lblDatumRodenja.TabIndex = 0;
            this.lblDatumRodenja.Text = "Datum rođenja";
            // 
            // lblBrojCipa
            // 
            this.lblBrojCipa.AutoSize = true;
            this.lblBrojCipa.Location = new System.Drawing.Point(206, 67);
            this.lblBrojCipa.Name = "lblBrojCipa";
            this.lblBrojCipa.Size = new System.Drawing.Size(63, 17);
            this.lblBrojCipa.TabIndex = 0;
            this.lblBrojCipa.Text = "Broj čipa";
            this.lblBrojCipa.Visible = false;
            // 
            // uiBrojCipa
            // 
            this.uiBrojCipa.Location = new System.Drawing.Point(275, 62);
            this.uiBrojCipa.Name = "uiBrojCipa";
            this.uiBrojCipa.Size = new System.Drawing.Size(167, 22);
            this.uiBrojCipa.TabIndex = 1;
            this.uiBrojCipa.Visible = false;
            // 
            // lblTezina
            // 
            this.lblTezina.AutoSize = true;
            this.lblTezina.Location = new System.Drawing.Point(206, 108);
            this.lblTezina.Name = "lblTezina";
            this.lblTezina.Size = new System.Drawing.Size(55, 17);
            this.lblTezina.TabIndex = 0;
            this.lblTezina.Text = "Težina:";
            // 
            // uiTezina
            // 
            this.uiTezina.Location = new System.Drawing.Point(275, 103);
            this.uiTezina.Name = "uiTezina";
            this.uiTezina.Size = new System.Drawing.Size(167, 22);
            this.uiTezina.TabIndex = 1;
            // 
            // uiOdabirSpola
            // 
            this.uiOdabirSpola.FormattingEnabled = true;
            this.uiOdabirSpola.Location = new System.Drawing.Point(90, 105);
            this.uiOdabirSpola.Name = "uiOdabirSpola";
            this.uiOdabirSpola.Size = new System.Drawing.Size(46, 24);
            this.uiOdabirSpola.TabIndex = 2;
            // 
            // uiDatumRodenja
            // 
            this.uiDatumRodenja.Location = new System.Drawing.Point(209, 157);
            this.uiDatumRodenja.Name = "uiDatumRodenja";
            this.uiDatumRodenja.Size = new System.Drawing.Size(176, 22);
            this.uiDatumRodenja.TabIndex = 3;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.uiIme);
            this.groupBox1.Controls.Add(this.uiDatumRodenja);
            this.groupBox1.Controls.Add(this.lblDatumRodenja);
            this.groupBox1.Controls.Add(this.lblImeZivotinje);
            this.groupBox1.Controls.Add(this.uiOdabirSpola);
            this.groupBox1.Controls.Add(this.lblSpol);
            this.groupBox1.Controls.Add(this.uiTezina);
            this.groupBox1.Controls.Add(this.lblVrsta);
            this.groupBox1.Controls.Add(this.lblTezina);
            this.groupBox1.Controls.Add(this.uiVrsta);
            this.groupBox1.Controls.Add(this.uiBrojCipa);
            this.groupBox1.Controls.Add(this.lblBrojCipa);
            this.groupBox1.Location = new System.Drawing.Point(12, 220);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(547, 194);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Životinja";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.uiAdresa);
            this.groupBox2.Controls.Add(this.lblAdresa);
            this.groupBox2.Controls.Add(this.uiPrezimeVlasnika);
            this.groupBox2.Controls.Add(this.lblPrezime);
            this.groupBox2.Controls.Add(this.uiEmail);
            this.groupBox2.Controls.Add(this.lblEmail);
            this.groupBox2.Controls.Add(this.uiBrojTelefona);
            this.groupBox2.Controls.Add(this.lblBrojTelefona);
            this.groupBox2.Controls.Add(this.uiBrojMobitela);
            this.groupBox2.Controls.Add(this.lblBrojMobitela);
            this.groupBox2.Controls.Add(this.uiImeVlasnika);
            this.groupBox2.Controls.Add(this.lblIme);
            this.groupBox2.Location = new System.Drawing.Point(12, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(547, 160);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Vlasnik";
            // 
            // uiAdresa
            // 
            this.uiAdresa.Location = new System.Drawing.Point(109, 59);
            this.uiAdresa.Name = "uiAdresa";
            this.uiAdresa.ReadOnly = true;
            this.uiAdresa.Size = new System.Drawing.Size(432, 22);
            this.uiAdresa.TabIndex = 1;
            // 
            // lblAdresa
            // 
            this.lblAdresa.AutoSize = true;
            this.lblAdresa.Location = new System.Drawing.Point(7, 59);
            this.lblAdresa.Name = "lblAdresa";
            this.lblAdresa.Size = new System.Drawing.Size(57, 17);
            this.lblAdresa.TabIndex = 0;
            this.lblAdresa.Text = "Adresa:";
            // 
            // uiPrezimeVlasnika
            // 
            this.uiPrezimeVlasnika.Location = new System.Drawing.Point(391, 20);
            this.uiPrezimeVlasnika.Name = "uiPrezimeVlasnika";
            this.uiPrezimeVlasnika.ReadOnly = true;
            this.uiPrezimeVlasnika.Size = new System.Drawing.Size(150, 22);
            this.uiPrezimeVlasnika.TabIndex = 1;
            // 
            // lblPrezime
            // 
            this.lblPrezime.AutoSize = true;
            this.lblPrezime.Location = new System.Drawing.Point(322, 23);
            this.lblPrezime.Name = "lblPrezime";
            this.lblPrezime.Size = new System.Drawing.Size(63, 17);
            this.lblPrezime.TabIndex = 0;
            this.lblPrezime.Text = "Prezime:";
            // 
            // uiEmail
            // 
            this.uiEmail.Location = new System.Drawing.Point(109, 128);
            this.uiEmail.Name = "uiEmail";
            this.uiEmail.ReadOnly = true;
            this.uiEmail.Size = new System.Drawing.Size(160, 22);
            this.uiEmail.TabIndex = 1;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(7, 131);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(46, 17);
            this.lblEmail.TabIndex = 0;
            this.lblEmail.Text = "Email:";
            // 
            // uiBrojTelefona
            // 
            this.uiBrojTelefona.Location = new System.Drawing.Point(381, 95);
            this.uiBrojTelefona.Name = "uiBrojTelefona";
            this.uiBrojTelefona.ReadOnly = true;
            this.uiBrojTelefona.Size = new System.Drawing.Size(160, 22);
            this.uiBrojTelefona.TabIndex = 1;
            // 
            // lblBrojTelefona
            // 
            this.lblBrojTelefona.AutoSize = true;
            this.lblBrojTelefona.Location = new System.Drawing.Point(278, 98);
            this.lblBrojTelefona.Name = "lblBrojTelefona";
            this.lblBrojTelefona.Size = new System.Drawing.Size(97, 17);
            this.lblBrojTelefona.TabIndex = 0;
            this.lblBrojTelefona.Text = "Broj Telefona:";
            // 
            // uiBrojMobitela
            // 
            this.uiBrojMobitela.Location = new System.Drawing.Point(109, 97);
            this.uiBrojMobitela.Name = "uiBrojMobitela";
            this.uiBrojMobitela.ReadOnly = true;
            this.uiBrojMobitela.Size = new System.Drawing.Size(160, 22);
            this.uiBrojMobitela.TabIndex = 1;
            // 
            // lblBrojMobitela
            // 
            this.lblBrojMobitela.AutoSize = true;
            this.lblBrojMobitela.Location = new System.Drawing.Point(6, 100);
            this.lblBrojMobitela.Name = "lblBrojMobitela";
            this.lblBrojMobitela.Size = new System.Drawing.Size(94, 17);
            this.lblBrojMobitela.TabIndex = 0;
            this.lblBrojMobitela.Text = "Broj Mobitela:";
            // 
            // uiImeVlasnika
            // 
            this.uiImeVlasnika.Location = new System.Drawing.Point(109, 22);
            this.uiImeVlasnika.Name = "uiImeVlasnika";
            this.uiImeVlasnika.ReadOnly = true;
            this.uiImeVlasnika.Size = new System.Drawing.Size(160, 22);
            this.uiImeVlasnika.TabIndex = 1;
            // 
            // lblIme
            // 
            this.lblIme.AutoSize = true;
            this.lblIme.Location = new System.Drawing.Point(6, 25);
            this.lblIme.Name = "lblIme";
            this.lblIme.Size = new System.Drawing.Size(34, 17);
            this.lblIme.TabIndex = 0;
            this.lblIme.Text = "Ime:";
            // 
            // frmDodajZivotinju
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(571, 482);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmDodajZivotinju";
            this.Text = "DodajZivotinjuForm";
            this.Load += new System.EventHandler(this.DodajZivotinjuForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblImeZivotinje;
        private System.Windows.Forms.TextBox uiIme;
        private System.Windows.Forms.Label lblSpol;
        private System.Windows.Forms.Label lblVrsta;
        private System.Windows.Forms.TextBox uiVrsta;
        private System.Windows.Forms.Label lblDatumRodenja;
        private System.Windows.Forms.Label lblBrojCipa;
        private System.Windows.Forms.TextBox uiBrojCipa;
        private System.Windows.Forms.Label lblTezina;
        private System.Windows.Forms.TextBox uiTezina;
        private System.Windows.Forms.ComboBox uiOdabirSpola;
        private System.Windows.Forms.DateTimePicker uiDatumRodenja;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox uiAdresa;
        private System.Windows.Forms.Label lblAdresa;
        private System.Windows.Forms.TextBox uiPrezimeVlasnika;
        private System.Windows.Forms.Label lblPrezime;
        private System.Windows.Forms.TextBox uiImeVlasnika;
        private System.Windows.Forms.Label lblIme;
        private System.Windows.Forms.TextBox uiEmail;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox uiBrojMobitela;
        private System.Windows.Forms.Label lblBrojMobitela;
        private System.Windows.Forms.TextBox uiBrojTelefona;
        private System.Windows.Forms.Label lblBrojTelefona;
    }
}