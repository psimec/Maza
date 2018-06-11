namespace PI_t18024_Maza
{
    partial class DodajZivotinjuForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.uiIme = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.uiVrsta = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.uiBrojCipa = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.uiTezina = new System.Windows.Forms.TextBox();
            this.uiOdabirSpola = new System.Windows.Forms.ComboBox();
            this.uiDatumRodenja = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(54, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ime";
            // 
            // uiIme
            // 
            this.uiIme.Location = new System.Drawing.Point(108, 12);
            this.uiIme.Name = "uiIme";
            this.uiIme.Size = new System.Drawing.Size(352, 22);
            this.uiIme.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(48, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "Spol";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(43, 55);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 17);
            this.label3.TabIndex = 0;
            this.label3.Text = "Vrsta";
            // 
            // uiVrsta
            // 
            this.uiVrsta.Location = new System.Drawing.Point(108, 55);
            this.uiVrsta.Name = "uiVrsta";
            this.uiVrsta.Size = new System.Drawing.Size(87, 22);
            this.uiVrsta.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 193);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(101, 17);
            this.label4.TabIndex = 0;
            this.label4.Text = "Datum rođenja";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(227, 57);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 17);
            this.label5.TabIndex = 0;
            this.label5.Text = "Broj čipa";
            // 
            // uiBrojCipa
            // 
            this.uiBrojCipa.Location = new System.Drawing.Point(293, 55);
            this.uiBrojCipa.Name = "uiBrojCipa";
            this.uiBrojCipa.Size = new System.Drawing.Size(167, 22);
            this.uiBrojCipa.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(241, 97);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(51, 17);
            this.label6.TabIndex = 0;
            this.label6.Text = "Težina";
            // 
            // uiTezina
            // 
            this.uiTezina.Location = new System.Drawing.Point(293, 95);
            this.uiTezina.Name = "uiTezina";
            this.uiTezina.Size = new System.Drawing.Size(167, 22);
            this.uiTezina.TabIndex = 1;
            // 
            // uiOdabirSpola
            // 
            this.uiOdabirSpola.FormattingEnabled = true;
            this.uiOdabirSpola.Location = new System.Drawing.Point(112, 93);
            this.uiOdabirSpola.Name = "uiOdabirSpola";
            this.uiOdabirSpola.Size = new System.Drawing.Size(46, 24);
            this.uiOdabirSpola.TabIndex = 2;
            // 
            // uiDatumRodenja
            // 
            this.uiDatumRodenja.Location = new System.Drawing.Point(141, 188);
            this.uiDatumRodenja.Name = "uiDatumRodenja";
            this.uiDatumRodenja.Size = new System.Drawing.Size(176, 22);
            this.uiDatumRodenja.TabIndex = 3;
            // 
            // DodajZivotinjuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(472, 450);
            this.Controls.Add(this.uiDatumRodenja);
            this.Controls.Add(this.uiOdabirSpola);
            this.Controls.Add(this.uiTezina);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.uiBrojCipa);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.uiVrsta);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.uiIme);
            this.Controls.Add(this.label1);
            this.Name = "DodajZivotinjuForm";
            this.Text = "DodajZivotinjuForm";
            this.Load += new System.EventHandler(this.DodajZivotinjuForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox uiIme;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox uiVrsta;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox uiBrojCipa;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox uiTezina;
        private System.Windows.Forms.ComboBox uiOdabirSpola;
        private System.Windows.Forms.DateTimePicker uiDatumRodenja;
    }
}