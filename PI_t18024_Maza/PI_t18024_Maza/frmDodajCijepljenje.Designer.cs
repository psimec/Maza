namespace PI_t18024_Maza
{
    partial class frmDodajCijepljenje
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
            this.uiImeCjepiva = new System.Windows.Forms.Label();
            this.uiDozaCjepiva = new System.Windows.Forms.Label();
            this.uiProizvodac = new System.Windows.Forms.Label();
            this.uiRokTrajanja = new System.Windows.Forms.Label();
            this.uiCijenaCjepiva = new System.Windows.Forms.Label();
            this.uiOdabirCjepiva = new System.Windows.Forms.ComboBox();
            this.cjepivoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.uiActionDodajCjepivo = new System.Windows.Forms.Button();
            this.uiActionOdustani = new System.Windows.Forms.Button();
            this.uiPodaciOZivotinji.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cjepivoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // uiPodaciOZivotinji
            // 
            this.uiPodaciOZivotinji.Controls.Add(this.uiDatumRodenjaZivotinje);
            this.uiPodaciOZivotinji.Controls.Add(this.uiVrstaZivotinje);
            this.uiPodaciOZivotinji.Controls.Add(this.uiImeZivotinje);
            this.uiPodaciOZivotinji.Controls.Add(this.uiVlasnikZivotinje);
            this.uiPodaciOZivotinji.Location = new System.Drawing.Point(24, 14);
            this.uiPodaciOZivotinji.Name = "uiPodaciOZivotinji";
            this.uiPodaciOZivotinji.Size = new System.Drawing.Size(223, 177);
            this.uiPodaciOZivotinji.TabIndex = 1;
            this.uiPodaciOZivotinji.TabStop = false;
            this.uiPodaciOZivotinji.Text = "Podaci o životinji";
            // 
            // uiDatumRodenjaZivotinje
            // 
            this.uiDatumRodenjaZivotinje.AutoSize = true;
            this.uiDatumRodenjaZivotinje.Location = new System.Drawing.Point(26, 148);
            this.uiDatumRodenjaZivotinje.Name = "uiDatumRodenjaZivotinje";
            this.uiDatumRodenjaZivotinje.Size = new System.Drawing.Size(83, 13);
            this.uiDatumRodenjaZivotinje.TabIndex = 3;
            this.uiDatumRodenjaZivotinje.Text = "Datum rođenja: ";
            // 
            // uiVrstaZivotinje
            // 
            this.uiVrstaZivotinje.AutoSize = true;
            this.uiVrstaZivotinje.Location = new System.Drawing.Point(25, 109);
            this.uiVrstaZivotinje.Name = "uiVrstaZivotinje";
            this.uiVrstaZivotinje.Size = new System.Drawing.Size(37, 13);
            this.uiVrstaZivotinje.TabIndex = 2;
            this.uiVrstaZivotinje.Text = "Vrsta: ";
            // 
            // uiImeZivotinje
            // 
            this.uiImeZivotinje.AutoSize = true;
            this.uiImeZivotinje.Location = new System.Drawing.Point(24, 71);
            this.uiImeZivotinje.Name = "uiImeZivotinje";
            this.uiImeZivotinje.Size = new System.Drawing.Size(30, 13);
            this.uiImeZivotinje.TabIndex = 1;
            this.uiImeZivotinje.Text = "Ime: ";
            // 
            // uiVlasnikZivotinje
            // 
            this.uiVlasnikZivotinje.AutoSize = true;
            this.uiVlasnikZivotinje.Location = new System.Drawing.Point(24, 35);
            this.uiVlasnikZivotinje.Name = "uiVlasnikZivotinje";
            this.uiVlasnikZivotinje.Size = new System.Drawing.Size(47, 13);
            this.uiVlasnikZivotinje.TabIndex = 0;
            this.uiVlasnikZivotinje.Text = "Vlasnik: ";
            // 
            // uiImeCjepiva
            // 
            this.uiImeCjepiva.AutoSize = true;
            this.uiImeCjepiva.Location = new System.Drawing.Point(59, 248);
            this.uiImeCjepiva.Name = "uiImeCjepiva";
            this.uiImeCjepiva.Size = new System.Drawing.Size(67, 13);
            this.uiImeCjepiva.TabIndex = 2;
            this.uiImeCjepiva.Text = "Ime cjepiva: ";
            // 
            // uiDozaCjepiva
            // 
            this.uiDozaCjepiva.AutoSize = true;
            this.uiDozaCjepiva.Location = new System.Drawing.Point(61, 304);
            this.uiDozaCjepiva.Name = "uiDozaCjepiva";
            this.uiDozaCjepiva.Size = new System.Drawing.Size(75, 13);
            this.uiDozaCjepiva.TabIndex = 3;
            this.uiDozaCjepiva.Text = "Doza cjepiva: ";
            // 
            // uiProizvodac
            // 
            this.uiProizvodac.AutoSize = true;
            this.uiProizvodac.Location = new System.Drawing.Point(64, 357);
            this.uiProizvodac.Name = "uiProizvodac";
            this.uiProizvodac.Size = new System.Drawing.Size(67, 13);
            this.uiProizvodac.TabIndex = 4;
            this.uiProizvodac.Text = "Proizvođač: ";
            // 
            // uiRokTrajanja
            // 
            this.uiRokTrajanja.AutoSize = true;
            this.uiRokTrajanja.Location = new System.Drawing.Point(62, 403);
            this.uiRokTrajanja.Name = "uiRokTrajanja";
            this.uiRokTrajanja.Size = new System.Drawing.Size(70, 13);
            this.uiRokTrajanja.TabIndex = 5;
            this.uiRokTrajanja.Text = "Rok trajanja: ";
            // 
            // uiCijenaCjepiva
            // 
            this.uiCijenaCjepiva.AutoSize = true;
            this.uiCijenaCjepiva.Location = new System.Drawing.Point(69, 455);
            this.uiCijenaCjepiva.Name = "uiCijenaCjepiva";
            this.uiCijenaCjepiva.Size = new System.Drawing.Size(79, 13);
            this.uiCijenaCjepiva.TabIndex = 6;
            this.uiCijenaCjepiva.Text = "Cijena cjepiva: ";
            // 
            // uiOdabirCjepiva
            // 
            this.uiOdabirCjepiva.DataSource = this.cjepivoBindingSource;
            this.uiOdabirCjepiva.DisplayMember = "ime_cjepiva";
            this.uiOdabirCjepiva.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.uiOdabirCjepiva.FormattingEnabled = true;
            this.uiOdabirCjepiva.Location = new System.Drawing.Point(317, 77);
            this.uiOdabirCjepiva.Name = "uiOdabirCjepiva";
            this.uiOdabirCjepiva.Size = new System.Drawing.Size(121, 21);
            this.uiOdabirCjepiva.TabIndex = 7;
            this.uiOdabirCjepiva.ValueMember = "ID_cjepiva";
            this.uiOdabirCjepiva.SelectedIndexChanged += new System.EventHandler(this.uiOdabirCjepiva_SelectedIndexChanged);
            // 
            // uiActionDodajCjepivo
            // 
            this.uiActionDodajCjepivo.Location = new System.Drawing.Point(329, 463);
            this.uiActionDodajCjepivo.Name = "uiActionDodajCjepivo";
            this.uiActionDodajCjepivo.Size = new System.Drawing.Size(87, 23);
            this.uiActionDodajCjepivo.TabIndex = 8;
            this.uiActionDodajCjepivo.Text = "Dodaj cjepivo";
            this.uiActionDodajCjepivo.UseVisualStyleBackColor = true;
            // 
            // uiActionOdustani
            // 
            this.uiActionOdustani.Location = new System.Drawing.Point(434, 463);
            this.uiActionOdustani.Name = "uiActionOdustani";
            this.uiActionOdustani.Size = new System.Drawing.Size(75, 23);
            this.uiActionOdustani.TabIndex = 9;
            this.uiActionOdustani.Text = "Odustani";
            this.uiActionOdustani.UseVisualStyleBackColor = true;
            // 
            // frmDodajCijepljenje
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(521, 508);
            this.Controls.Add(this.uiActionOdustani);
            this.Controls.Add(this.uiActionDodajCjepivo);
            this.Controls.Add(this.uiOdabirCjepiva);
            this.Controls.Add(this.uiCijenaCjepiva);
            this.Controls.Add(this.uiRokTrajanja);
            this.Controls.Add(this.uiProizvodac);
            this.Controls.Add(this.uiDozaCjepiva);
            this.Controls.Add(this.uiImeCjepiva);
            this.Controls.Add(this.uiPodaciOZivotinji);
            this.Name = "frmDodajCijepljenje";
            this.Text = "frmDodajCijepljenje";
            this.Load += new System.EventHandler(this.frmDodajCijepljenje_Load);
            this.uiPodaciOZivotinji.ResumeLayout(false);
            this.uiPodaciOZivotinji.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cjepivoBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox uiPodaciOZivotinji;
        private System.Windows.Forms.Label uiDatumRodenjaZivotinje;
        private System.Windows.Forms.Label uiVrstaZivotinje;
        private System.Windows.Forms.Label uiImeZivotinje;
        private System.Windows.Forms.Label uiVlasnikZivotinje;
        private System.Windows.Forms.Label uiImeCjepiva;
        private System.Windows.Forms.Label uiDozaCjepiva;
        private System.Windows.Forms.Label uiProizvodac;
        private System.Windows.Forms.Label uiRokTrajanja;
        private System.Windows.Forms.Label uiCijenaCjepiva;
        private System.Windows.Forms.ComboBox uiOdabirCjepiva;
        private System.Windows.Forms.BindingSource cjepivoBindingSource;
        private System.Windows.Forms.Button uiActionDodajCjepivo;
        private System.Windows.Forms.Button uiActionOdustani;
    }
}