namespace PI_t18024_Maza
{
    partial class NovaKontrola
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
            this.uiOdabirZivotinja = new System.Windows.Forms.ComboBox();
            this.zivotinjaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this._18024_DBDataSet = new PI_t18024_Maza._18024_DBDataSet();
            this.uiOdabirVeterinar = new System.Windows.Forms.ComboBox();
            this.veterinarBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.uiOdabirDatum = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.uiOdabirStatus = new System.Windows.Forms.ComboBox();
            this.uiUnosOpis = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.uiActionUredu = new System.Windows.Forms.Button();
            this.uiActionOdustani = new System.Windows.Forms.Button();
            this.zivotinjaTableAdapter = new PI_t18024_Maza._18024_DBDataSetTableAdapters.zivotinjaTableAdapter();
            this.veterinarTableAdapter = new PI_t18024_Maza._18024_DBDataSetTableAdapters.veterinarTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.zivotinjaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._18024_DBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.veterinarBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // uiOdabirZivotinja
            // 
            this.uiOdabirZivotinja.DataSource = this.zivotinjaBindingSource;
            this.uiOdabirZivotinja.DisplayMember = "ime";
            this.uiOdabirZivotinja.FormattingEnabled = true;
            this.uiOdabirZivotinja.Location = new System.Drawing.Point(113, 34);
            this.uiOdabirZivotinja.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.uiOdabirZivotinja.Name = "uiOdabirZivotinja";
            this.uiOdabirZivotinja.Size = new System.Drawing.Size(280, 24);
            this.uiOdabirZivotinja.TabIndex = 0;
            this.uiOdabirZivotinja.ValueMember = "ID_zivotinja";
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
            // uiOdabirVeterinar
            // 
            this.uiOdabirVeterinar.DataSource = this.veterinarBindingSource;
            this.uiOdabirVeterinar.DisplayMember = "ime";
            this.uiOdabirVeterinar.FormattingEnabled = true;
            this.uiOdabirVeterinar.Location = new System.Drawing.Point(113, 80);
            this.uiOdabirVeterinar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.uiOdabirVeterinar.Name = "uiOdabirVeterinar";
            this.uiOdabirVeterinar.Size = new System.Drawing.Size(280, 24);
            this.uiOdabirVeterinar.TabIndex = 1;
            this.uiOdabirVeterinar.ValueMember = "ID_veterinar";
            // 
            // veterinarBindingSource
            // 
            this.veterinarBindingSource.DataMember = "veterinar";
            this.veterinarBindingSource.DataSource = this._18024_DBDataSet;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 38);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Životinja";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 84);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Veterinar";
            // 
            // uiOdabirDatum
            // 
            this.uiOdabirDatum.Location = new System.Drawing.Point(113, 129);
            this.uiOdabirDatum.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.uiOdabirDatum.Name = "uiOdabirDatum";
            this.uiOdabirDatum.Size = new System.Drawing.Size(280, 22);
            this.uiOdabirDatum.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(31, 133);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Datum";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(29, 178);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 17);
            this.label4.TabIndex = 7;
            this.label4.Text = "Status";
            // 
            // uiOdabirStatus
            // 
            this.uiOdabirStatus.FormattingEnabled = true;
            this.uiOdabirStatus.Items.AddRange(new object[] {
            "Obavljen",
            "Nije obavljen"});
            this.uiOdabirStatus.Location = new System.Drawing.Point(113, 175);
            this.uiOdabirStatus.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.uiOdabirStatus.Name = "uiOdabirStatus";
            this.uiOdabirStatus.Size = new System.Drawing.Size(280, 24);
            this.uiOdabirStatus.TabIndex = 6;
            // 
            // uiUnosOpis
            // 
            this.uiUnosOpis.Location = new System.Drawing.Point(113, 222);
            this.uiUnosOpis.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.uiUnosOpis.Multiline = true;
            this.uiUnosOpis.Name = "uiUnosOpis";
            this.uiUnosOpis.Size = new System.Drawing.Size(280, 157);
            this.uiUnosOpis.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(31, 225);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 17);
            this.label5.TabIndex = 9;
            this.label5.Text = "Opis";
            // 
            // uiActionUredu
            // 
            this.uiActionUredu.Location = new System.Drawing.Point(192, 399);
            this.uiActionUredu.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.uiActionUredu.Name = "uiActionUredu";
            this.uiActionUredu.Size = new System.Drawing.Size(100, 28);
            this.uiActionUredu.TabIndex = 10;
            this.uiActionUredu.Text = "Uredu";
            this.uiActionUredu.UseVisualStyleBackColor = true;
            this.uiActionUredu.Click += new System.EventHandler(this.uiActionUredu_Click);
            // 
            // uiActionOdustani
            // 
            this.uiActionOdustani.Location = new System.Drawing.Point(300, 399);
            this.uiActionOdustani.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.uiActionOdustani.Name = "uiActionOdustani";
            this.uiActionOdustani.Size = new System.Drawing.Size(100, 28);
            this.uiActionOdustani.TabIndex = 11;
            this.uiActionOdustani.Text = "Odustani";
            this.uiActionOdustani.UseVisualStyleBackColor = true;
            this.uiActionOdustani.Click += new System.EventHandler(this.uiActionOdustani_Click);
            // 
            // zivotinjaTableAdapter
            // 
            this.zivotinjaTableAdapter.ClearBeforeFill = true;
            // 
            // veterinarTableAdapter
            // 
            this.veterinarTableAdapter.ClearBeforeFill = true;
            // 
            // NovaKontrola
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(437, 455);
            this.Controls.Add(this.uiActionOdustani);
            this.Controls.Add(this.uiActionUredu);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.uiUnosOpis);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.uiOdabirStatus);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.uiOdabirDatum);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.uiOdabirVeterinar);
            this.Controls.Add(this.uiOdabirZivotinja);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "NovaKontrola";
            this.Text = "Kreiraj kontrolu";
            this.Load += new System.EventHandler(this.NovaKontrola_Load);
            ((System.ComponentModel.ISupportInitialize)(this.zivotinjaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._18024_DBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.veterinarBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox uiOdabirZivotinja;
        private System.Windows.Forms.ComboBox uiOdabirVeterinar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker uiOdabirDatum;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox uiOdabirStatus;
        private System.Windows.Forms.TextBox uiUnosOpis;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button uiActionUredu;
        private System.Windows.Forms.Button uiActionOdustani;
        private _18024_DBDataSet _18024_DBDataSet;
        private System.Windows.Forms.BindingSource zivotinjaBindingSource;
        private _18024_DBDataSetTableAdapters.zivotinjaTableAdapter zivotinjaTableAdapter;
        private System.Windows.Forms.BindingSource veterinarBindingSource;
        private _18024_DBDataSetTableAdapters.veterinarTableAdapter veterinarTableAdapter;
    }
}