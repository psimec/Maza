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
            this.vlasnikBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this._18024_DBDataSet = new PI_t18024_Maza._18024_DBDataSet();
            this.zivotinjaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dijagnozaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.vlasnikTableAdapter = new PI_t18024_Maza._18024_DBDataSetTableAdapters.vlasnikTableAdapter();
            this.zivotinjaTableAdapter = new PI_t18024_Maza._18024_DBDataSetTableAdapters.zivotinjaTableAdapter();
            this.dijagnozaTableAdapter = new PI_t18024_Maza._18024_DBDataSetTableAdapters.dijagnozaTableAdapter();
            this.bolestBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bolestTableAdapter = new PI_t18024_Maza._18024_DBDataSetTableAdapters.bolestTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.vlasnikBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._18024_DBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.zivotinjaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dijagnozaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bolestBindingSource)).BeginInit();
            this.SuspendLayout();
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
            // reportViewer1
            // 
            reportDataSource1.Name = "vlasnik";
            reportDataSource1.Value = this.vlasnikBindingSource;
            reportDataSource2.Name = "zivotinja";
            reportDataSource2.Value = this.zivotinjaBindingSource;
            reportDataSource3.Name = "dijagnoza";
            reportDataSource3.Value = this.dijagnozaBindingSource;
            reportDataSource4.Name = "bolest";
            reportDataSource4.Value = this.bolestBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource3);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource4);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "PI_t18024_Maza.IzvjestajZivotinja.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(165, 89);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(841, 531);
            this.reportViewer1.TabIndex = 3;
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
            // bolestBindingSource
            // 
            this.bolestBindingSource.DataMember = "bolest";
            this.bolestBindingSource.DataSource = this._18024_DBDataSet;
            // 
            // bolestTableAdapter
            // 
            this.bolestTableAdapter.ClearBeforeFill = true;
            // 
            // povijestBolesti
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 632);
            this.Controls.Add(this.reportViewer1);
            this.Name = "povijestBolesti";
            this.Text = "povijestBolseti";
            this.Load += new System.EventHandler(this.povijestBolesti_Load);
            this.Controls.SetChildIndex(this.reportViewer1, 0);
            ((System.ComponentModel.ISupportInitialize)(this.vlasnikBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._18024_DBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.zivotinjaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dijagnozaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bolestBindingSource)).EndInit();
            this.ResumeLayout(false);

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
    }
}