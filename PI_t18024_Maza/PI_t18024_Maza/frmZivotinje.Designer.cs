namespace PI_t18024_Maza
{
    partial class frmZivotinje
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmZivotinje));
            this.panel1 = new System.Windows.Forms.Panel();
            this.uiPrikazZivotinja = new System.Windows.Forms.DataGridView();
            this.uiActionDodajZivotinju = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.uiFiltrirajZivotinje = new System.Windows.Forms.TextBox();
            this.viewPrikazZivotinjaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.zivotinjaIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.imeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.spolDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vrstaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datumRođenjaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.brojČipaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.težinaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datumUginućaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.imeVlasnikaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prezimeVlasnikaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.uiPrikazZivotinja)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewPrikazZivotinjaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(216, 212);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(7, 100);
            this.panel1.TabIndex = 3;
            // 
            // uiPrikazZivotinja
            // 
            this.uiPrikazZivotinja.AllowUserToAddRows = false;
            this.uiPrikazZivotinja.AllowUserToDeleteRows = false;
            this.uiPrikazZivotinja.AllowUserToResizeColumns = false;
            this.uiPrikazZivotinja.AllowUserToResizeRows = false;
            this.uiPrikazZivotinja.AutoGenerateColumns = false;
            this.uiPrikazZivotinja.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.uiPrikazZivotinja.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(212)))), ((int)(((byte)(249)))));
            this.uiPrikazZivotinja.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.uiPrikazZivotinja.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.uiPrikazZivotinja.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.uiPrikazZivotinja.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.zivotinjaIDDataGridViewTextBoxColumn,
            this.imeDataGridViewTextBoxColumn,
            this.spolDataGridViewTextBoxColumn,
            this.vrstaDataGridViewTextBoxColumn,
            this.datumRođenjaDataGridViewTextBoxColumn,
            this.brojČipaDataGridViewTextBoxColumn,
            this.težinaDataGridViewTextBoxColumn,
            this.datumUginućaDataGridViewTextBoxColumn,
            this.imeVlasnikaDataGridViewTextBoxColumn,
            this.prezimeVlasnikaDataGridViewTextBoxColumn});
            this.uiPrikazZivotinja.DataSource = this.viewPrikazZivotinjaBindingSource;
            this.uiPrikazZivotinja.Location = new System.Drawing.Point(241, 235);
            this.uiPrikazZivotinja.Name = "uiPrikazZivotinja";
            this.uiPrikazZivotinja.ReadOnly = true;
            this.uiPrikazZivotinja.RowHeadersVisible = false;
            this.uiPrikazZivotinja.RowTemplate.Height = 24;
            this.uiPrikazZivotinja.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.uiPrikazZivotinja.Size = new System.Drawing.Size(1091, 382);
            this.uiPrikazZivotinja.TabIndex = 4;
            this.uiPrikazZivotinja.ColumnHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.uiPrikazZivotinja_ColumnHeaderMouseClick);
            // 
            // uiActionDodajZivotinju
            // 
            this.uiActionDodajZivotinju.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(140)))), ((int)(((byte)(200)))));
            this.uiActionDodajZivotinju.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.uiActionDodajZivotinju.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.uiActionDodajZivotinju.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.uiActionDodajZivotinju.Location = new System.Drawing.Point(698, 700);
            this.uiActionDodajZivotinju.Name = "uiActionDodajZivotinju";
            this.uiActionDodajZivotinju.Size = new System.Drawing.Size(135, 44);
            this.uiActionDodajZivotinju.TabIndex = 10;
            this.uiActionDodajZivotinju.Text = "Dodaj Životinju";
            this.uiActionDodajZivotinju.UseVisualStyleBackColor = false;
            this.uiActionDodajZivotinju.Click += new System.EventHandler(this.uiActionDodajZivotinju_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.White;
            this.pictureBox2.Enabled = false;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(709, 152);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(23, 20);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 26;
            this.pictureBox2.TabStop = false;
            // 
            // uiFiltrirajZivotinje
            // 
            this.uiFiltrirajZivotinje.Location = new System.Drawing.Point(521, 150);
            this.uiFiltrirajZivotinje.Margin = new System.Windows.Forms.Padding(4);
            this.uiFiltrirajZivotinje.Name = "uiFiltrirajZivotinje";
            this.uiFiltrirajZivotinje.Size = new System.Drawing.Size(215, 22);
            this.uiFiltrirajZivotinje.TabIndex = 25;
            this.uiFiltrirajZivotinje.TextChanged += new System.EventHandler(this.uiFiltrirajZivotinje_TextChanged);
            // 
            // viewPrikazZivotinjaBindingSource
            // 
            this.viewPrikazZivotinjaBindingSource.DataSource = typeof(PI_t18024_Maza.ViewPrikazZivotinja);
            // 
            // zivotinjaIDDataGridViewTextBoxColumn
            // 
            this.zivotinjaIDDataGridViewTextBoxColumn.DataPropertyName = "ZivotinjaID";
            this.zivotinjaIDDataGridViewTextBoxColumn.HeaderText = "ZivotinjaID";
            this.zivotinjaIDDataGridViewTextBoxColumn.Name = "zivotinjaIDDataGridViewTextBoxColumn";
            this.zivotinjaIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.zivotinjaIDDataGridViewTextBoxColumn.Visible = false;
            this.zivotinjaIDDataGridViewTextBoxColumn.Width = 80;
            // 
            // imeDataGridViewTextBoxColumn
            // 
            this.imeDataGridViewTextBoxColumn.DataPropertyName = "Ime";
            this.imeDataGridViewTextBoxColumn.HeaderText = "Ime";
            this.imeDataGridViewTextBoxColumn.Name = "imeDataGridViewTextBoxColumn";
            this.imeDataGridViewTextBoxColumn.ReadOnly = true;
            this.imeDataGridViewTextBoxColumn.Width = 59;
            // 
            // spolDataGridViewTextBoxColumn
            // 
            this.spolDataGridViewTextBoxColumn.DataPropertyName = "Spol";
            this.spolDataGridViewTextBoxColumn.HeaderText = "Spol";
            this.spolDataGridViewTextBoxColumn.Name = "spolDataGridViewTextBoxColumn";
            this.spolDataGridViewTextBoxColumn.ReadOnly = true;
            this.spolDataGridViewTextBoxColumn.Width = 65;
            // 
            // vrstaDataGridViewTextBoxColumn
            // 
            this.vrstaDataGridViewTextBoxColumn.DataPropertyName = "Vrsta";
            this.vrstaDataGridViewTextBoxColumn.HeaderText = "Vrsta";
            this.vrstaDataGridViewTextBoxColumn.Name = "vrstaDataGridViewTextBoxColumn";
            this.vrstaDataGridViewTextBoxColumn.ReadOnly = true;
            this.vrstaDataGridViewTextBoxColumn.Width = 70;
            // 
            // datumRođenjaDataGridViewTextBoxColumn
            // 
            this.datumRođenjaDataGridViewTextBoxColumn.DataPropertyName = "Datum_Rođenja";
            this.datumRođenjaDataGridViewTextBoxColumn.HeaderText = "Datum rođenja";
            this.datumRođenjaDataGridViewTextBoxColumn.Name = "datumRođenjaDataGridViewTextBoxColumn";
            this.datumRođenjaDataGridViewTextBoxColumn.ReadOnly = true;
            this.datumRođenjaDataGridViewTextBoxColumn.Width = 130;
            // 
            // brojČipaDataGridViewTextBoxColumn
            // 
            this.brojČipaDataGridViewTextBoxColumn.DataPropertyName = "Broj_Čipa";
            this.brojČipaDataGridViewTextBoxColumn.HeaderText = "Broj čipa";
            this.brojČipaDataGridViewTextBoxColumn.Name = "brojČipaDataGridViewTextBoxColumn";
            this.brojČipaDataGridViewTextBoxColumn.ReadOnly = true;
            this.brojČipaDataGridViewTextBoxColumn.Width = 92;
            // 
            // težinaDataGridViewTextBoxColumn
            // 
            this.težinaDataGridViewTextBoxColumn.DataPropertyName = "Težina";
            this.težinaDataGridViewTextBoxColumn.HeaderText = "Težina";
            this.težinaDataGridViewTextBoxColumn.Name = "težinaDataGridViewTextBoxColumn";
            this.težinaDataGridViewTextBoxColumn.ReadOnly = true;
            this.težinaDataGridViewTextBoxColumn.Width = 80;
            // 
            // datumUginućaDataGridViewTextBoxColumn
            // 
            this.datumUginućaDataGridViewTextBoxColumn.DataPropertyName = "Datum_Uginuća";
            this.datumUginućaDataGridViewTextBoxColumn.HeaderText = "Datum uginuća";
            this.datumUginućaDataGridViewTextBoxColumn.Name = "datumUginućaDataGridViewTextBoxColumn";
            this.datumUginućaDataGridViewTextBoxColumn.ReadOnly = true;
            this.datumUginućaDataGridViewTextBoxColumn.Width = 121;
            // 
            // imeVlasnikaDataGridViewTextBoxColumn
            // 
            this.imeVlasnikaDataGridViewTextBoxColumn.DataPropertyName = "Ime_Vlasnika";
            this.imeVlasnikaDataGridViewTextBoxColumn.HeaderText = "Ime vlasnika";
            this.imeVlasnikaDataGridViewTextBoxColumn.Name = "imeVlasnikaDataGridViewTextBoxColumn";
            this.imeVlasnikaDataGridViewTextBoxColumn.ReadOnly = true;
            this.imeVlasnikaDataGridViewTextBoxColumn.Width = 105;
            // 
            // prezimeVlasnikaDataGridViewTextBoxColumn
            // 
            this.prezimeVlasnikaDataGridViewTextBoxColumn.DataPropertyName = "Prezime_Vlasnika";
            this.prezimeVlasnikaDataGridViewTextBoxColumn.HeaderText = "Prezime vlasnika";
            this.prezimeVlasnikaDataGridViewTextBoxColumn.Name = "prezimeVlasnikaDataGridViewTextBoxColumn";
            this.prezimeVlasnikaDataGridViewTextBoxColumn.ReadOnly = true;
            this.prezimeVlasnikaDataGridViewTextBoxColumn.Width = 131;
            // 
            // frmZivotinje
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1344, 778);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.uiFiltrirajZivotinje);
            this.Controls.Add(this.uiActionDodajZivotinju);
            this.Controls.Add(this.uiPrikazZivotinja);
            this.Controls.Add(this.panel1);
            this.Name = "frmZivotinje";
            this.Text = "Zivotinje";
            this.Load += new System.EventHandler(this.Zivotinje_Load);
            this.Controls.SetChildIndex(this.panel1, 0);
            this.Controls.SetChildIndex(this.uiPrikazZivotinja, 0);
            this.Controls.SetChildIndex(this.uiActionDodajZivotinju, 0);
            this.Controls.SetChildIndex(this.uiFiltrirajZivotinje, 0);
            this.Controls.SetChildIndex(this.pictureBox2, 0);
            ((System.ComponentModel.ISupportInitialize)(this.uiPrikazZivotinja)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewPrikazZivotinjaBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private _18024_DBDataSet _18024_DBDataSet;
        private System.Windows.Forms.DataGridView uiPrikazZivotinja;
        private System.Windows.Forms.Button uiActionDodajZivotinju;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.TextBox uiFiltrirajZivotinje;
        private System.Windows.Forms.DataGridViewTextBoxColumn zivotinjaIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn imeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn spolDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vrstaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn datumRođenjaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn brojČipaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn težinaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn datumUginućaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn imeVlasnikaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn prezimeVlasnikaDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource viewPrikazZivotinjaBindingSource;
    }
}