namespace PI_t18024_Maza
{
    partial class frmDizajnDijagnoza
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDizajnDijagnoza));
            this.ZaglavljePanel = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.uiActionClose = new System.Windows.Forms.Button();
            this.korisnickaPodrska = new System.Windows.Forms.HelpProvider();
            this.ZaglavljePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // ZaglavljePanel
            // 
            this.ZaglavljePanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(119)))), ((int)(((byte)(183)))));
            this.ZaglavljePanel.Controls.Add(this.pictureBox1);
            this.ZaglavljePanel.Controls.Add(this.uiActionClose);
            this.ZaglavljePanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.ZaglavljePanel.Location = new System.Drawing.Point(0, 0);
            this.ZaglavljePanel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ZaglavljePanel.Name = "ZaglavljePanel";
            this.ZaglavljePanel.Size = new System.Drawing.Size(825, 100);
            this.ZaglavljePanel.TabIndex = 2;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(4, -2);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(135, 98);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // uiActionClose
            // 
            this.uiActionClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.uiActionClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.uiActionClose.FlatAppearance.BorderSize = 0;
            this.uiActionClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.uiActionClose.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uiActionClose.Location = new System.Drawing.Point(780, 4);
            this.uiActionClose.Margin = new System.Windows.Forms.Padding(3, 10, 11, 2);
            this.uiActionClose.Name = "uiActionClose";
            this.uiActionClose.Size = new System.Drawing.Size(35, 48);
            this.uiActionClose.TabIndex = 1;
            this.uiActionClose.Text = "X";
            this.uiActionClose.UseVisualStyleBackColor = true;
            this.uiActionClose.Click += new System.EventHandler(this.uiActionClose_Click);
            // 
            // frmDizajnDijagnoza
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(212)))), ((int)(((byte)(249)))));
            this.CancelButton = this.uiActionClose;
            this.ClientSize = new System.Drawing.Size(825, 816);
            this.Controls.Add(this.ZaglavljePanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmDizajnDijagnoza";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DijagnozaDizajn";
            this.ZaglavljePanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel ZaglavljePanel;
        private System.Windows.Forms.Button uiActionClose;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.HelpProvider korisnickaPodrska;
    }
}