namespace PI_t18024_Maza
{
    partial class frmNovaKontrola
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
            this.uiOdabirZivotinja = new System.Windows.Forms.ComboBox();
            this.uiOdabirVeterinar = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.uiOdabirDatum = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.uiUnosOpis = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.uiActionUredu = new System.Windows.Forms.Button();
            this.uiActionOdustani = new System.Windows.Forms.Button();
            this.uiOdabirStatusObavljen = new System.Windows.Forms.RadioButton();
            this.uiOdabirStatusNijeObavljen = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.uiOdabirVlasnik = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // uiOdabirZivotinja
            // 
            this.uiOdabirZivotinja.DisplayMember = "ID_zivotinja";
            this.uiOdabirZivotinja.FormattingEnabled = true;
            this.uiOdabirZivotinja.Location = new System.Drawing.Point(88, 53);
            this.uiOdabirZivotinja.Name = "uiOdabirZivotinja";
            this.uiOdabirZivotinja.Size = new System.Drawing.Size(211, 21);
            this.uiOdabirZivotinja.TabIndex = 1;
            this.uiOdabirZivotinja.ValueMember = "ID_zivotinja";
            // 
            // uiOdabirVeterinar
            // 
            this.uiOdabirVeterinar.FormattingEnabled = true;
            this.uiOdabirVeterinar.Location = new System.Drawing.Point(88, 90);
            this.uiOdabirVeterinar.Name = "uiOdabirVeterinar";
            this.uiOdabirVeterinar.Size = new System.Drawing.Size(211, 21);
            this.uiOdabirVeterinar.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Životinja";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Veterinar";
            // 
            // uiOdabirDatum
            // 
            this.uiOdabirDatum.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.uiOdabirDatum.Location = new System.Drawing.Point(88, 130);
            this.uiOdabirDatum.Name = "uiOdabirDatum";
            this.uiOdabirDatum.Size = new System.Drawing.Size(211, 20);
            this.uiOdabirDatum.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 133);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Datum";
            // 
            // uiUnosOpis
            // 
            this.uiUnosOpis.Location = new System.Drawing.Point(88, 201);
            this.uiUnosOpis.Multiline = true;
            this.uiUnosOpis.Name = "uiUnosOpis";
            this.uiUnosOpis.Size = new System.Drawing.Size(211, 128);
            this.uiUnosOpis.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(26, 204);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(28, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Opis";
            // 
            // uiActionUredu
            // 
            this.uiActionUredu.Location = new System.Drawing.Point(143, 335);
            this.uiActionUredu.Name = "uiActionUredu";
            this.uiActionUredu.Size = new System.Drawing.Size(75, 23);
            this.uiActionUredu.TabIndex = 10;
            this.uiActionUredu.Text = "Uredu";
            this.uiActionUredu.UseVisualStyleBackColor = true;
            this.uiActionUredu.Click += new System.EventHandler(this.uiActionUredu_Click);
            // 
            // uiActionOdustani
            // 
            this.uiActionOdustani.Location = new System.Drawing.Point(224, 335);
            this.uiActionOdustani.Name = "uiActionOdustani";
            this.uiActionOdustani.Size = new System.Drawing.Size(75, 23);
            this.uiActionOdustani.TabIndex = 11;
            this.uiActionOdustani.Text = "Odustani";
            this.uiActionOdustani.UseVisualStyleBackColor = true;
            this.uiActionOdustani.Click += new System.EventHandler(this.uiActionOdustani_Click);
            // 
            // uiOdabirStatusObavljen
            // 
            this.uiOdabirStatusObavljen.AutoSize = true;
            this.uiOdabirStatusObavljen.Location = new System.Drawing.Point(110, 166);
            this.uiOdabirStatusObavljen.Name = "uiOdabirStatusObavljen";
            this.uiOdabirStatusObavljen.Size = new System.Drawing.Size(65, 17);
            this.uiOdabirStatusObavljen.TabIndex = 7;
            this.uiOdabirStatusObavljen.TabStop = true;
            this.uiOdabirStatusObavljen.Text = "obavljen";
            this.uiOdabirStatusObavljen.UseVisualStyleBackColor = true;
            // 
            // uiOdabirStatusNijeObavljen
            // 
            this.uiOdabirStatusNijeObavljen.AutoSize = true;
            this.uiOdabirStatusNijeObavljen.Location = new System.Drawing.Point(201, 166);
            this.uiOdabirStatusNijeObavljen.Name = "uiOdabirStatusNijeObavljen";
            this.uiOdabirStatusNijeObavljen.Size = new System.Drawing.Size(84, 17);
            this.uiOdabirStatusNijeObavljen.TabIndex = 8;
            this.uiOdabirStatusNijeObavljen.TabStop = true;
            this.uiOdabirStatusNijeObavljen.Text = "nije obavljen";
            this.uiOdabirStatusNijeObavljen.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(25, 168);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "Status";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(25, 20);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 13);
            this.label6.TabIndex = 16;
            this.label6.Text = "Vlasnik";
            // 
            // uiOdabirVlasnik
            // 
            this.uiOdabirVlasnik.DisplayMember = "ID_zivotinja";
            this.uiOdabirVlasnik.FormattingEnabled = true;
            this.uiOdabirVlasnik.Location = new System.Drawing.Point(88, 17);
            this.uiOdabirVlasnik.Name = "uiOdabirVlasnik";
            this.uiOdabirVlasnik.Size = new System.Drawing.Size(211, 21);
            this.uiOdabirVlasnik.TabIndex = 15;
            this.uiOdabirVlasnik.ValueMember = "ID_zivotinja";
            this.uiOdabirVlasnik.SelectedIndexChanged += new System.EventHandler(this.uiOdabirVlasnik_SelectedIndexChanged);
            // 
            // frmNovaKontrola
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(328, 370);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.uiOdabirVlasnik);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.uiOdabirStatusNijeObavljen);
            this.Controls.Add(this.uiOdabirStatusObavljen);
            this.Controls.Add(this.uiActionOdustani);
            this.Controls.Add(this.uiActionUredu);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.uiUnosOpis);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.uiOdabirDatum);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.uiOdabirVeterinar);
            this.Controls.Add(this.uiOdabirZivotinja);
            this.Name = "frmNovaKontrola";
            this.Load += new System.EventHandler(this.NovaKontrola_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox uiOdabirZivotinja;
        private System.Windows.Forms.ComboBox uiOdabirVeterinar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker uiOdabirDatum;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox uiUnosOpis;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button uiActionUredu;
        private System.Windows.Forms.Button uiActionOdustani;
        private System.Windows.Forms.RadioButton uiOdabirStatusObavljen;
        private System.Windows.Forms.RadioButton uiOdabirStatusNijeObavljen;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox uiOdabirVlasnik;
    }
}