namespace PI_t18024_Maza
{
    partial class frmZivotinje
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.uiPrikazZivotinja = new System.Windows.Forms.DataGridView();
            this.uiActionDodajZivotinju = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.uiPrikazZivotinja)).BeginInit();
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
            this.uiPrikazZivotinja.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.uiPrikazZivotinja.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(212)))), ((int)(((byte)(249)))));
            this.uiPrikazZivotinja.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.uiPrikazZivotinja.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.uiPrikazZivotinja.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.uiPrikazZivotinja.Location = new System.Drawing.Point(229, 106);
            this.uiPrikazZivotinja.Name = "uiPrikazZivotinja";
            this.uiPrikazZivotinja.ReadOnly = true;
            this.uiPrikazZivotinja.RowHeadersVisible = false;
            this.uiPrikazZivotinja.RowTemplate.Height = 24;
            this.uiPrikazZivotinja.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.uiPrikazZivotinja.Size = new System.Drawing.Size(1091, 382);
            this.uiPrikazZivotinja.TabIndex = 4;
            this.uiPrikazZivotinja.ColumnHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.uiPrikazZivotinja_ColumnHeaderMouseClick);
            // 
            // uiActionDodajZivotinju
            // 
            this.uiActionDodajZivotinju.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(140)))), ((int)(((byte)(200)))));
            this.uiActionDodajZivotinju.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.uiActionDodajZivotinju.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.uiActionDodajZivotinju.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.uiActionDodajZivotinju.Location = new System.Drawing.Point(1165, 524);
            this.uiActionDodajZivotinju.Name = "uiActionDodajZivotinju";
            this.uiActionDodajZivotinju.Size = new System.Drawing.Size(135, 44);
            this.uiActionDodajZivotinju.TabIndex = 10;
            this.uiActionDodajZivotinju.Text = "Dodaj Životinju";
            this.uiActionDodajZivotinju.UseVisualStyleBackColor = false;
            this.uiActionDodajZivotinju.Click += new System.EventHandler(this.uiActionDodajZivotinju_Click);
            // 
            // frmZivotinje
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1344, 778);
            this.Controls.Add(this.uiActionDodajZivotinju);
            this.Controls.Add(this.uiPrikazZivotinja);
            this.Controls.Add(this.panel1);
            this.Name = "frmZivotinje";
            this.Text = "Zivotinje";
            this.Load += new System.EventHandler(this.Zivotinje_Load);
            this.Controls.SetChildIndex(this.panel1, 0);
            this.Controls.SetChildIndex(this.uiPrikazZivotinja, 0);
            this.Controls.SetChildIndex(this.uiActionDodajZivotinju, 0);
            ((System.ComponentModel.ISupportInitialize)(this.uiPrikazZivotinja)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private _18024_DBDataSet _18024_DBDataSet;
        private System.Windows.Forms.DataGridView uiPrikazZivotinja;
        private System.Windows.Forms.Button uiActionDodajZivotinju;
    }
}