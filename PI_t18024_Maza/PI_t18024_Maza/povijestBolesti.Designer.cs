namespace PI_t18024_Maza
{
    partial class povijestBolesti
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource3 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource4 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource5 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.button1 = new System.Windows.Forms.Button();
            this.vlasnikBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this._18024_DBDataSet = new PI_t18024_Maza._18024_DBDataSet();
            this.zivotinjaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dijagnozaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bolestBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vlasnikTableAdapter = new PI_t18024_Maza._18024_DBDataSetTableAdapters.vlasnikTableAdapter();
            this.zivotinjaTableAdapter = new PI_t18024_Maza._18024_DBDataSetTableAdapters.zivotinjaTableAdapter();
            this.dijagnozaTableAdapter = new PI_t18024_Maza._18024_DBDataSetTableAdapters.dijagnozaTableAdapter();
            this.bolestTableAdapter = new PI_t18024_Maza._18024_DBDataSetTableAdapters.bolestTableAdapter();
            this.LijekBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.LijekTableAdapter = new PI_t18024_Maza._18024_DBDataSetTableAdapters.LijekTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.vlasnikBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._18024_DBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.zivotinjaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dijagnozaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bolestBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LijekBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.AutoSize = true;
            reportDataSource1.Name = "vlasnik";
            reportDataSource1.Value = this.vlasnikBindingSource;
            reportDataSource2.Name = "zivotinja";
            reportDataSource2.Value = this.zivotinjaBindingSource;
            reportDataSource3.Name = "dijagnoza";
            reportDataSource3.Value = this.dijagnozaBindingSource;
            reportDataSource4.Name = "bolest";
            reportDataSource4.Value = this.bolestBindingSource;
            reportDataSource5.Name = "lijek";
            reportDataSource5.Value = this.LijekBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource3);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource4);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource5);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "PI_t18024_Maza.IzvjestajZivotinja.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(-3, -1);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(1033, 740);
            this.reportViewer1.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(716, 745);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // vlasnikBindingSource
            // 
            this.vlasnikBindingSource.DataMember = "vlasnik";
            this.vlasnikBindingSource.DataSource = this._18024_DBDataSet;
            // 
            // _18024_DBDataSet
            // 
            this._18024_DBDataSet.DataSetName = "_18024_DBDataSet";
            this._18024_DBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // zivotinjaBindingSource
            // 
            this.zivotinjaBindingSource.DataMember = "zivotinja";
            this.zivotinjaBindingSource.DataSource = this._18024_DBDataSet;
            // 
            // dijagnozaBindingSource
            // 
            this.dijagnozaBindingSource.DataMember = "dijagnoza";
            this.dijagnozaBindingSource.DataSource = this._18024_DBDataSet;
            // 
            // bolestBindingSource
            // 
            this.bolestBindingSource.DataMember = "bolest";
            this.bolestBindingSource.DataSource = this._18024_DBDataSet;
            // 
            // vlasnikTableAdapter
            // 
            this.vlasnikTableAdapter.ClearBeforeFill = true;
            // 
            // zivotinjaTableAdapter
            // 
            this.zivotinjaTableAdapter.ClearBeforeFill = true;
            // 
            // dijagnozaTableAdapter
            // 
            this.dijagnozaTableAdapter.ClearBeforeFill = true;
            // 
            // bolestTableAdapter
            // 
            this.bolestTableAdapter.ClearBeforeFill = true;
            // 
            // LijekBindingSource
            // 
            this.LijekBindingSource.DataMember = "Lijek";
            this.LijekBindingSource.DataSource = this._18024_DBDataSet;
            // 
            // LijekTableAdapter
            // 
            this.LijekTableAdapter.ClearBeforeFill = true;
            // 
            // povijestBolesti
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1027, 780);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.reportViewer1);
            this.Name = "povijestBolesti";
            this.Text = "povijestBolseti";
            this.Load += new System.EventHandler(this.povijestBolesti_Load);
            ((System.ComponentModel.ISupportInitialize)(this.vlasnikBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._18024_DBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.zivotinjaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dijagnozaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bolestBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LijekBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource vlasnikBindingSource;
        private _18024_DBDataSet _18024_DBDataSet;
        private System.Windows.Forms.BindingSource zivotinjaBindingSource;
        private _18024_DBDataSetTableAdapters.vlasnikTableAdapter vlasnikTableAdapter;
        private _18024_DBDataSetTableAdapters.zivotinjaTableAdapter zivotinjaTableAdapter;
        private System.Windows.Forms.BindingSource dijagnozaBindingSource;
        private _18024_DBDataSetTableAdapters.dijagnozaTableAdapter dijagnozaTableAdapter;
        private System.Windows.Forms.BindingSource bolestBindingSource;
        private _18024_DBDataSetTableAdapters.bolestTableAdapter bolestTableAdapter;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.BindingSource LijekBindingSource;
        private _18024_DBDataSetTableAdapters.LijekTableAdapter LijekTableAdapter;
    }
}