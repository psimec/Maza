namespace PI_t18024_Maza
{
    partial class frmVlasnici
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.uiPrikazVlasnika = new System.Windows.Forms.DataGridView();
            this.iDvlasnikDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.imeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prezimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adresastavnovanjaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.brojtelefona1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.brojtelefona2DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.zivotinjaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vlasnikBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.uiPrikazZivotinja = new System.Windows.Forms.DataGridView();
            this.iDzivotinjaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.imeDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.spolDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vrstaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datumrodenjaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.brojcipaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tezinaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datumuginucaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDvlasnikaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kontrolaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vlasnikDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.zivotinjaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.uiActionDodajZivotinju = new System.Windows.Forms.Button();
            this.uiActionAzurirajVlasnika = new System.Windows.Forms.Button();
            this.uiDodajVlasnika = new System.Windows.Forms.Button();
            this.uiIzbrisiVlasnika = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.uiPrikazVlasnika)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vlasnikBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uiPrikazZivotinja)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.zivotinjaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(216, 318);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(7, 100);
            this.panel1.TabIndex = 6;
            // 
            // uiPrikazVlasnika
            // 
            this.uiPrikazVlasnika.AllowUserToAddRows = false;
            this.uiPrikazVlasnika.AllowUserToDeleteRows = false;
            this.uiPrikazVlasnika.AllowUserToResizeRows = false;
            this.uiPrikazVlasnika.AutoGenerateColumns = false;
            this.uiPrikazVlasnika.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(212)))), ((int)(((byte)(249)))));
            this.uiPrikazVlasnika.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.uiPrikazVlasnika.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.uiPrikazVlasnika.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDvlasnikDataGridViewTextBoxColumn,
            this.imeDataGridViewTextBoxColumn,
            this.prezimeDataGridViewTextBoxColumn,
            this.adresastavnovanjaDataGridViewTextBoxColumn,
            this.brojtelefona1DataGridViewTextBoxColumn,
            this.brojtelefona2DataGridViewTextBoxColumn,
            this.emailDataGridViewTextBoxColumn,
            this.zivotinjaDataGridViewTextBoxColumn});
            this.uiPrikazVlasnika.DataSource = this.vlasnikBindingSource;
            this.uiPrikazVlasnika.Location = new System.Drawing.Point(292, 127);
            this.uiPrikazVlasnika.Margin = new System.Windows.Forms.Padding(4);
            this.uiPrikazVlasnika.Name = "uiPrikazVlasnika";
            this.uiPrikazVlasnika.RowHeadersVisible = false;
            this.uiPrikazVlasnika.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.uiPrikazVlasnika.Size = new System.Drawing.Size(992, 185);
            this.uiPrikazVlasnika.TabIndex = 7;
            this.uiPrikazVlasnika.ColumnHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.uiPrikazVlasnika_ColumnHeaderMouseClick);
            this.uiPrikazVlasnika.SelectionChanged += new System.EventHandler(this.dataGridView1_SelectionChanged);
            // 
            // iDvlasnikDataGridViewTextBoxColumn
            // 
            this.iDvlasnikDataGridViewTextBoxColumn.DataPropertyName = "ID_vlasnik";
            this.iDvlasnikDataGridViewTextBoxColumn.HeaderText = "ID_vlasnik";
            this.iDvlasnikDataGridViewTextBoxColumn.Name = "iDvlasnikDataGridViewTextBoxColumn";
            // 
            // imeDataGridViewTextBoxColumn
            // 
            this.imeDataGridViewTextBoxColumn.DataPropertyName = "ime";
            this.imeDataGridViewTextBoxColumn.HeaderText = "ime";
            this.imeDataGridViewTextBoxColumn.Name = "imeDataGridViewTextBoxColumn";
            // 
            // prezimeDataGridViewTextBoxColumn
            // 
            this.prezimeDataGridViewTextBoxColumn.DataPropertyName = "prezime";
            this.prezimeDataGridViewTextBoxColumn.HeaderText = "prezime";
            this.prezimeDataGridViewTextBoxColumn.Name = "prezimeDataGridViewTextBoxColumn";
            // 
            // adresastavnovanjaDataGridViewTextBoxColumn
            // 
            this.adresastavnovanjaDataGridViewTextBoxColumn.DataPropertyName = "adresa_stavnovanja";
            this.adresastavnovanjaDataGridViewTextBoxColumn.HeaderText = "adresa_stavnovanja";
            this.adresastavnovanjaDataGridViewTextBoxColumn.Name = "adresastavnovanjaDataGridViewTextBoxColumn";
            // 
            // brojtelefona1DataGridViewTextBoxColumn
            // 
            this.brojtelefona1DataGridViewTextBoxColumn.DataPropertyName = "broj_telefona1";
            this.brojtelefona1DataGridViewTextBoxColumn.HeaderText = "broj_telefona1";
            this.brojtelefona1DataGridViewTextBoxColumn.Name = "brojtelefona1DataGridViewTextBoxColumn";
            // 
            // brojtelefona2DataGridViewTextBoxColumn
            // 
            this.brojtelefona2DataGridViewTextBoxColumn.DataPropertyName = "broj_telefona2";
            this.brojtelefona2DataGridViewTextBoxColumn.HeaderText = "broj_telefona2";
            this.brojtelefona2DataGridViewTextBoxColumn.Name = "brojtelefona2DataGridViewTextBoxColumn";
            // 
            // emailDataGridViewTextBoxColumn
            // 
            this.emailDataGridViewTextBoxColumn.DataPropertyName = "email";
            this.emailDataGridViewTextBoxColumn.HeaderText = "email";
            this.emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
            // 
            // zivotinjaDataGridViewTextBoxColumn
            // 
            this.zivotinjaDataGridViewTextBoxColumn.DataPropertyName = "Zivotinja";
            this.zivotinjaDataGridViewTextBoxColumn.HeaderText = "Zivotinja";
            this.zivotinjaDataGridViewTextBoxColumn.Name = "zivotinjaDataGridViewTextBoxColumn";
            this.zivotinjaDataGridViewTextBoxColumn.Visible = false;
            // 
            // vlasnikBindingSource
            // 
            this.vlasnikBindingSource.DataSource = typeof(PI_t18024_Maza.Vlasnik);
            // 
            // uiPrikazZivotinja
            // 
            this.uiPrikazZivotinja.AllowUserToAddRows = false;
            this.uiPrikazZivotinja.AllowUserToDeleteRows = false;
            this.uiPrikazZivotinja.AllowUserToResizeColumns = false;
            this.uiPrikazZivotinja.AllowUserToResizeRows = false;
            this.uiPrikazZivotinja.AutoGenerateColumns = false;
            this.uiPrikazZivotinja.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(212)))), ((int)(((byte)(249)))));
            this.uiPrikazZivotinja.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.uiPrikazZivotinja.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.uiPrikazZivotinja.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDzivotinjaDataGridViewTextBoxColumn,
            this.imeDataGridViewTextBoxColumn1,
            this.spolDataGridViewTextBoxColumn,
            this.vrstaDataGridViewTextBoxColumn,
            this.datumrodenjaDataGridViewTextBoxColumn,
            this.brojcipaDataGridViewTextBoxColumn,
            this.tezinaDataGridViewTextBoxColumn,
            this.datumuginucaDataGridViewTextBoxColumn,
            this.iDvlasnikaDataGridViewTextBoxColumn,
            this.kontrolaDataGridViewTextBoxColumn,
            this.vlasnikDataGridViewTextBoxColumn});
            this.uiPrikazZivotinja.DataSource = this.zivotinjaBindingSource;
            this.uiPrikazZivotinja.Location = new System.Drawing.Point(241, 423);
            this.uiPrikazZivotinja.Margin = new System.Windows.Forms.Padding(4);
            this.uiPrikazZivotinja.Name = "uiPrikazZivotinja";
            this.uiPrikazZivotinja.RowHeadersVisible = false;
            this.uiPrikazZivotinja.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.uiPrikazZivotinja.Size = new System.Drawing.Size(1100, 185);
            this.uiPrikazZivotinja.TabIndex = 8;
            // 
            // iDzivotinjaDataGridViewTextBoxColumn
            // 
            this.iDzivotinjaDataGridViewTextBoxColumn.DataPropertyName = "ID_zivotinja";
            this.iDzivotinjaDataGridViewTextBoxColumn.HeaderText = "ID_zivotinja";
            this.iDzivotinjaDataGridViewTextBoxColumn.Name = "iDzivotinjaDataGridViewTextBoxColumn";
            // 
            // imeDataGridViewTextBoxColumn1
            // 
            this.imeDataGridViewTextBoxColumn1.DataPropertyName = "ime";
            this.imeDataGridViewTextBoxColumn1.HeaderText = "ime";
            this.imeDataGridViewTextBoxColumn1.Name = "imeDataGridViewTextBoxColumn1";
            // 
            // spolDataGridViewTextBoxColumn
            // 
            this.spolDataGridViewTextBoxColumn.DataPropertyName = "spol";
            this.spolDataGridViewTextBoxColumn.HeaderText = "spol";
            this.spolDataGridViewTextBoxColumn.Name = "spolDataGridViewTextBoxColumn";
            // 
            // vrstaDataGridViewTextBoxColumn
            // 
            this.vrstaDataGridViewTextBoxColumn.DataPropertyName = "vrsta";
            this.vrstaDataGridViewTextBoxColumn.HeaderText = "vrsta";
            this.vrstaDataGridViewTextBoxColumn.Name = "vrstaDataGridViewTextBoxColumn";
            // 
            // datumrodenjaDataGridViewTextBoxColumn
            // 
            this.datumrodenjaDataGridViewTextBoxColumn.DataPropertyName = "datum_rodenja";
            this.datumrodenjaDataGridViewTextBoxColumn.HeaderText = "datum_rodenja";
            this.datumrodenjaDataGridViewTextBoxColumn.Name = "datumrodenjaDataGridViewTextBoxColumn";
            // 
            // brojcipaDataGridViewTextBoxColumn
            // 
            this.brojcipaDataGridViewTextBoxColumn.DataPropertyName = "broj_cipa";
            this.brojcipaDataGridViewTextBoxColumn.HeaderText = "broj_cipa";
            this.brojcipaDataGridViewTextBoxColumn.Name = "brojcipaDataGridViewTextBoxColumn";
            // 
            // tezinaDataGridViewTextBoxColumn
            // 
            this.tezinaDataGridViewTextBoxColumn.DataPropertyName = "tezina";
            this.tezinaDataGridViewTextBoxColumn.HeaderText = "tezina";
            this.tezinaDataGridViewTextBoxColumn.Name = "tezinaDataGridViewTextBoxColumn";
            // 
            // datumuginucaDataGridViewTextBoxColumn
            // 
            this.datumuginucaDataGridViewTextBoxColumn.DataPropertyName = "datum_uginuca";
            this.datumuginucaDataGridViewTextBoxColumn.HeaderText = "datum_uginuca";
            this.datumuginucaDataGridViewTextBoxColumn.Name = "datumuginucaDataGridViewTextBoxColumn";
            // 
            // iDvlasnikaDataGridViewTextBoxColumn
            // 
            this.iDvlasnikaDataGridViewTextBoxColumn.DataPropertyName = "ID_vlasnika";
            this.iDvlasnikaDataGridViewTextBoxColumn.HeaderText = "ID_vlasnika";
            this.iDvlasnikaDataGridViewTextBoxColumn.Name = "iDvlasnikaDataGridViewTextBoxColumn";
            this.iDvlasnikaDataGridViewTextBoxColumn.Visible = false;
            // 
            // kontrolaDataGridViewTextBoxColumn
            // 
            this.kontrolaDataGridViewTextBoxColumn.DataPropertyName = "Kontrola";
            this.kontrolaDataGridViewTextBoxColumn.HeaderText = "Kontrola";
            this.kontrolaDataGridViewTextBoxColumn.Name = "kontrolaDataGridViewTextBoxColumn";
            this.kontrolaDataGridViewTextBoxColumn.Visible = false;
            // 
            // vlasnikDataGridViewTextBoxColumn
            // 
            this.vlasnikDataGridViewTextBoxColumn.DataPropertyName = "Vlasnik";
            this.vlasnikDataGridViewTextBoxColumn.HeaderText = "Vlasnik";
            this.vlasnikDataGridViewTextBoxColumn.Name = "vlasnikDataGridViewTextBoxColumn";
            this.vlasnikDataGridViewTextBoxColumn.Visible = false;
            // 
            // zivotinjaBindingSource
            // 
            this.zivotinjaBindingSource.DataSource = typeof(PI_t18024_Maza.Zivotinja);
            // 
            // uiActionDodajZivotinju
            // 
            this.uiActionDodajZivotinju.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(140)))), ((int)(((byte)(200)))));
            this.uiActionDodajZivotinju.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.uiActionDodajZivotinju.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.uiActionDodajZivotinju.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.uiActionDodajZivotinju.Location = new System.Drawing.Point(1149, 635);
            this.uiActionDodajZivotinju.Name = "uiActionDodajZivotinju";
            this.uiActionDodajZivotinju.Size = new System.Drawing.Size(135, 44);
            this.uiActionDodajZivotinju.TabIndex = 9;
            this.uiActionDodajZivotinju.Text = "Dodaj Životinju";
            this.uiActionDodajZivotinju.UseVisualStyleBackColor = false;
            this.uiActionDodajZivotinju.Click += new System.EventHandler(this.uiActionDodajZivotinju_Click);
            // 
            // uiActionAzurirajVlasnika
            // 
            this.uiActionAzurirajVlasnika.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(140)))), ((int)(((byte)(200)))));
            this.uiActionAzurirajVlasnika.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.uiActionAzurirajVlasnika.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.uiActionAzurirajVlasnika.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.uiActionAzurirajVlasnika.Location = new System.Drawing.Point(983, 319);
            this.uiActionAzurirajVlasnika.Name = "uiActionAzurirajVlasnika";
            this.uiActionAzurirajVlasnika.Size = new System.Drawing.Size(144, 49);
            this.uiActionAzurirajVlasnika.TabIndex = 10;
            this.uiActionAzurirajVlasnika.Text = "Ažuriraj Vlasnika";
            this.uiActionAzurirajVlasnika.UseVisualStyleBackColor = false;
            this.uiActionAzurirajVlasnika.Click += new System.EventHandler(this.uiActionAzurirajVlasnika_Click);
            // 
            // uiDodajVlasnika
            // 
            this.uiDodajVlasnika.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(140)))), ((int)(((byte)(200)))));
            this.uiDodajVlasnika.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.uiDodajVlasnika.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.uiDodajVlasnika.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.uiDodajVlasnika.Location = new System.Drawing.Point(808, 318);
            this.uiDodajVlasnika.Name = "uiDodajVlasnika";
            this.uiDodajVlasnika.Size = new System.Drawing.Size(144, 49);
            this.uiDodajVlasnika.TabIndex = 11;
            this.uiDodajVlasnika.Text = "Dodaj Vlasnika";
            this.uiDodajVlasnika.UseVisualStyleBackColor = false;
            this.uiDodajVlasnika.Click += new System.EventHandler(this.uiDodajVlasnika_Click);
            // 
            // uiIzbrisiVlasnika
            // 
            this.uiIzbrisiVlasnika.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(140)))), ((int)(((byte)(200)))));
            this.uiIzbrisiVlasnika.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.uiIzbrisiVlasnika.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.uiIzbrisiVlasnika.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.uiIzbrisiVlasnika.Location = new System.Drawing.Point(1156, 318);
            this.uiIzbrisiVlasnika.Name = "uiIzbrisiVlasnika";
            this.uiIzbrisiVlasnika.Size = new System.Drawing.Size(144, 49);
            this.uiIzbrisiVlasnika.TabIndex = 12;
            this.uiIzbrisiVlasnika.Text = "Izbriši Vlasnika";
            this.uiIzbrisiVlasnika.UseVisualStyleBackColor = false;
            this.uiIzbrisiVlasnika.Click += new System.EventHandler(this.uiIzbrisiVlasnika_Click);
            // 
            // frmVlasnici
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(212)))), ((int)(((byte)(249)))));
            this.ClientSize = new System.Drawing.Size(1344, 778);
            this.Controls.Add(this.uiIzbrisiVlasnika);
            this.Controls.Add(this.uiDodajVlasnika);
            this.Controls.Add(this.uiActionAzurirajVlasnika);
            this.Controls.Add(this.uiActionDodajZivotinju);
            this.Controls.Add(this.uiPrikazZivotinja);
            this.Controls.Add(this.uiPrikazVlasnika);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.Name = "frmVlasnici";
            this.Text = "Vlasnici";
            this.Controls.SetChildIndex(this.panel1, 0);
            this.Controls.SetChildIndex(this.uiPrikazVlasnika, 0);
            this.Controls.SetChildIndex(this.uiPrikazZivotinja, 0);
            this.Controls.SetChildIndex(this.uiActionDodajZivotinju, 0);
            this.Controls.SetChildIndex(this.uiActionAzurirajVlasnika, 0);
            this.Controls.SetChildIndex(this.uiDodajVlasnika, 0);
            this.Controls.SetChildIndex(this.uiIzbrisiVlasnika, 0);
            ((System.ComponentModel.ISupportInitialize)(this.uiPrikazVlasnika)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vlasnikBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uiPrikazZivotinja)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.zivotinjaBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView uiPrikazVlasnika;
        private System.Windows.Forms.BindingSource vlasnikBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDvlasnikDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn imeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn prezimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn adresastavnovanjaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn brojtelefona1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn brojtelefona2DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn zivotinjaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridView uiPrikazZivotinja;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDzivotinjaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn imeDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn spolDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vrstaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn datumrodenjaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn brojcipaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tezinaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn datumuginucaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDvlasnikaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kontrolaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vlasnikDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource zivotinjaBindingSource;
        private System.Windows.Forms.Button uiActionDodajZivotinju;
        private System.Windows.Forms.Button uiActionAzurirajVlasnika;
        private System.Windows.Forms.Button uiDodajVlasnika;
        private System.Windows.Forms.Button uiIzbrisiVlasnika;
    }
}