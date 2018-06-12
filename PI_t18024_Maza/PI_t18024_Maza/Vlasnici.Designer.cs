namespace PI_t18024_Maza
{
    partial class Vlasnici
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.vlasnikBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.iDvlasnikDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.imeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prezimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adresastavnovanjaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.brojtelefona1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.brojtelefona2DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.zivotinjaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
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
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vlasnikBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.zivotinjaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(162, 258);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(5, 81);
            this.panel1.TabIndex = 6;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDvlasnikDataGridViewTextBoxColumn,
            this.imeDataGridViewTextBoxColumn,
            this.prezimeDataGridViewTextBoxColumn,
            this.adresastavnovanjaDataGridViewTextBoxColumn,
            this.brojtelefona1DataGridViewTextBoxColumn,
            this.brojtelefona2DataGridViewTextBoxColumn,
            this.emailDataGridViewTextBoxColumn,
            this.zivotinjaDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.vlasnikBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(219, 103);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(744, 150);
            this.dataGridView1.TabIndex = 7;
            this.dataGridView1.SelectionChanged += new System.EventHandler(this.dataGridView1_SelectionChanged);
            // 
            // vlasnikBindingSource
            // 
            this.vlasnikBindingSource.DataSource = typeof(PI_t18024_Maza.Vlasnik);
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
            // dataGridView2
            // 
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
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
            this.dataGridView2.DataSource = this.zivotinjaBindingSource;
            this.dataGridView2.Location = new System.Drawing.Point(181, 344);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersVisible = false;
            this.dataGridView2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView2.Size = new System.Drawing.Size(825, 150);
            this.dataGridView2.TabIndex = 8;
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
            // Vlasnici
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(212)))), ((int)(((byte)(249)))));
            this.ClientSize = new System.Drawing.Size(1008, 632);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel1);
            this.Name = "Vlasnici";
            this.Text = "Vlasnici";
            this.Controls.SetChildIndex(this.panel1, 0);
            this.Controls.SetChildIndex(this.dataGridView1, 0);
            this.Controls.SetChildIndex(this.dataGridView2, 0);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vlasnikBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.zivotinjaBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource vlasnikBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDvlasnikDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn imeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn prezimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn adresastavnovanjaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn brojtelefona1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn brojtelefona2DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn zivotinjaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridView dataGridView2;
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
    }
}