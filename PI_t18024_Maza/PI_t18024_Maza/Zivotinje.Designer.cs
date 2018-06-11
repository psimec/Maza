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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.uiPrikazZivotinja = new System.Windows.Forms.DataGridView();
            this.zivotinjaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this._18024_DBDataSet = new PI_t18024_Maza._18024_DBDataSet();
            this.zivotinjaTableAdapter = new PI_t18024_Maza._18024_DBDataSetTableAdapters.zivotinjaTableAdapter();
            this.iDzivotinjaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.imeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.spolDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vrstaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datumrodenjaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.brojcipaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.težinaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datumuginucaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDvlasnikDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.uiPrikazZivotinja)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.zivotinjaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._18024_DBDataSet)).BeginInit();
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
            this.uiPrikazZivotinja.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.uiPrikazZivotinja.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.uiPrikazZivotinja.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.uiPrikazZivotinja.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDzivotinjaDataGridViewTextBoxColumn,
            this.imeDataGridViewTextBoxColumn,
            this.spolDataGridViewTextBoxColumn,
            this.vrstaDataGridViewTextBoxColumn,
            this.datumrodenjaDataGridViewTextBoxColumn,
            this.brojcipaDataGridViewTextBoxColumn,
            this.težinaDataGridViewTextBoxColumn,
            this.datumuginucaDataGridViewTextBoxColumn,
            this.iDvlasnikDataGridViewTextBoxColumn});
            this.uiPrikazZivotinja.DataSource = this.zivotinjaBindingSource;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.uiPrikazZivotinja.DefaultCellStyle = dataGridViewCellStyle2;
            this.uiPrikazZivotinja.Location = new System.Drawing.Point(229, 106);
            this.uiPrikazZivotinja.Name = "uiPrikazZivotinja";
            this.uiPrikazZivotinja.RowHeadersVisible = false;
            this.uiPrikazZivotinja.RowTemplate.Height = 24;
            this.uiPrikazZivotinja.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.uiPrikazZivotinja.Size = new System.Drawing.Size(1019, 362);
            this.uiPrikazZivotinja.TabIndex = 5;
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
            this.iDzivotinjaDataGridViewTextBoxColumn.Width = 107;
            // 
            // imeDataGridViewTextBoxColumn
            // 
            this.imeDataGridViewTextBoxColumn.DataPropertyName = "ime";
            this.imeDataGridViewTextBoxColumn.HeaderText = "ime";
            this.imeDataGridViewTextBoxColumn.Name = "imeDataGridViewTextBoxColumn";
            this.imeDataGridViewTextBoxColumn.Width = 69;
            // 
            // spolDataGridViewTextBoxColumn
            // 
            this.spolDataGridViewTextBoxColumn.DataPropertyName = "spol";
            this.spolDataGridViewTextBoxColumn.HeaderText = "spol";
            this.spolDataGridViewTextBoxColumn.Name = "spolDataGridViewTextBoxColumn";
            this.spolDataGridViewTextBoxColumn.Width = 72;
            // 
            // vrstaDataGridViewTextBoxColumn
            // 
            this.vrstaDataGridViewTextBoxColumn.DataPropertyName = "vrsta";
            this.vrstaDataGridViewTextBoxColumn.HeaderText = "vrsta";
            this.vrstaDataGridViewTextBoxColumn.Name = "vrstaDataGridViewTextBoxColumn";
            this.vrstaDataGridViewTextBoxColumn.Width = 76;
            // 
            // datumrodenjaDataGridViewTextBoxColumn
            // 
            this.datumrodenjaDataGridViewTextBoxColumn.DataPropertyName = "datum_rodenja";
            this.datumrodenjaDataGridViewTextBoxColumn.HeaderText = "datum_rodenja";
            this.datumrodenjaDataGridViewTextBoxColumn.Name = "datumrodenjaDataGridViewTextBoxColumn";
            this.datumrodenjaDataGridViewTextBoxColumn.Width = 162;
            // 
            // brojcipaDataGridViewTextBoxColumn
            // 
            this.brojcipaDataGridViewTextBoxColumn.DataPropertyName = "broj_cipa";
            this.brojcipaDataGridViewTextBoxColumn.HeaderText = "broj_cipa";
            this.brojcipaDataGridViewTextBoxColumn.Name = "brojcipaDataGridViewTextBoxColumn";
            this.brojcipaDataGridViewTextBoxColumn.Width = 115;
            // 
            // težinaDataGridViewTextBoxColumn
            // 
            this.težinaDataGridViewTextBoxColumn.DataPropertyName = "težina";
            this.težinaDataGridViewTextBoxColumn.HeaderText = "težina";
            this.težinaDataGridViewTextBoxColumn.Name = "težinaDataGridViewTextBoxColumn";
            this.težinaDataGridViewTextBoxColumn.Width = 86;
            // 
            // datumuginucaDataGridViewTextBoxColumn
            // 
            this.datumuginucaDataGridViewTextBoxColumn.DataPropertyName = "datum_uginuca";
            this.datumuginucaDataGridViewTextBoxColumn.HeaderText = "datum_uginuca";
            this.datumuginucaDataGridViewTextBoxColumn.Name = "datumuginucaDataGridViewTextBoxColumn";
            this.datumuginucaDataGridViewTextBoxColumn.Width = 166;
            // 
            // iDvlasnikDataGridViewTextBoxColumn
            // 
            this.iDvlasnikDataGridViewTextBoxColumn.DataPropertyName = "ID_vlasnik";
            this.iDvlasnikDataGridViewTextBoxColumn.HeaderText = "ID_vlasnik";
            this.iDvlasnikDataGridViewTextBoxColumn.Name = "iDvlasnikDataGridViewTextBoxColumn";
            this.iDvlasnikDataGridViewTextBoxColumn.Width = 121;
            // 
            // Zivotinje
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1344, 778);
            this.Controls.Add(this.uiPrikazZivotinja);
            this.Controls.Add(this.panel1);
            this.Name = "Zivotinje";
            this.Text = "Zivotinje";
            this.Load += new System.EventHandler(this.Zivotinje_Load);
            this.Controls.SetChildIndex(this.panel1, 0);
            this.Controls.SetChildIndex(this.uiPrikazZivotinja, 0);
            ((System.ComponentModel.ISupportInitialize)(this.uiPrikazZivotinja)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.zivotinjaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._18024_DBDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private _18024_DBDataSetTableAdapters.zivotinjaTableAdapter zivotinjaTableAdapter;
        private _18024_DBDataSet _18024_DBDataSet;
        private System.Windows.Forms.BindingSource zivotinjaBindingSource;
        private System.Windows.Forms.DataGridView uiPrikazZivotinja;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDzivotinjaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn imeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn spolDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vrstaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn datumrodenjaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn brojcipaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn težinaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn datumuginucaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDvlasnikDataGridViewTextBoxColumn;
    }
}