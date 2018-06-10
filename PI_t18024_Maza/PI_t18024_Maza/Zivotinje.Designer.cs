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
            this.iDzivotinjaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.imeDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.spolDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vrstaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datumrodenjaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.brojcipaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.težinaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datumuginucaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDvlasnikDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.zivotinjaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this._18024_DBDataSet = new PI_t18024_Maza._18024_DBDataSet();
            this.iDvlasnikDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.imeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prezimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adresastanovanjaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.brojtelefona1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.brojtelefona2DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vlasnikBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vlasnikTableAdapter = new PI_t18024_Maza._18024_DBDataSetTableAdapters.vlasnikTableAdapter();
            this.tableAdapterManager1 = new PI_t18024_Maza._18024_DBDataSetTableAdapters.TableAdapterManager();
            this.zivotinjaTableAdapter = new PI_t18024_Maza._18024_DBDataSetTableAdapters.zivotinjaTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.uiPrikazVlasnika)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uiPrikazZivotinja)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.zivotinjaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._18024_DBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vlasnikBindingSource)).BeginInit();
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
            this.uiPrikazVlasnika.AutoGenerateColumns = false;
            this.uiPrikazVlasnika.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(212)))), ((int)(((byte)(249)))));
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
            this.uiPrikazVlasnika.Location = new System.Drawing.Point(229, 106);
            this.uiPrikazVlasnika.Name = "uiPrikazVlasnika";
            this.uiPrikazVlasnika.RowTemplate.Height = 24;
            this.uiPrikazVlasnika.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.uiPrikazVlasnika.Size = new System.Drawing.Size(853, 350);
            this.uiPrikazVlasnika.TabIndex = 4;
            // 
            // uiPrikazZivotinja
            // 
            this.uiPrikazZivotinja.AutoGenerateColumns = false;
            this.uiPrikazZivotinja.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(212)))), ((int)(((byte)(249)))));
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
            this.uiPrikazZivotinja.Location = new System.Drawing.Point(229, 462);
            this.uiPrikazZivotinja.Name = "uiPrikazZivotinja";
            this.uiPrikazZivotinja.RowTemplate.Height = 24;
            this.uiPrikazZivotinja.Size = new System.Drawing.Size(1003, 150);
            this.uiPrikazZivotinja.TabIndex = 5;
            // 
            // iDzivotinjaDataGridViewTextBoxColumn
            // 
            this.iDzivotinjaDataGridViewTextBoxColumn.DataPropertyName = "ID_zivotinja";
            this.iDzivotinjaDataGridViewTextBoxColumn.HeaderText = "ID_zivotinja";
            this.iDzivotinjaDataGridViewTextBoxColumn.Name = "iDzivotinjaDataGridViewTextBoxColumn";
            this.iDzivotinjaDataGridViewTextBoxColumn.ReadOnly = true;
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
            // 
            // iDvlasnikDataGridViewTextBoxColumn1
            // 
            this.iDvlasnikDataGridViewTextBoxColumn1.DataPropertyName = "ID_vlasnik";
            this.iDvlasnikDataGridViewTextBoxColumn1.HeaderText = "ID_vlasnik";
            this.iDvlasnikDataGridViewTextBoxColumn1.Name = "iDvlasnikDataGridViewTextBoxColumn1";
            // 
            // zivotinjaBindingSource
            // 
            this.zivotinjaBindingSource.DataMember = "zivotinja";
            this.zivotinjaBindingSource.DataSource = this._18024_DBDataSet;
            // 
            // _18024_DBDataSet
            // 
            this._18024_DBDataSet.DataSetName = "_18024_DBDataSet";
            this._18024_DBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            this.emailDataGridViewTextBoxColumn.DataPropertyName = "e-mail";
            this.emailDataGridViewTextBoxColumn.HeaderText = "e-mail";
            this.emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
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
            // tableAdapterManager1
            // 
            this.tableAdapterManager1.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager1.bolestTableAdapter = null;
            this.tableAdapterManager1.cjepivo_za_zivotinjuTableAdapter = null;
            this.tableAdapterManager1.cjepivoTableAdapter = null;
            this.tableAdapterManager1.dijagnozaTableAdapter = null;
            this.tableAdapterManager1.kontrolaTableAdapter = null;
            this.tableAdapterManager1.LijekTableAdapter = null;
            this.tableAdapterManager1.operacijaTableAdapter = null;
            this.tableAdapterManager1.propisani_lijekTableAdapter = null;
            this.tableAdapterManager1.UpdateOrder = PI_t18024_Maza._18024_DBDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager1.veterinarTableAdapter = null;
            this.tableAdapterManager1.vlasnikTableAdapter = this.vlasnikTableAdapter;
            this.tableAdapterManager1.zivotinjaTableAdapter = this.zivotinjaTableAdapter;
            // 
            // zivotinjaTableAdapter
            // 
            this.zivotinjaTableAdapter.ClearBeforeFill = true;
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
            ((System.ComponentModel.ISupportInitialize)(this.zivotinjaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._18024_DBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vlasnikBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private _18024_DBDataSet _18024_DBDataSet;
        private System.Windows.Forms.BindingSource vlasnikBindingSource;
        private _18024_DBDataSetTableAdapters.vlasnikTableAdapter vlasnikTableAdapter;
        private _18024_DBDataSetTableAdapters.TableAdapterManager tableAdapterManager1;
        private System.Windows.Forms.DataGridView uiPrikazVlasnika;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDvlasnikDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn imeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn prezimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn adresastanovanjaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn brojtelefona1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn brojtelefona2DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private _18024_DBDataSetTableAdapters.zivotinjaTableAdapter zivotinjaTableAdapter;
        private System.Windows.Forms.DataGridView uiPrikazZivotinja;
        private System.Windows.Forms.BindingSource zivotinjaBindingSource;
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