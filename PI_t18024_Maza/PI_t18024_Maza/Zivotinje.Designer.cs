namespace PI_t18024_Maza
{
    partial class Zivotinje
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
            this.uiPrikazZivotinja = new System.Windows.Forms.DataGridView();
            this._18024_DBDataSet = new PI_t18024_Maza._18024_DBDataSet();
            this.vlasnikBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vlasnikTableAdapter = new PI_t18024_Maza._18024_DBDataSetTableAdapters.vlasnikTableAdapter();
            this.iDvlasnikDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.imeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prezimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adresastanovanjaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.brojtelefona1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.brojtelefona2DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.zivotinjaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.zivotinjaTableAdapter = new PI_t18024_Maza._18024_DBDataSetTableAdapters.zivotinjaTableAdapter();
            this.iDzivotinjaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.imeDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.spolDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vrstaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datumrodenjaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.brojcipaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.težinaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datumuginucaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDvlasnikDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.uiPrikazVlasnika)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uiPrikazZivotinja)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._18024_DBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vlasnikBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.zivotinjaBindingSource)).BeginInit();
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
            // uiPrikazVlasnika
            // 
            this.uiPrikazVlasnika.AllowUserToAddRows = false;
            this.uiPrikazVlasnika.AllowUserToDeleteRows = false;
            this.uiPrikazVlasnika.AutoGenerateColumns = false;
            this.uiPrikazVlasnika.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(212)))), ((int)(((byte)(249)))));
            this.uiPrikazVlasnika.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.uiPrikazVlasnika.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.uiPrikazVlasnika.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDvlasnikDataGridViewTextBoxColumn,
            this.imeDataGridViewTextBoxColumn,
            this.prezimeDataGridViewTextBoxColumn,
            this.adresastanovanjaDataGridViewTextBoxColumn,
            this.brojtelefona1DataGridViewTextBoxColumn,
            this.brojtelefona2DataGridViewTextBoxColumn,
            this.emailDataGridViewTextBoxColumn});
            this.uiPrikazVlasnika.DataSource = this.vlasnikBindingSource;
            this.uiPrikazVlasnika.Location = new System.Drawing.Point(242, 162);
            this.uiPrikazVlasnika.Name = "uiPrikazVlasnika";
            this.uiPrikazVlasnika.RowHeadersVisible = false;
            this.uiPrikazVlasnika.RowTemplate.Height = 24;
            this.uiPrikazVlasnika.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.uiPrikazVlasnika.Size = new System.Drawing.Size(364, 350);
            this.uiPrikazVlasnika.TabIndex = 4;
            // 
            // uiPrikazZivotinja
            // 
            this.uiPrikazZivotinja.AllowUserToAddRows = false;
            this.uiPrikazZivotinja.AllowUserToDeleteRows = false;
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
            this.težinaDataGridViewTextBoxColumn,
            this.datumuginucaDataGridViewTextBoxColumn,
            this.iDvlasnikDataGridViewTextBoxColumn1});
            this.uiPrikazZivotinja.DataSource = this.zivotinjaBindingSource;
            this.uiPrikazZivotinja.Location = new System.Drawing.Point(626, 162);
            this.uiPrikazZivotinja.Name = "uiPrikazZivotinja";
            this.uiPrikazZivotinja.RowHeadersVisible = false;
            this.uiPrikazZivotinja.RowTemplate.Height = 24;
            this.uiPrikazZivotinja.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.uiPrikazZivotinja.Size = new System.Drawing.Size(706, 362);
            this.uiPrikazZivotinja.TabIndex = 5;
            // 
            // _18024_DBDataSet
            // 
            this._18024_DBDataSet.DataSetName = "_18024_DBDataSet";
            this._18024_DBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // vlasnikBindingSource
            // 
            this.vlasnikBindingSource.DataMember = "vlasnik";
            this.vlasnikBindingSource.DataSource = this._18024_DBDataSet;
            // 
            // vlasnikTableAdapter
            // 
            this.vlasnikTableAdapter.ClearBeforeFill = true;
            // 
            // iDvlasnikDataGridViewTextBoxColumn
            // 
            this.iDvlasnikDataGridViewTextBoxColumn.DataPropertyName = "ID_vlasnik";
            this.iDvlasnikDataGridViewTextBoxColumn.HeaderText = "ID_vlasnik";
            this.iDvlasnikDataGridViewTextBoxColumn.Name = "iDvlasnikDataGridViewTextBoxColumn";
            this.iDvlasnikDataGridViewTextBoxColumn.ReadOnly = true;
            this.iDvlasnikDataGridViewTextBoxColumn.Visible = false;
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
            // adresastanovanjaDataGridViewTextBoxColumn
            // 
            this.adresastanovanjaDataGridViewTextBoxColumn.DataPropertyName = "adresa_stanovanja";
            this.adresastanovanjaDataGridViewTextBoxColumn.HeaderText = "adresa_stanovanja";
            this.adresastanovanjaDataGridViewTextBoxColumn.Name = "adresastanovanjaDataGridViewTextBoxColumn";
            this.adresastanovanjaDataGridViewTextBoxColumn.Visible = false;
            // 
            // brojtelefona1DataGridViewTextBoxColumn
            // 
            this.brojtelefona1DataGridViewTextBoxColumn.DataPropertyName = "broj_telefona1";
            this.brojtelefona1DataGridViewTextBoxColumn.HeaderText = "broj_telefona1";
            this.brojtelefona1DataGridViewTextBoxColumn.Name = "brojtelefona1DataGridViewTextBoxColumn";
            this.brojtelefona1DataGridViewTextBoxColumn.Visible = false;
            // 
            // brojtelefona2DataGridViewTextBoxColumn
            // 
            this.brojtelefona2DataGridViewTextBoxColumn.DataPropertyName = "broj_telefona2";
            this.brojtelefona2DataGridViewTextBoxColumn.HeaderText = "broj_telefona2";
            this.brojtelefona2DataGridViewTextBoxColumn.Name = "brojtelefona2DataGridViewTextBoxColumn";
            this.brojtelefona2DataGridViewTextBoxColumn.Visible = false;
            // 
            // emailDataGridViewTextBoxColumn
            // 
            this.emailDataGridViewTextBoxColumn.DataPropertyName = "e-mail";
            this.emailDataGridViewTextBoxColumn.HeaderText = "e-mail";
            this.emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
            this.emailDataGridViewTextBoxColumn.Visible = false;
            // 
            // zivotinjaBindingSource
            // 
            this.zivotinjaBindingSource.DataMember = "zivotinja";
            this.zivotinjaBindingSource.DataSource = this._18024_DBDataSet;
            // 
            // zivotinjaTableAdapter
            // 
            this.zivotinjaTableAdapter.ClearBeforeFill = true;
            // 
            // iDzivotinjaDataGridViewTextBoxColumn
            // 
            this.iDzivotinjaDataGridViewTextBoxColumn.DataPropertyName = "ID_zivotinja";
            this.iDzivotinjaDataGridViewTextBoxColumn.HeaderText = "ID_zivotinja";
            this.iDzivotinjaDataGridViewTextBoxColumn.Name = "iDzivotinjaDataGridViewTextBoxColumn";
            this.iDzivotinjaDataGridViewTextBoxColumn.ReadOnly = true;
            this.iDzivotinjaDataGridViewTextBoxColumn.Visible = false;
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
            // težinaDataGridViewTextBoxColumn
            // 
            this.težinaDataGridViewTextBoxColumn.DataPropertyName = "težina";
            this.težinaDataGridViewTextBoxColumn.HeaderText = "težina";
            this.težinaDataGridViewTextBoxColumn.Name = "težinaDataGridViewTextBoxColumn";
            // 
            // datumuginucaDataGridViewTextBoxColumn
            // 
            this.datumuginucaDataGridViewTextBoxColumn.DataPropertyName = "datum_uginuca";
            this.datumuginucaDataGridViewTextBoxColumn.HeaderText = "datum_uginuca";
            this.datumuginucaDataGridViewTextBoxColumn.Name = "datumuginucaDataGridViewTextBoxColumn";
            this.datumuginucaDataGridViewTextBoxColumn.Visible = false;
            // 
            // iDvlasnikDataGridViewTextBoxColumn1
            // 
            this.iDvlasnikDataGridViewTextBoxColumn1.DataPropertyName = "ID_vlasnik";
            this.iDvlasnikDataGridViewTextBoxColumn1.HeaderText = "ID_vlasnik";
            this.iDvlasnikDataGridViewTextBoxColumn1.Name = "iDvlasnikDataGridViewTextBoxColumn1";
            this.iDvlasnikDataGridViewTextBoxColumn1.Visible = false;
            // 
            // Zivotinje
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1344, 778);
            this.Controls.Add(this.uiPrikazZivotinja);
            this.Controls.Add(this.uiPrikazVlasnika);
            this.Controls.Add(this.panel1);
            this.Name = "Zivotinje";
            this.Text = "Zivotinje";
            this.Load += new System.EventHandler(this.Zivotinje_Load);
            this.Controls.SetChildIndex(this.panel1, 0);
            this.Controls.SetChildIndex(this.uiPrikazVlasnika, 0);
            this.Controls.SetChildIndex(this.uiPrikazZivotinja, 0);
            ((System.ComponentModel.ISupportInitialize)(this.uiPrikazVlasnika)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uiPrikazZivotinja)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._18024_DBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vlasnikBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.zivotinjaBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView uiPrikazVlasnika;
        private System.Windows.Forms.DataGridView uiPrikazZivotinja;
        private _18024_DBDataSet _18024_DBDataSet;
        private System.Windows.Forms.BindingSource vlasnikBindingSource;
        private _18024_DBDataSetTableAdapters.vlasnikTableAdapter vlasnikTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDvlasnikDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn imeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn prezimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn adresastanovanjaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn brojtelefona1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn brojtelefona2DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource zivotinjaBindingSource;
        private _18024_DBDataSetTableAdapters.zivotinjaTableAdapter zivotinjaTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDzivotinjaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn imeDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn spolDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vrstaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn datumrodenjaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn brojcipaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn težinaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn datumuginucaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDvlasnikDataGridViewTextBoxColumn1;
    }
}