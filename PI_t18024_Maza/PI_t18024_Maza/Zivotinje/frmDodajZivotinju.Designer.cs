namespace PI_t18024_Maza
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
            this.uiDatumRodenja = new System.Windows.Forms.DateTimePicker();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.uiZiv = new System.Windows.Forms.CheckBox();
            this.uiDatumUginuca = new System.Windows.Forms.DateTimePicker();
            this.uiLblDatumUginuca = new System.Windows.Forms.Label();
            this.uiZensko = new System.Windows.Forms.RadioButton();
            this.uiMusko = new System.Windows.Forms.RadioButton();
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
            this.uiZavrsi = new System.Windows.Forms.Button();
            this.korisnickaPodrska = new System.Windows.Forms.HelpProvider();
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
            this.lblSpol.Location = new System.Drawing.Point(10, 120);
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
            this.uiVrsta.TabIndex = 2;
            this.uiVrsta.TextChanged += new System.EventHandler(this.uiVrsta_TextChanged);
            // 
            // lblDatumRodenja
            // 
            this.lblDatumRodenja.AutoSize = true;
            this.lblDatumRodenja.Location = new System.Drawing.Point(107, 166);
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
            this.uiBrojCipa.TabIndex = 3;
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
            this.uiTezina.TabIndex = 4;
            // 
            // uiDatumRodenja
            // 
            this.uiDatumRodenja.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.uiDatumRodenja.Location = new System.Drawing.Point(231, 166);
            this.uiDatumRodenja.Name = "uiDatumRodenja";
            this.uiDatumRodenja.Size = new System.Drawing.Size(176, 22);
            this.uiDatumRodenja.TabIndex = 8;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.uiZiv);
            this.groupBox1.Controls.Add(this.uiDatumUginuca);
            this.groupBox1.Controls.Add(this.uiLblDatumUginuca);
            this.groupBox1.Controls.Add(this.uiZensko);
            this.groupBox1.Controls.Add(this.uiMusko);
            this.groupBox1.Controls.Add(this.uiIme);
            this.groupBox1.Controls.Add(this.uiDatumRodenja);
            this.groupBox1.Controls.Add(this.lblDatumRodenja);
            this.groupBox1.Controls.Add(this.lblImeZivotinje);
            this.groupBox1.Controls.Add(this.lblSpol);
            this.groupBox1.Controls.Add(this.uiTezina);
            this.groupBox1.Controls.Add(this.lblVrsta);
            this.groupBox1.Controls.Add(this.lblTezina);
            this.groupBox1.Controls.Add(this.uiVrsta);
            this.groupBox1.Controls.Add(this.uiBrojCipa);
            this.groupBox1.Controls.Add(this.lblBrojCipa);
            this.groupBox1.Location = new System.Drawing.Point(12, 188);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(547, 264);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Životinja";
            // 
            // uiZiv
            // 
            this.uiZiv.AutoSize = true;
            this.uiZiv.Location = new System.Drawing.Point(90, 219);
            this.uiZiv.Name = "uiZiv";
            this.uiZiv.Size = new System.Drawing.Size(49, 21);
            this.uiZiv.TabIndex = 12;
            this.uiZiv.Text = "Ziv";
            this.uiZiv.UseVisualStyleBackColor = true;
            this.uiZiv.CheckedChanged += new System.EventHandler(this.uiZiv_CheckedChanged);
            // 
            // uiDatumUginuca
            // 
            this.uiDatumUginuca.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.uiDatumUginuca.Location = new System.Drawing.Point(365, 219);
            this.uiDatumUginuca.Name = "uiDatumUginuca";
            this.uiDatumUginuca.Size = new System.Drawing.Size(176, 22);
            this.uiDatumUginuca.TabIndex = 10;
            // 
            // uiLblDatumUginuca
            // 
            this.uiLblDatumUginuca.AutoSize = true;
            this.uiLblDatumUginuca.Location = new System.Drawing.Point(241, 219);
            this.uiLblDatumUginuca.Name = "uiLblDatumUginuca";
            this.uiLblDatumUginuca.Size = new System.Drawing.Size(103, 17);
            this.uiLblDatumUginuca.TabIndex = 9;
            this.uiLblDatumUginuca.Text = "Datum uginuća";
            // 
            // uiZensko
            // 
            this.uiZensko.AutoSize = true;
            this.uiZensko.Location = new System.Drawing.Point(88, 130);
            this.uiZensko.Name = "uiZensko";
            this.uiZensko.Size = new System.Drawing.Size(76, 21);
            this.uiZensko.TabIndex = 6;
            this.uiZensko.TabStop = true;
            this.uiZensko.Text = "Žensko";
            this.uiZensko.UseVisualStyleBackColor = true;
            // 
            // uiMusko
            // 
            this.uiMusko.AutoSize = true;
            this.uiMusko.Location = new System.Drawing.Point(88, 103);
            this.uiMusko.Name = "uiMusko";
            this.uiMusko.Size = new System.Drawing.Size(70, 21);
            this.uiMusko.TabIndex = 7;
            this.uiMusko.TabStop = true;
            this.uiMusko.Text = "Muško";
            this.uiMusko.UseVisualStyleBackColor = true;
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
            // uiZavrsi
            // 
            this.uiZavrsi.Location = new System.Drawing.Point(194, 458);
            this.uiZavrsi.Name = "uiZavrsi";
            this.uiZavrsi.Size = new System.Drawing.Size(128, 38);
            this.uiZavrsi.TabIndex = 1;
            this.uiZavrsi.Text = "Završi";
            this.uiZavrsi.UseVisualStyleBackColor = true;
            this.uiZavrsi.Click += new System.EventHandler(this.uiZavrsi_Click);
            // 
            // frmDodajZivotinju
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(571, 508);
            this.Controls.Add(this.uiZavrsi);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmDodajZivotinju";
            this.Text = "Dodaj životinju";
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
        private System.Windows.Forms.Button uiZavrsi;
        private System.Windows.Forms.RadioButton uiZensko;
        private System.Windows.Forms.RadioButton uiMusko;
        private System.Windows.Forms.DateTimePicker uiDatumUginuca;
        private System.Windows.Forms.Label uiLblDatumUginuca;
        private System.Windows.Forms.CheckBox uiZiv;
        private System.Windows.Forms.HelpProvider korisnickaPodrska;
    }
}