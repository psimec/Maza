namespace PI_t18024_Maza
{
    partial class frmDodajDijagnozu
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
            this.uiPodaciOZivotinji = new System.Windows.Forms.GroupBox();
            this.uiDatumRodenjaZivotinje = new System.Windows.Forms.Label();
            this.uiVrstaZivotinje = new System.Windows.Forms.Label();
            this.uiImeZivotinje = new System.Windows.Forms.Label();
            this.uiVlasnikZivotinje = new System.Windows.Forms.Label();
            this.uiSimptomi = new System.Windows.Forms.TextBox();
            this.uiTerapija = new System.Windows.Forms.TextBox();
            this.uiNapomena = new System.Windows.Forms.TextBox();
            this.uiNaslovSimptomi = new System.Windows.Forms.Label();
            this.uiNaslovTerapija = new System.Windows.Forms.Label();
            this.uiNaslovNapomena = new System.Windows.Forms.Label();
            this.uiActionOdaberiLijek = new System.Windows.Forms.ComboBox();
            this.lijekBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.uiNapomenaLijekUnos = new System.Windows.Forms.TextBox();
            this.uiActionDodajLijek = new System.Windows.Forms.Button();
            this.uiPropisaniLijekovi = new System.Windows.Forms.ListBox();
            this.uiActionObrisiLijek = new System.Windows.Forms.Button();
            this.uiNaslovLijekovi = new System.Windows.Forms.Label();
            this.uiNaslovNapomenaLijeka = new System.Windows.Forms.Label();
            this.uiNaslovPropisaniLijekovi = new System.Windows.Forms.Label();
            this.uiActionDodajDijagnozu = new System.Windows.Forms.Button();
            this.uiActionOdustani = new System.Windows.Forms.Button();
            this.uiActionOdaberiBolest = new System.Windows.Forms.ComboBox();
            this.bolestBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.uiBolest = new System.Windows.Forms.Label();
            this.korisnickaPodrska = new System.Windows.Forms.HelpProvider();
            this.uiPodaciOZivotinji.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lijekBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bolestBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // uiPodaciOZivotinji
            // 
            this.uiPodaciOZivotinji.Controls.Add(this.uiDatumRodenjaZivotinje);
            this.uiPodaciOZivotinji.Controls.Add(this.uiVrstaZivotinje);
            this.uiPodaciOZivotinji.Controls.Add(this.uiImeZivotinje);
            this.uiPodaciOZivotinji.Controls.Add(this.uiVlasnikZivotinje);
            this.uiPodaciOZivotinji.Location = new System.Drawing.Point(24, 14);
            this.uiPodaciOZivotinji.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.uiPodaciOZivotinji.Name = "uiPodaciOZivotinji";
            this.uiPodaciOZivotinji.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.uiPodaciOZivotinji.Size = new System.Drawing.Size(297, 218);
            this.uiPodaciOZivotinji.TabIndex = 0;
            this.uiPodaciOZivotinji.TabStop = false;
            this.uiPodaciOZivotinji.Text = "Podaci o životinji";
            // 
            // uiDatumRodenjaZivotinje
            // 
            this.uiDatumRodenjaZivotinje.AutoSize = true;
            this.uiDatumRodenjaZivotinje.Location = new System.Drawing.Point(35, 182);
            this.uiDatumRodenjaZivotinje.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.uiDatumRodenjaZivotinje.Name = "uiDatumRodenjaZivotinje";
            this.uiDatumRodenjaZivotinje.Size = new System.Drawing.Size(109, 17);
            this.uiDatumRodenjaZivotinje.TabIndex = 3;
            this.uiDatumRodenjaZivotinje.Text = "Datum rođenja: ";
            // 
            // uiVrstaZivotinje
            // 
            this.uiVrstaZivotinje.AutoSize = true;
            this.uiVrstaZivotinje.Location = new System.Drawing.Point(33, 134);
            this.uiVrstaZivotinje.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.uiVrstaZivotinje.Name = "uiVrstaZivotinje";
            this.uiVrstaZivotinje.Size = new System.Drawing.Size(49, 17);
            this.uiVrstaZivotinje.TabIndex = 2;
            this.uiVrstaZivotinje.Text = "Vrsta: ";
            // 
            // uiImeZivotinje
            // 
            this.uiImeZivotinje.AutoSize = true;
            this.uiImeZivotinje.Location = new System.Drawing.Point(32, 87);
            this.uiImeZivotinje.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.uiImeZivotinje.Name = "uiImeZivotinje";
            this.uiImeZivotinje.Size = new System.Drawing.Size(38, 17);
            this.uiImeZivotinje.TabIndex = 1;
            this.uiImeZivotinje.Text = "Ime: ";
            // 
            // uiVlasnikZivotinje
            // 
            this.uiVlasnikZivotinje.AutoSize = true;
            this.uiVlasnikZivotinje.Location = new System.Drawing.Point(32, 43);
            this.uiVlasnikZivotinje.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.uiVlasnikZivotinje.Name = "uiVlasnikZivotinje";
            this.uiVlasnikZivotinje.Size = new System.Drawing.Size(61, 17);
            this.uiVlasnikZivotinje.TabIndex = 0;
            this.uiVlasnikZivotinje.Text = "Vlasnik: ";
            // 
            // uiSimptomi
            // 
            this.uiSimptomi.Location = new System.Drawing.Point(144, 273);
            this.uiSimptomi.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.uiSimptomi.Multiline = true;
            this.uiSimptomi.Name = "uiSimptomi";
            this.uiSimptomi.Size = new System.Drawing.Size(340, 84);
            this.uiSimptomi.TabIndex = 1;
            // 
            // uiTerapija
            // 
            this.uiTerapija.Location = new System.Drawing.Point(143, 379);
            this.uiTerapija.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.uiTerapija.Multiline = true;
            this.uiTerapija.Name = "uiTerapija";
            this.uiTerapija.Size = new System.Drawing.Size(340, 84);
            this.uiTerapija.TabIndex = 2;
            // 
            // uiNapomena
            // 
            this.uiNapomena.Location = new System.Drawing.Point(144, 485);
            this.uiNapomena.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.uiNapomena.Multiline = true;
            this.uiNapomena.Name = "uiNapomena";
            this.uiNapomena.Size = new System.Drawing.Size(340, 84);
            this.uiNapomena.TabIndex = 3;
            // 
            // uiNaslovSimptomi
            // 
            this.uiNaslovSimptomi.AutoSize = true;
            this.uiNaslovSimptomi.Location = new System.Drawing.Point(60, 274);
            this.uiNaslovSimptomi.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.uiNaslovSimptomi.Name = "uiNaslovSimptomi";
            this.uiNaslovSimptomi.Size = new System.Drawing.Size(69, 17);
            this.uiNaslovSimptomi.TabIndex = 4;
            this.uiNaslovSimptomi.Text = "Simptomi:";
            // 
            // uiNaslovTerapija
            // 
            this.uiNaslovTerapija.AutoSize = true;
            this.uiNaslovTerapija.Location = new System.Drawing.Point(61, 384);
            this.uiNaslovTerapija.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.uiNaslovTerapija.Name = "uiNaslovTerapija";
            this.uiNaslovTerapija.Size = new System.Drawing.Size(64, 17);
            this.uiNaslovTerapija.TabIndex = 5;
            this.uiNaslovTerapija.Text = "Terapija:";
            // 
            // uiNaslovNapomena
            // 
            this.uiNaslovNapomena.AutoSize = true;
            this.uiNaslovNapomena.Location = new System.Drawing.Point(57, 489);
            this.uiNaslovNapomena.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.uiNaslovNapomena.Name = "uiNaslovNapomena";
            this.uiNaslovNapomena.Size = new System.Drawing.Size(81, 17);
            this.uiNaslovNapomena.TabIndex = 6;
            this.uiNaslovNapomena.Text = "Napomena:";
            // 
            // uiActionOdaberiLijek
            // 
            this.uiActionOdaberiLijek.DataSource = this.lijekBindingSource;
            this.uiActionOdaberiLijek.DisplayMember = "naziv";
            this.uiActionOdaberiLijek.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.uiActionOdaberiLijek.FormattingEnabled = true;
            this.uiActionOdaberiLijek.Location = new System.Drawing.Point(343, 52);
            this.uiActionOdaberiLijek.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.uiActionOdaberiLijek.Name = "uiActionOdaberiLijek";
            this.uiActionOdaberiLijek.Size = new System.Drawing.Size(160, 24);
            this.uiActionOdaberiLijek.TabIndex = 7;
            this.uiActionOdaberiLijek.ValueMember = "ID_lijek";
            this.uiActionOdaberiLijek.SelectedIndexChanged += new System.EventHandler(this.uiActionOdaberiLijek_SelectedIndexChanged);
            // 
            // lijekBindingSource
            // 
            this.lijekBindingSource.DataSource = typeof(PI_t18024_Maza.Lijek);
            // 
            // uiNapomenaLijekUnos
            // 
            this.uiNapomenaLijekUnos.Location = new System.Drawing.Point(345, 108);
            this.uiNapomenaLijekUnos.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.uiNapomenaLijekUnos.Multiline = true;
            this.uiNapomenaLijekUnos.Name = "uiNapomenaLijekUnos";
            this.uiNapomenaLijekUnos.Size = new System.Drawing.Size(157, 85);
            this.uiNapomenaLijekUnos.TabIndex = 8;
            // 
            // uiActionDodajLijek
            // 
            this.uiActionDodajLijek.Location = new System.Drawing.Point(376, 201);
            this.uiActionDodajLijek.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.uiActionDodajLijek.Name = "uiActionDodajLijek";
            this.uiActionDodajLijek.Size = new System.Drawing.Size(100, 28);
            this.uiActionDodajLijek.TabIndex = 9;
            this.uiActionDodajLijek.Text = "Dodaj lijek";
            this.uiActionDodajLijek.UseVisualStyleBackColor = true;
            this.uiActionDodajLijek.Click += new System.EventHandler(this.uiActionDodajLijek_Click);
            // 
            // uiPropisaniLijekovi
            // 
            this.uiPropisaniLijekovi.FormattingEnabled = true;
            this.uiPropisaniLijekovi.ItemHeight = 16;
            this.uiPropisaniLijekovi.Location = new System.Drawing.Point(585, 50);
            this.uiPropisaniLijekovi.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.uiPropisaniLijekovi.Name = "uiPropisaniLijekovi";
            this.uiPropisaniLijekovi.Size = new System.Drawing.Size(159, 148);
            this.uiPropisaniLijekovi.TabIndex = 10;
            this.uiPropisaniLijekovi.SelectedIndexChanged += new System.EventHandler(this.uiPropisaniLijekovi_SelectedIndexChanged);
            // 
            // uiActionObrisiLijek
            // 
            this.uiActionObrisiLijek.Location = new System.Drawing.Point(619, 199);
            this.uiActionObrisiLijek.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.uiActionObrisiLijek.Name = "uiActionObrisiLijek";
            this.uiActionObrisiLijek.Size = new System.Drawing.Size(100, 28);
            this.uiActionObrisiLijek.TabIndex = 11;
            this.uiActionObrisiLijek.Text = "Obrisi lijek";
            this.uiActionObrisiLijek.UseVisualStyleBackColor = true;
            this.uiActionObrisiLijek.Click += new System.EventHandler(this.uiActionObrisiLijek_Click);
            // 
            // uiNaslovLijekovi
            // 
            this.uiNaslovLijekovi.AutoSize = true;
            this.uiNaslovLijekovi.Location = new System.Drawing.Point(347, 30);
            this.uiNaslovLijekovi.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.uiNaslovLijekovi.Name = "uiNaslovLijekovi";
            this.uiNaslovLijekovi.Size = new System.Drawing.Size(55, 17);
            this.uiNaslovLijekovi.TabIndex = 12;
            this.uiNaslovLijekovi.Text = "Lijekovi";
            // 
            // uiNaslovNapomenaLijeka
            // 
            this.uiNaslovNapomenaLijeka.AutoSize = true;
            this.uiNaslovNapomenaLijeka.Location = new System.Drawing.Point(349, 87);
            this.uiNaslovNapomenaLijeka.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.uiNaslovNapomenaLijeka.Name = "uiNaslovNapomenaLijeka";
            this.uiNaslovNapomenaLijeka.Size = new System.Drawing.Size(77, 17);
            this.uiNaslovNapomenaLijeka.TabIndex = 13;
            this.uiNaslovNapomenaLijeka.Text = "Napomena";
            // 
            // uiNaslovPropisaniLijekovi
            // 
            this.uiNaslovPropisaniLijekovi.AutoSize = true;
            this.uiNaslovPropisaniLijekovi.Location = new System.Drawing.Point(589, 30);
            this.uiNaslovPropisaniLijekovi.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.uiNaslovPropisaniLijekovi.Name = "uiNaslovPropisaniLijekovi";
            this.uiNaslovPropisaniLijekovi.Size = new System.Drawing.Size(113, 17);
            this.uiNaslovPropisaniLijekovi.TabIndex = 14;
            this.uiNaslovPropisaniLijekovi.Text = "Propisani lijekovi";
            // 
            // uiActionDodajDijagnozu
            // 
            this.uiActionDodajDijagnozu.Location = new System.Drawing.Point(211, 628);
            this.uiActionDodajDijagnozu.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.uiActionDodajDijagnozu.Name = "uiActionDodajDijagnozu";
            this.uiActionDodajDijagnozu.Size = new System.Drawing.Size(145, 27);
            this.uiActionDodajDijagnozu.TabIndex = 15;
            this.uiActionDodajDijagnozu.Text = "Dodaj dijagnozu";
            this.uiActionDodajDijagnozu.UseVisualStyleBackColor = true;
            this.uiActionDodajDijagnozu.Click += new System.EventHandler(this.uiActionDodajDijagnozu_Click);
            // 
            // uiActionOdustani
            // 
            this.uiActionOdustani.Location = new System.Drawing.Point(400, 626);
            this.uiActionOdustani.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.uiActionOdustani.Name = "uiActionOdustani";
            this.uiActionOdustani.Size = new System.Drawing.Size(100, 28);
            this.uiActionOdustani.TabIndex = 16;
            this.uiActionOdustani.Text = "Odustani";
            this.uiActionOdustani.UseVisualStyleBackColor = true;
            this.uiActionOdustani.Click += new System.EventHandler(this.uiActionOdustani_Click);
            // 
            // uiActionOdaberiBolest
            // 
            this.uiActionOdaberiBolest.DataSource = this.bolestBindingSource;
            this.uiActionOdaberiBolest.DisplayMember = "naziv";
            this.uiActionOdaberiBolest.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.uiActionOdaberiBolest.FormattingEnabled = true;
            this.uiActionOdaberiBolest.Location = new System.Drawing.Point(585, 335);
            this.uiActionOdaberiBolest.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.uiActionOdaberiBolest.Name = "uiActionOdaberiBolest";
            this.uiActionOdaberiBolest.Size = new System.Drawing.Size(160, 24);
            this.uiActionOdaberiBolest.TabIndex = 17;
            this.uiActionOdaberiBolest.ValueMember = "ID_bolest";
            // 
            // bolestBindingSource
            // 
            this.bolestBindingSource.DataSource = typeof(PI_t18024_Maza.Bolest);
            // 
            // uiBolest
            // 
            this.uiBolest.AutoSize = true;
            this.uiBolest.Location = new System.Drawing.Point(587, 313);
            this.uiBolest.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.uiBolest.Name = "uiBolest";
            this.uiBolest.Size = new System.Drawing.Size(47, 17);
            this.uiBolest.TabIndex = 18;
            this.uiBolest.Text = "Bolest";
            // 
            // frmDodajDijagnozu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(779, 692);
            this.Controls.Add(this.uiBolest);
            this.Controls.Add(this.uiActionOdaberiBolest);
            this.Controls.Add(this.uiActionOdustani);
            this.Controls.Add(this.uiActionDodajDijagnozu);
            this.Controls.Add(this.uiNaslovPropisaniLijekovi);
            this.Controls.Add(this.uiNaslovNapomenaLijeka);
            this.Controls.Add(this.uiNaslovLijekovi);
            this.Controls.Add(this.uiActionObrisiLijek);
            this.Controls.Add(this.uiPropisaniLijekovi);
            this.Controls.Add(this.uiActionDodajLijek);
            this.Controls.Add(this.uiNapomenaLijekUnos);
            this.Controls.Add(this.uiActionOdaberiLijek);
            this.Controls.Add(this.uiNaslovNapomena);
            this.Controls.Add(this.uiNaslovTerapija);
            this.Controls.Add(this.uiNaslovSimptomi);
            this.Controls.Add(this.uiNapomena);
            this.Controls.Add(this.uiTerapija);
            this.Controls.Add(this.uiSimptomi);
            this.Controls.Add(this.uiPodaciOZivotinji);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmDodajDijagnozu";
            this.Text = "Dijagnoza";
            this.Load += new System.EventHandler(this.frmDodajDijagnozu_Load);
            this.uiPodaciOZivotinji.ResumeLayout(false);
            this.uiPodaciOZivotinji.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lijekBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bolestBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox uiPodaciOZivotinji;
        private System.Windows.Forms.Label uiDatumRodenjaZivotinje;
        private System.Windows.Forms.Label uiVrstaZivotinje;
        private System.Windows.Forms.Label uiImeZivotinje;
        private System.Windows.Forms.Label uiVlasnikZivotinje;
        private System.Windows.Forms.TextBox uiSimptomi;
        private System.Windows.Forms.TextBox uiTerapija;
        private System.Windows.Forms.TextBox uiNapomena;
        private System.Windows.Forms.Label uiNaslovSimptomi;
        private System.Windows.Forms.Label uiNaslovTerapija;
        private System.Windows.Forms.Label uiNaslovNapomena;
        private System.Windows.Forms.ComboBox uiActionOdaberiLijek;
        private System.Windows.Forms.TextBox uiNapomenaLijekUnos;
        private System.Windows.Forms.Button uiActionDodajLijek;
        private System.Windows.Forms.ListBox uiPropisaniLijekovi;
        private System.Windows.Forms.Button uiActionObrisiLijek;
        private System.Windows.Forms.Label uiNaslovLijekovi;
        private System.Windows.Forms.Label uiNaslovNapomenaLijeka;
        private System.Windows.Forms.Label uiNaslovPropisaniLijekovi;
        private System.Windows.Forms.Button uiActionDodajDijagnozu;
        private System.Windows.Forms.Button uiActionOdustani;
        private System.Windows.Forms.BindingSource lijekBindingSource;
        private System.Windows.Forms.ComboBox uiActionOdaberiBolest;
        private System.Windows.Forms.BindingSource bolestBindingSource;
        private System.Windows.Forms.Label uiBolest;
        private System.Windows.Forms.HelpProvider korisnickaPodrska;
    }
}