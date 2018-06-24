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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmKontrola));
            this.panel1 = new System.Windows.Forms.Panel();
            this.uiPrikazKontrola = new System.Windows.Forms.DataGridView();
            this.iDkontrolaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.zivotinjaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.veterinarDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.opisDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datumkontroleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.viewKontrolaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.uiActonDodajKontrolu = new System.Windows.Forms.Button();
            this.uiActionAzurirajKontrolu = new System.Windows.Forms.Button();
            this.uiActionDetaljiKontrole = new System.Windows.Forms.Button();
            this.uiPretrazi = new System.Windows.Forms.TextBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.uiPrikazKontrola)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewKontrolaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
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
            this.uiPrikazKontrola.AutoGenerateColumns = false;
            this.uiPrikazKontrola.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(212)))), ((int)(((byte)(249)))));
            this.uiPrikazKontrola.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.uiPrikazKontrola.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.uiPrikazKontrola.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDkontrolaDataGridViewTextBoxColumn,
            this.zivotinjaDataGridViewTextBoxColumn,
            this.veterinarDataGridViewTextBoxColumn,
            this.opisDataGridViewTextBoxColumn,
            this.statusDataGridViewTextBoxColumn,
            this.datumkontroleDataGridViewTextBoxColumn});
            this.uiPrikazKontrola.DataSource = this.viewKontrolaBindingSource;
            this.uiPrikazKontrola.Location = new System.Drawing.Point(172, 130);
            this.uiPrikazKontrola.Name = "uiPrikazKontrola";
            this.uiPrikazKontrola.ReadOnly = true;
            this.uiPrikazKontrola.RowHeadersVisible = false;
            this.uiPrikazKontrola.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.uiPrikazKontrola.Size = new System.Drawing.Size(523, 418);
            this.uiPrikazKontrola.TabIndex = 18;
            this.uiPrikazKontrola.ColumnHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.uiPrikazKontrola_ColumnHeaderMouseClick);
            this.uiPrikazKontrola.SelectionChanged += new System.EventHandler(this.uiPrikazKontrola_SelectionChanged);
            // 
            // iDkontrolaDataGridViewTextBoxColumn
            // 
            this.iDkontrolaDataGridViewTextBoxColumn.DataPropertyName = "ID_kontrola";
            this.iDkontrolaDataGridViewTextBoxColumn.HeaderText = "ID_kontrola";
            this.iDkontrolaDataGridViewTextBoxColumn.Name = "iDkontrolaDataGridViewTextBoxColumn";
            this.iDkontrolaDataGridViewTextBoxColumn.ReadOnly = true;
            this.iDkontrolaDataGridViewTextBoxColumn.Visible = false;
            // 
            // zivotinjaDataGridViewTextBoxColumn
            // 
            this.zivotinjaDataGridViewTextBoxColumn.DataPropertyName = "zivotinja";
            this.zivotinjaDataGridViewTextBoxColumn.HeaderText = "Životinja";
            this.zivotinjaDataGridViewTextBoxColumn.Name = "zivotinjaDataGridViewTextBoxColumn";
            this.zivotinjaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // veterinarDataGridViewTextBoxColumn
            // 
            this.veterinarDataGridViewTextBoxColumn.DataPropertyName = "veterinar";
            this.veterinarDataGridViewTextBoxColumn.HeaderText = "Veterinar";
            this.veterinarDataGridViewTextBoxColumn.Name = "veterinarDataGridViewTextBoxColumn";
            this.veterinarDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // opisDataGridViewTextBoxColumn
            // 
            this.opisDataGridViewTextBoxColumn.DataPropertyName = "opis";
            this.opisDataGridViewTextBoxColumn.HeaderText = "Opis";
            this.opisDataGridViewTextBoxColumn.Name = "opisDataGridViewTextBoxColumn";
            this.opisDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // statusDataGridViewTextBoxColumn
            // 
            this.statusDataGridViewTextBoxColumn.DataPropertyName = "status";
            this.statusDataGridViewTextBoxColumn.HeaderText = "Status";
            this.statusDataGridViewTextBoxColumn.Name = "statusDataGridViewTextBoxColumn";
            this.statusDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // datumkontroleDataGridViewTextBoxColumn
            // 
            this.datumkontroleDataGridViewTextBoxColumn.DataPropertyName = "datum_kontrole";
            this.datumkontroleDataGridViewTextBoxColumn.HeaderText = "Datum";
            this.datumkontroleDataGridViewTextBoxColumn.Name = "datumkontroleDataGridViewTextBoxColumn";
            this.datumkontroleDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // viewKontrolaBindingSource
            // 
            this.viewKontrolaBindingSource.DataSource = typeof(PI_t18024_Maza.viewKontrola);
            // 
            // uiActonDodajKontrolu
            // 
            this.uiActonDodajKontrolu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(140)))), ((int)(((byte)(200)))));
            this.uiActonDodajKontrolu.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.uiActonDodajKontrolu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.uiActonDodajKontrolu.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.uiActonDodajKontrolu.Location = new System.Drawing.Point(757, 124);
            this.uiActonDodajKontrolu.Name = "uiActonDodajKontrolu";
            this.uiActonDodajKontrolu.Size = new System.Drawing.Size(144, 49);
            this.uiActonDodajKontrolu.TabIndex = 19;
            this.uiActonDodajKontrolu.Text = "Dodaj kontrolu";
            this.uiActonDodajKontrolu.UseVisualStyleBackColor = false;
            this.uiActonDodajKontrolu.Click += new System.EventHandler(this.uiActonDodajKontrolu_Click);
            // 
            // uiActionAzurirajKontrolu
            // 
            this.uiActionAzurirajKontrolu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(140)))), ((int)(((byte)(200)))));
            this.uiActionAzurirajKontrolu.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.uiActionAzurirajKontrolu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.uiActionAzurirajKontrolu.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.uiActionAzurirajKontrolu.Location = new System.Drawing.Point(757, 194);
            this.uiActionAzurirajKontrolu.Name = "uiActionAzurirajKontrolu";
            this.uiActionAzurirajKontrolu.Size = new System.Drawing.Size(144, 49);
            this.uiActionAzurirajKontrolu.TabIndex = 20;
            this.uiActionAzurirajKontrolu.Text = "Ažuriraj kontrolu";
            this.uiActionAzurirajKontrolu.UseVisualStyleBackColor = false;
            this.uiActionAzurirajKontrolu.Click += new System.EventHandler(this.uiActionAzurirajKontrolu_Click);
            // 
            // uiActionDetaljiKontrole
            // 
            this.uiActionDetaljiKontrole.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(140)))), ((int)(((byte)(200)))));
            this.uiActionDetaljiKontrole.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.uiActionDetaljiKontrole.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.uiActionDetaljiKontrole.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.uiActionDetaljiKontrole.Location = new System.Drawing.Point(757, 269);
            this.uiActionDetaljiKontrole.Name = "uiActionDetaljiKontrole";
            this.uiActionDetaljiKontrole.Size = new System.Drawing.Size(144, 49);
            this.uiActionDetaljiKontrole.TabIndex = 21;
            this.uiActionDetaljiKontrole.Text = "Detalji kontole";
            this.uiActionDetaljiKontrole.UseVisualStyleBackColor = false;
            this.uiActionDetaljiKontrole.Click += new System.EventHandler(this.uiActionDetaljiKontrole_Click);
            // 
            // uiPretrazi
            // 
            this.uiPretrazi.Location = new System.Drawing.Point(326, 95);
            this.uiPretrazi.Name = "uiPretrazi";
            this.uiPretrazi.Size = new System.Drawing.Size(162, 20);
            this.uiPretrazi.TabIndex = 22;
            this.uiPretrazi.TextChanged += new System.EventHandler(this.uiPretrazi_TextChanged);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.White;
            this.pictureBox2.Enabled = false;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(467, 97);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(17, 16);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 24;
            this.pictureBox2.TabStop = false;
            // 
            // frmKontrola
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 632);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.uiPretrazi);
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
            this.Controls.SetChildIndex(this.uiPretrazi, 0);
            this.Controls.SetChildIndex(this.pictureBox2, 0);
            ((System.ComponentModel.ISupportInitialize)(this.uiPrikazKontrola)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewKontrolaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView uiPrikazKontrola;
        private System.Windows.Forms.Button uiActonDodajKontrolu;
        private System.Windows.Forms.Button uiActionAzurirajKontrolu;
        private System.Windows.Forms.Button uiActionDetaljiKontrole;
        private System.Windows.Forms.TextBox uiPretrazi;
        private System.Windows.Forms.BindingSource viewKontrolaBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDkontrolaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn zivotinjaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn veterinarDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn opisDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn statusDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn datumkontroleDataGridViewTextBoxColumn;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}