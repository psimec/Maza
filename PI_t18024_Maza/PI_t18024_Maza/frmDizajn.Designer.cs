namespace PI_t18024_Maza
{
    partial class frmDizajn
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDizajn));
            this.LijeviPanel = new System.Windows.Forms.Panel();
            this.uiActionKontrola = new System.Windows.Forms.Button();
            this.uiActionVlasnici = new System.Windows.Forms.Button();
            this.uiActionZivotinje = new System.Windows.Forms.Button();
            this.uiActionKalendar = new System.Windows.Forms.Button();
            this.LogoPanel = new System.Windows.Forms.Panel();
            this.ZaglavljePanel = new System.Windows.Forms.Panel();
            this.uiActionMinimize = new System.Windows.Forms.Button();
            this.uiActionClose = new System.Windows.Forms.Button();
            this.vlasnikBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this._18024_DBDataSet = new PI_t18024_Maza._18024_DBDataSet();
            this.vlasnikTableAdapter = new PI_t18024_Maza._18024_DBDataSetTableAdapters.vlasnikTableAdapter();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.LijeviPanel.SuspendLayout();
            this.LogoPanel.SuspendLayout();
            this.ZaglavljePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.vlasnikBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._18024_DBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // LijeviPanel
            // 
            this.LijeviPanel.Controls.Add(this.uiActionKontrola);
            this.LijeviPanel.Controls.Add(this.uiActionVlasnici);
            this.LijeviPanel.Controls.Add(this.uiActionZivotinje);
            this.LijeviPanel.Controls.Add(this.uiActionKalendar);
            this.LijeviPanel.Controls.Add(this.LogoPanel);
            this.LijeviPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.LijeviPanel.Location = new System.Drawing.Point(0, 0);
            this.LijeviPanel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.LijeviPanel.Name = "LijeviPanel";
            this.LijeviPanel.Size = new System.Drawing.Size(162, 632);
            this.LijeviPanel.TabIndex = 0;
            // 
            // uiActionKontrola
            // 
            this.uiActionKontrola.FlatAppearance.BorderSize = 0;
            this.uiActionKontrola.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.uiActionKontrola.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.uiActionKontrola.Image = ((System.Drawing.Image)(resources.GetObject("uiActionKontrola.Image")));
            this.uiActionKontrola.Location = new System.Drawing.Point(1, 344);
            this.uiActionKontrola.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.uiActionKontrola.Name = "uiActionKontrola";
            this.uiActionKontrola.Size = new System.Drawing.Size(159, 81);
            this.uiActionKontrola.TabIndex = 3;
            this.uiActionKontrola.Text = "Kontrola";
            this.uiActionKontrola.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.uiActionKontrola.UseVisualStyleBackColor = true;
            this.uiActionKontrola.Click += new System.EventHandler(this.uiActionKontrola_Click);
            // 
            // uiActionVlasnici
            // 
            this.uiActionVlasnici.FlatAppearance.BorderSize = 0;
            this.uiActionVlasnici.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.uiActionVlasnici.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.uiActionVlasnici.Image = ((System.Drawing.Image)(resources.GetObject("uiActionVlasnici.Image")));
            this.uiActionVlasnici.Location = new System.Drawing.Point(1, 258);
            this.uiActionVlasnici.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.uiActionVlasnici.Name = "uiActionVlasnici";
            this.uiActionVlasnici.Size = new System.Drawing.Size(159, 81);
            this.uiActionVlasnici.TabIndex = 3;
            this.uiActionVlasnici.Text = "Vlasnici";
            this.uiActionVlasnici.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.uiActionVlasnici.UseVisualStyleBackColor = true;
            this.uiActionVlasnici.Click += new System.EventHandler(this.uiActionVlasnici_Click);
            // 
            // uiActionZivotinje
            // 
            this.uiActionZivotinje.FlatAppearance.BorderSize = 0;
            this.uiActionZivotinje.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.uiActionZivotinje.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.uiActionZivotinje.Image = ((System.Drawing.Image)(resources.GetObject("uiActionZivotinje.Image")));
            this.uiActionZivotinje.Location = new System.Drawing.Point(1, 172);
            this.uiActionZivotinje.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.uiActionZivotinje.Name = "uiActionZivotinje";
            this.uiActionZivotinje.Size = new System.Drawing.Size(159, 81);
            this.uiActionZivotinje.TabIndex = 3;
            this.uiActionZivotinje.Text = "Životinje";
            this.uiActionZivotinje.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.uiActionZivotinje.UseVisualStyleBackColor = true;
            this.uiActionZivotinje.Click += new System.EventHandler(this.uiActionZivotinje_Click);
            // 
            // uiActionKalendar
            // 
            this.uiActionKalendar.FlatAppearance.BorderSize = 0;
            this.uiActionKalendar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.uiActionKalendar.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.uiActionKalendar.Image = ((System.Drawing.Image)(resources.GetObject("uiActionKalendar.Image")));
            this.uiActionKalendar.Location = new System.Drawing.Point(1, 86);
            this.uiActionKalendar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.uiActionKalendar.Name = "uiActionKalendar";
            this.uiActionKalendar.Size = new System.Drawing.Size(159, 81);
            this.uiActionKalendar.TabIndex = 3;
            this.uiActionKalendar.Text = "Kalendar";
            this.uiActionKalendar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.uiActionKalendar.UseVisualStyleBackColor = true;
            this.uiActionKalendar.Click += new System.EventHandler(this.uiActionKalendar_Click);
            // 
            // LogoPanel
            // 
            this.LogoPanel.BackColor = System.Drawing.Color.White;
            this.LogoPanel.Controls.Add(this.pictureBox1);
            this.LogoPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.LogoPanel.Location = new System.Drawing.Point(0, 0);
            this.LogoPanel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.LogoPanel.Name = "LogoPanel";
            this.LogoPanel.Size = new System.Drawing.Size(162, 81);
            this.LogoPanel.TabIndex = 2;
            // 
            // ZaglavljePanel
            // 
            this.ZaglavljePanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(119)))), ((int)(((byte)(183)))));
            this.ZaglavljePanel.Controls.Add(this.uiActionMinimize);
            this.ZaglavljePanel.Controls.Add(this.uiActionClose);
            this.ZaglavljePanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.ZaglavljePanel.Location = new System.Drawing.Point(162, 0);
            this.ZaglavljePanel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ZaglavljePanel.Name = "ZaglavljePanel";
            this.ZaglavljePanel.Size = new System.Drawing.Size(846, 81);
            this.ZaglavljePanel.TabIndex = 1;
            // 
            // uiActionMinimize
            // 
            this.uiActionMinimize.FlatAppearance.BorderSize = 0;
            this.uiActionMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.uiActionMinimize.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uiActionMinimize.Location = new System.Drawing.Point(787, 2);
            this.uiActionMinimize.Margin = new System.Windows.Forms.Padding(2, 8, 8, 2);
            this.uiActionMinimize.Name = "uiActionMinimize";
            this.uiActionMinimize.Size = new System.Drawing.Size(26, 39);
            this.uiActionMinimize.TabIndex = 0;
            this.uiActionMinimize.Text = "_";
            this.uiActionMinimize.UseVisualStyleBackColor = true;
            this.uiActionMinimize.Click += new System.EventHandler(this.uiActionMinimize_Click);
            // 
            // uiActionClose
            // 
            this.uiActionClose.FlatAppearance.BorderSize = 0;
            this.uiActionClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.uiActionClose.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uiActionClose.Location = new System.Drawing.Point(818, 2);
            this.uiActionClose.Margin = new System.Windows.Forms.Padding(2, 8, 8, 2);
            this.uiActionClose.Name = "uiActionClose";
            this.uiActionClose.Size = new System.Drawing.Size(26, 39);
            this.uiActionClose.TabIndex = 0;
            this.uiActionClose.Text = "X";
            this.uiActionClose.UseVisualStyleBackColor = true;
            this.uiActionClose.Click += new System.EventHandler(this.uiActionClose_Click);
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
            // vlasnikTableAdapter
            // 
            this.vlasnikTableAdapter.ClearBeforeFill = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(10, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(147, 78);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // frmDizajn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(212)))), ((int)(((byte)(249)))));
            this.ClientSize = new System.Drawing.Size(1008, 632);
            this.Controls.Add(this.ZaglavljePanel);
            this.Controls.Add(this.LijeviPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "frmDizajn";
            this.Text = "Dizajn";
            this.LijeviPanel.ResumeLayout(false);
            this.LogoPanel.ResumeLayout(false);
            this.ZaglavljePanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.vlasnikBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._18024_DBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel LijeviPanel;
        private System.Windows.Forms.Panel LogoPanel;
        private System.Windows.Forms.Panel ZaglavljePanel;
        private System.Windows.Forms.Button uiActionKalendar;
        private System.Windows.Forms.Button uiActionKontrola;
        private System.Windows.Forms.Button uiActionVlasnici;
        private System.Windows.Forms.Button uiActionZivotinje;
        private System.Windows.Forms.Button uiActionMinimize;
        private System.Windows.Forms.Button uiActionClose;
        private _18024_DBDataSet _18024_DBDataSet;
        private System.Windows.Forms.BindingSource vlasnikBindingSource;
        private _18024_DBDataSetTableAdapters.vlasnikTableAdapter vlasnikTableAdapter;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}