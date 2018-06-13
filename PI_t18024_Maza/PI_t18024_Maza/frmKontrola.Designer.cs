namespace PI_t18024_Maza
{
    partial class frmKontrola
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.uiPrikazKontrola = new System.Windows.Forms.DataGridView();
            this.uiActonDodajKontrolu = new System.Windows.Forms.Button();
            this.uiActionAzurirajKontrolu = new System.Windows.Forms.Button();
            this.uiActionDetaljiKontrole = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.uiPrikazKontrola)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(162, 344);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(5, 81);
            this.panel1.TabIndex = 17;
            // 
            // uiPrikazKontrola
            // 
            this.uiPrikazKontrola.AllowUserToAddRows = false;
            this.uiPrikazKontrola.AllowUserToDeleteRows = false;
            this.uiPrikazKontrola.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.uiPrikazKontrola.Location = new System.Drawing.Point(163, 86);
            this.uiPrikazKontrola.Name = "uiPrikazKontrola";
            this.uiPrikazKontrola.ReadOnly = true;
            this.uiPrikazKontrola.RowHeadersVisible = false;
            this.uiPrikazKontrola.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.uiPrikazKontrola.Size = new System.Drawing.Size(520, 418);
            this.uiPrikazKontrola.TabIndex = 18;
            // 
            // uiActonDodajKontrolu
            // 
            this.uiActonDodajKontrolu.Location = new System.Drawing.Point(757, 148);
            this.uiActonDodajKontrolu.Name = "uiActonDodajKontrolu";
            this.uiActonDodajKontrolu.Size = new System.Drawing.Size(114, 23);
            this.uiActonDodajKontrolu.TabIndex = 19;
            this.uiActonDodajKontrolu.Text = "Dodaj kontrolu";
            this.uiActonDodajKontrolu.UseVisualStyleBackColor = true;
            this.uiActonDodajKontrolu.Click += new System.EventHandler(this.uiActonDodajKontrolu_Click);
            // 
            // uiActionAzurirajKontrolu
            // 
            this.uiActionAzurirajKontrolu.Location = new System.Drawing.Point(757, 194);
            this.uiActionAzurirajKontrolu.Name = "uiActionAzurirajKontrolu";
            this.uiActionAzurirajKontrolu.Size = new System.Drawing.Size(114, 23);
            this.uiActionAzurirajKontrolu.TabIndex = 20;
            this.uiActionAzurirajKontrolu.Text = "Ažuriraj kontrolu";
            this.uiActionAzurirajKontrolu.UseVisualStyleBackColor = true;
            // 
            // uiActionDetaljiKontrole
            // 
            this.uiActionDetaljiKontrole.Location = new System.Drawing.Point(757, 245);
            this.uiActionDetaljiKontrole.Name = "uiActionDetaljiKontrole";
            this.uiActionDetaljiKontrole.Size = new System.Drawing.Size(114, 23);
            this.uiActionDetaljiKontrole.TabIndex = 21;
            this.uiActionDetaljiKontrole.Text = "Detalji kontole";
            this.uiActionDetaljiKontrole.UseVisualStyleBackColor = true;
            // 
            // frmKontrola
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1075, 632);
            this.Controls.Add(this.uiActionDetaljiKontrole);
            this.Controls.Add(this.uiActionAzurirajKontrolu);
            this.Controls.Add(this.uiActonDodajKontrolu);
            this.Controls.Add(this.uiPrikazKontrola);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(3);
            this.Name = "frmKontrola";
            this.Text = "Kontrola";
            this.Load += new System.EventHandler(this.KontrolaForm_Load);
            this.Controls.SetChildIndex(this.panel1, 0);
            this.Controls.SetChildIndex(this.uiPrikazKontrola, 0);
            this.Controls.SetChildIndex(this.uiActonDodajKontrolu, 0);
            this.Controls.SetChildIndex(this.uiActionAzurirajKontrolu, 0);
            this.Controls.SetChildIndex(this.uiActionDetaljiKontrole, 0);
            ((System.ComponentModel.ISupportInitialize)(this.uiPrikazKontrola)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView uiPrikazKontrola;
        private System.Windows.Forms.Button uiActonDodajKontrolu;
        private System.Windows.Forms.Button uiActionAzurirajKontrolu;
        private System.Windows.Forms.Button uiActionDetaljiKontrole;
    }
}