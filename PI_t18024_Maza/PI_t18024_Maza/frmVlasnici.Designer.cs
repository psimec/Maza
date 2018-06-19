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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmVlasnici));
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
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.uiFiltrirajVlasnike = new System.Windows.Forms.TextBox();
            this.uiActionPovijestBolesti = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.uiPrikazVlasnika)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vlasnikBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uiPrikazZivotinja)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.zivotinjaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
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
            // uiPrikazVlasnika
            // 
            this.uiPrikazVlasnika.AllowUserToAddRows = false;
            this.uiPrikazVlasnika.AllowUserToDeleteRows = false;
            this.uiPrikazVlasnika.AllowUserToResizeRows = false;
            this.uiPrikazVlasnika.AutoGenerateColumns = false;
            this.uiPrikazVlasnika.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.uiPrikazVlasnika.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
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
            this.uiPrikazVlasnika.Location = new System.Drawing.Point(364, 118);
            this.uiPrikazVlasnika.Name = "uiPrikazVlasnika";
            this.uiPrikazVlasnika.RowHeadersVisible = false;
            this.uiPrikazVlasnika.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.uiPrikazVlasnika.Size = new System.Drawing.Size(634, 269);
            this.uiPrikazVlasnika.TabIndex = 7;
            this.uiPrikazVlasnika.ColumnHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.uiPrikazVlasnika_ColumnHeaderMouseClick);
            this.uiPrikazVlasnika.SelectionChanged += new System.EventHandler(this.dataGridView1_SelectionChanged);
            // 
            // iDvlasnikDataGridViewTextBoxColumn
            // 
            this.iDvlasnikDataGridViewTextBoxColumn.DataPropertyName = "ID_vlasnik";
            this.iDvlasnikDataGridViewTextBoxColumn.HeaderText = "ID_vlasnik";
            this.iDvlasnikDataGridViewTextBoxColumn.Name = "iDvlasnikDataGridViewTextBoxColumn";
            this.iDvlasnikDataGridViewTextBoxColumn.Visible = false;
            // 
            // imeDataGridViewTextBoxColumn
            // 
            this.imeDataGridViewTextBoxColumn.DataPropertyName = "ime";
            this.imeDataGridViewTextBoxColumn.HeaderText = "Ime";
            this.imeDataGridViewTextBoxColumn.Name = "imeDataGridViewTextBoxColumn";
            this.imeDataGridViewTextBoxColumn.Width = 49;
            // 
            // prezimeDataGridViewTextBoxColumn
            // 
            this.prezimeDataGridViewTextBoxColumn.DataPropertyName = "prezime";
            this.prezimeDataGridViewTextBoxColumn.HeaderText = "Prezime";
            this.prezimeDataGridViewTextBoxColumn.Name = "prezimeDataGridViewTextBoxColumn";
            this.prezimeDataGridViewTextBoxColumn.Width = 69;
            // 
            // adresastavnovanjaDataGridViewTextBoxColumn
            // 
            this.adresastavnovanjaDataGridViewTextBoxColumn.DataPropertyName = "adresa_stavnovanja";
            this.adresastavnovanjaDataGridViewTextBoxColumn.HeaderText = "Adresa stanovanja";
            this.adresastavnovanjaDataGridViewTextBoxColumn.Name = "adresastavnovanjaDataGridViewTextBoxColumn";
            this.adresastavnovanjaDataGridViewTextBoxColumn.Width = 110;
            // 
            // brojtelefona1DataGridViewTextBoxColumn
            // 
            this.brojtelefona1DataGridViewTextBoxColumn.DataPropertyName = "broj_telefona1";
            this.brojtelefona1DataGridViewTextBoxColumn.HeaderText = "Broj telefona 1";
            this.brojtelefona1DataGridViewTextBoxColumn.Name = "brojtelefona1DataGridViewTextBoxColumn";
            this.brojtelefona1DataGridViewTextBoxColumn.Width = 84;
            // 
            // brojtelefona2DataGridViewTextBoxColumn
            // 
            this.brojtelefona2DataGridViewTextBoxColumn.DataPropertyName = "broj_telefona2";
            this.brojtelefona2DataGridViewTextBoxColumn.HeaderText = "Broj telefona 2";
            this.brojtelefona2DataGridViewTextBoxColumn.Name = "brojtelefona2DataGridViewTextBoxColumn";
            this.brojtelefona2DataGridViewTextBoxColumn.Width = 84;
            // 
            // emailDataGridViewTextBoxColumn
            // 
            this.emailDataGridViewTextBoxColumn.DataPropertyName = "email";
            this.emailDataGridViewTextBoxColumn.HeaderText = "Email";
            this.emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
            this.emailDataGridViewTextBoxColumn.Width = 57;
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
            this.uiPrikazZivotinja.AllowUserToResizeRows = false;
            this.uiPrikazZivotinja.AutoGenerateColumns = false;
            this.uiPrikazZivotinja.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.uiPrikazZivotinja.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
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
            this.uiPrikazZivotinja.Location = new System.Drawing.Point(387, 436);
            this.uiPrikazZivotinja.Name = "uiPrikazZivotinja";
            this.uiPrikazZivotinja.RowHeadersVisible = false;
            this.uiPrikazZivotinja.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.uiPrikazZivotinja.Size = new System.Drawing.Size(611, 125);
            this.uiPrikazZivotinja.TabIndex = 8;
            // 
            // iDzivotinjaDataGridViewTextBoxColumn
            // 
            this.iDzivotinjaDataGridViewTextBoxColumn.DataPropertyName = "ID_zivotinja";
            this.iDzivotinjaDataGridViewTextBoxColumn.HeaderText = "ID_zivotinja";
            this.iDzivotinjaDataGridViewTextBoxColumn.Name = "iDzivotinjaDataGridViewTextBoxColumn";
            this.iDzivotinjaDataGridViewTextBoxColumn.Visible = false;
            this.iDzivotinjaDataGridViewTextBoxColumn.Width = 86;
            // 
            // imeDataGridViewTextBoxColumn1
            // 
            this.imeDataGridViewTextBoxColumn1.DataPropertyName = "ime";
            this.imeDataGridViewTextBoxColumn1.HeaderText = "Ime";
            this.imeDataGridViewTextBoxColumn1.Name = "imeDataGridViewTextBoxColumn1";
            this.imeDataGridViewTextBoxColumn1.Width = 49;
            // 
            // spolDataGridViewTextBoxColumn
            // 
            this.spolDataGridViewTextBoxColumn.DataPropertyName = "spol";
            this.spolDataGridViewTextBoxColumn.HeaderText = "Spol";
            this.spolDataGridViewTextBoxColumn.Name = "spolDataGridViewTextBoxColumn";
            this.spolDataGridViewTextBoxColumn.Width = 53;
            // 
            // vrstaDataGridViewTextBoxColumn
            // 
            this.vrstaDataGridViewTextBoxColumn.DataPropertyName = "vrsta";
            this.vrstaDataGridViewTextBoxColumn.HeaderText = "Vrsta";
            this.vrstaDataGridViewTextBoxColumn.Name = "vrstaDataGridViewTextBoxColumn";
            this.vrstaDataGridViewTextBoxColumn.Width = 56;
            // 
            // datumrodenjaDataGridViewTextBoxColumn
            // 
            this.datumrodenjaDataGridViewTextBoxColumn.DataPropertyName = "datum_rodenja";
            this.datumrodenjaDataGridViewTextBoxColumn.HeaderText = "Datum rođenja";
            this.datumrodenjaDataGridViewTextBoxColumn.Name = "datumrodenjaDataGridViewTextBoxColumn";
            this.datumrodenjaDataGridViewTextBoxColumn.Width = 94;
            // 
            // brojcipaDataGridViewTextBoxColumn
            // 
            this.brojcipaDataGridViewTextBoxColumn.DataPropertyName = "broj_cipa";
            this.brojcipaDataGridViewTextBoxColumn.HeaderText = "Broj čipa";
            this.brojcipaDataGridViewTextBoxColumn.Name = "brojcipaDataGridViewTextBoxColumn";
            this.brojcipaDataGridViewTextBoxColumn.Width = 68;
            // 
            // tezinaDataGridViewTextBoxColumn
            // 
            this.tezinaDataGridViewTextBoxColumn.DataPropertyName = "tezina";
            this.tezinaDataGridViewTextBoxColumn.HeaderText = "Težina";
            this.tezinaDataGridViewTextBoxColumn.Name = "tezinaDataGridViewTextBoxColumn";
            this.tezinaDataGridViewTextBoxColumn.Width = 64;
            // 
            // datumuginucaDataGridViewTextBoxColumn
            // 
            this.datumuginucaDataGridViewTextBoxColumn.DataPropertyName = "datum_uginuca";
            this.datumuginucaDataGridViewTextBoxColumn.HeaderText = "Datum uginuća";
            this.datumuginucaDataGridViewTextBoxColumn.Name = "datumuginucaDataGridViewTextBoxColumn";
            this.datumuginucaDataGridViewTextBoxColumn.Width = 96;
            // 
            // iDvlasnikaDataGridViewTextBoxColumn
            // 
            this.iDvlasnikaDataGridViewTextBoxColumn.DataPropertyName = "ID_vlasnika";
            this.iDvlasnikaDataGridViewTextBoxColumn.HeaderText = "ID_vlasnika";
            this.iDvlasnikaDataGridViewTextBoxColumn.Name = "iDvlasnikaDataGridViewTextBoxColumn";
            this.iDvlasnikaDataGridViewTextBoxColumn.Visible = false;
            this.iDvlasnikaDataGridViewTextBoxColumn.Width = 109;
            // 
            // kontrolaDataGridViewTextBoxColumn
            // 
            this.kontrolaDataGridViewTextBoxColumn.DataPropertyName = "Kontrola";
            this.kontrolaDataGridViewTextBoxColumn.HeaderText = "Kontrola";
            this.kontrolaDataGridViewTextBoxColumn.Name = "kontrolaDataGridViewTextBoxColumn";
            this.kontrolaDataGridViewTextBoxColumn.Visible = false;
            this.kontrolaDataGridViewTextBoxColumn.Width = 90;
            // 
            // vlasnikDataGridViewTextBoxColumn
            // 
            this.vlasnikDataGridViewTextBoxColumn.DataPropertyName = "Vlasnik";
            this.vlasnikDataGridViewTextBoxColumn.HeaderText = "Vlasnik";
            this.vlasnikDataGridViewTextBoxColumn.Name = "vlasnikDataGridViewTextBoxColumn";
            this.vlasnikDataGridViewTextBoxColumn.Visible = false;
            this.vlasnikDataGridViewTextBoxColumn.Width = 82;
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
            this.uiActionDodajZivotinju.Location = new System.Drawing.Point(228, 436);
            this.uiActionDodajZivotinju.Margin = new System.Windows.Forms.Padding(2);
            this.uiActionDodajZivotinju.Name = "uiActionDodajZivotinju";
            this.uiActionDodajZivotinju.Size = new System.Drawing.Size(108, 39);
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
            this.uiActionAzurirajVlasnika.Location = new System.Drawing.Point(228, 177);
            this.uiActionAzurirajVlasnika.Margin = new System.Windows.Forms.Padding(2);
            this.uiActionAzurirajVlasnika.Name = "uiActionAzurirajVlasnika";
            this.uiActionAzurirajVlasnika.Size = new System.Drawing.Size(108, 40);
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
            this.uiDodajVlasnika.Location = new System.Drawing.Point(228, 246);
            this.uiDodajVlasnika.Margin = new System.Windows.Forms.Padding(2);
            this.uiDodajVlasnika.Name = "uiDodajVlasnika";
            this.uiDodajVlasnika.Size = new System.Drawing.Size(108, 40);
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
            this.uiIzbrisiVlasnika.Location = new System.Drawing.Point(228, 310);
            this.uiIzbrisiVlasnika.Margin = new System.Windows.Forms.Padding(2);
            this.uiIzbrisiVlasnika.Name = "uiIzbrisiVlasnika";
            this.uiIzbrisiVlasnika.Size = new System.Drawing.Size(108, 40);
            this.uiIzbrisiVlasnika.TabIndex = 12;
            this.uiIzbrisiVlasnika.Text = "Izbriši Vlasnika";
            this.uiIzbrisiVlasnika.UseVisualStyleBackColor = false;
            this.uiIzbrisiVlasnika.Click += new System.EventHandler(this.uiIzbrisiVlasnika_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.White;
            this.pictureBox2.Enabled = false;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(323, 123);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(17, 16);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 28;
            this.pictureBox2.TabStop = false;
            // 
            // uiFiltrirajVlasnike
            // 
            this.uiFiltrirajVlasnike.Location = new System.Drawing.Point(182, 121);
            this.uiFiltrirajVlasnike.Name = "uiFiltrirajVlasnike";
            this.uiFiltrirajVlasnike.Size = new System.Drawing.Size(162, 20);
            this.uiFiltrirajVlasnike.TabIndex = 27;
            this.uiFiltrirajVlasnike.TextChanged += new System.EventHandler(this.uiFiltrirajVlasnike_TextChanged);
            // 
            // uiActionPovijestBolesti
            // 
            this.uiActionPovijestBolesti.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(140)))), ((int)(((byte)(200)))));
            this.uiActionPovijestBolesti.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.uiActionPovijestBolesti.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.uiActionPovijestBolesti.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.uiActionPovijestBolesti.Location = new System.Drawing.Point(228, 494);
            this.uiActionPovijestBolesti.Margin = new System.Windows.Forms.Padding(2);
            this.uiActionPovijestBolesti.Name = "uiActionPovijestBolesti";
            this.uiActionPovijestBolesti.Size = new System.Drawing.Size(108, 39);
            this.uiActionPovijestBolesti.TabIndex = 29;
            this.uiActionPovijestBolesti.Text = "Povijest bolesti";
            this.uiActionPovijestBolesti.UseVisualStyleBackColor = false;
            this.uiActionPovijestBolesti.Click += new System.EventHandler(this.uiActionPovijestBolesti_Click);
            // 
            // frmVlasnici
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(212)))), ((int)(((byte)(249)))));
            this.ClientSize = new System.Drawing.Size(1008, 632);
            this.Controls.Add(this.uiActionPovijestBolesti);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.uiFiltrirajVlasnike);
            this.Controls.Add(this.uiIzbrisiVlasnika);
            this.Controls.Add(this.uiDodajVlasnika);
            this.Controls.Add(this.uiActionAzurirajVlasnika);
            this.Controls.Add(this.uiActionDodajZivotinju);
            this.Controls.Add(this.uiPrikazZivotinja);
            this.Controls.Add(this.uiPrikazVlasnika);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmVlasnici";
            this.Text = "Vlasnici";
            this.Controls.SetChildIndex(this.panel1, 0);
            this.Controls.SetChildIndex(this.uiPrikazVlasnika, 0);
            this.Controls.SetChildIndex(this.uiPrikazZivotinja, 0);
            this.Controls.SetChildIndex(this.uiActionDodajZivotinju, 0);
            this.Controls.SetChildIndex(this.uiActionAzurirajVlasnika, 0);
            this.Controls.SetChildIndex(this.uiDodajVlasnika, 0);
            this.Controls.SetChildIndex(this.uiIzbrisiVlasnika, 0);
            this.Controls.SetChildIndex(this.uiFiltrirajVlasnike, 0);
            this.Controls.SetChildIndex(this.pictureBox2, 0);
            this.Controls.SetChildIndex(this.uiActionPovijestBolesti, 0);
            ((System.ComponentModel.ISupportInitialize)(this.uiPrikazVlasnika)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vlasnikBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uiPrikazZivotinja)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.zivotinjaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView uiPrikazVlasnika;
        private System.Windows.Forms.BindingSource vlasnikBindingSource;
        private System.Windows.Forms.DataGridView uiPrikazZivotinja;
        private System.Windows.Forms.BindingSource zivotinjaBindingSource;
        private System.Windows.Forms.Button uiActionDodajZivotinju;
        private System.Windows.Forms.Button uiActionAzurirajVlasnika;
        private System.Windows.Forms.Button uiDodajVlasnika;
        private System.Windows.Forms.Button uiIzbrisiVlasnika;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDvlasnikDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn imeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn prezimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn adresastavnovanjaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn brojtelefona1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn brojtelefona2DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn zivotinjaDataGridViewTextBoxColumn;
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
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.TextBox uiFiltrirajVlasnike;
        private System.Windows.Forms.Button uiActionPovijestBolesti;
    }
}