namespace PI_t18024_Maza
{
    partial class frmStatistike
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.uiGraf = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.uiActionPrikaziGraf = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.uiActionPrikaziKontrole = new System.Windows.Forms.Button();
            this.uiPrikaziCijepljenja = new System.Windows.Forms.Button();
            this.uiActionNajcesceBolesti = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.uiGraf)).BeginInit();
            this.SuspendLayout();
            // 
            // uiGraf
            // 
            chartArea2.Name = "ChartArea1";
            this.uiGraf.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.uiGraf.Legends.Add(legend2);
            this.uiGraf.Location = new System.Drawing.Point(391, 266);
            this.uiGraf.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.uiGraf.Name = "uiGraf";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Broj životinja";
            this.uiGraf.Series.Add(series2);
            this.uiGraf.Size = new System.Drawing.Size(719, 423);
            this.uiGraf.TabIndex = 2;
            this.uiGraf.Text = "chart1";
            // 
            // uiActionPrikaziGraf
            // 
            this.uiActionPrikaziGraf.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(119)))), ((int)(((byte)(183)))));
            this.uiActionPrikaziGraf.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.uiActionPrikaziGraf.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.uiActionPrikaziGraf.Location = new System.Drawing.Point(391, 138);
            this.uiActionPrikaziGraf.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.uiActionPrikaziGraf.Name = "uiActionPrikaziGraf";
            this.uiActionPrikaziGraf.Size = new System.Drawing.Size(139, 55);
            this.uiActionPrikaziGraf.TabIndex = 3;
            this.uiActionPrikaziGraf.Text = "Prikaži vrste životinja";
            this.uiActionPrikaziGraf.UseVisualStyleBackColor = false;
            this.uiActionPrikaziGraf.Click += new System.EventHandler(this.uiActionPrikaziGraf_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(216, 527);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(7, 100);
            this.panel1.TabIndex = 14;
            // 
            // uiActionPrikaziKontrole
            // 
            this.uiActionPrikaziKontrole.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(119)))), ((int)(((byte)(183)))));
            this.uiActionPrikaziKontrole.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.uiActionPrikaziKontrole.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.uiActionPrikaziKontrole.Location = new System.Drawing.Point(576, 138);
            this.uiActionPrikaziKontrole.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.uiActionPrikaziKontrole.Name = "uiActionPrikaziKontrole";
            this.uiActionPrikaziKontrole.Size = new System.Drawing.Size(139, 55);
            this.uiActionPrikaziKontrole.TabIndex = 15;
            this.uiActionPrikaziKontrole.Text = "Prikaži kontrole";
            this.uiActionPrikaziKontrole.UseVisualStyleBackColor = false;
            this.uiActionPrikaziKontrole.Click += new System.EventHandler(this.uiActionPrikaziKontrole_Click);
            // 
            // uiPrikaziCijepljenja
            // 
            this.uiPrikaziCijepljenja.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(119)))), ((int)(((byte)(183)))));
            this.uiPrikaziCijepljenja.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.uiPrikaziCijepljenja.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.uiPrikaziCijepljenja.Location = new System.Drawing.Point(758, 138);
            this.uiPrikaziCijepljenja.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.uiPrikaziCijepljenja.Name = "uiPrikaziCijepljenja";
            this.uiPrikaziCijepljenja.Size = new System.Drawing.Size(153, 55);
            this.uiPrikaziCijepljenja.TabIndex = 16;
            this.uiPrikaziCijepljenja.Text = "Prikaži cijepljenja po vrsti";
            this.uiPrikaziCijepljenja.UseVisualStyleBackColor = false;
            this.uiPrikaziCijepljenja.Click += new System.EventHandler(this.uiPrikaziCijepljenja_Click);
            // 
            // uiActionNajcesceBolesti
            // 
            this.uiActionNajcesceBolesti.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(119)))), ((int)(((byte)(183)))));
            this.uiActionNajcesceBolesti.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.uiActionNajcesceBolesti.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.uiActionNajcesceBolesti.Location = new System.Drawing.Point(957, 138);
            this.uiActionNajcesceBolesti.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.uiActionNajcesceBolesti.Name = "uiActionNajcesceBolesti";
            this.uiActionNajcesceBolesti.Size = new System.Drawing.Size(153, 55);
            this.uiActionNajcesceBolesti.TabIndex = 17;
            this.uiActionNajcesceBolesti.Text = "Prikaži najčešće bolesti";
            this.uiActionNajcesceBolesti.UseVisualStyleBackColor = false;
            this.uiActionNajcesceBolesti.Click += new System.EventHandler(this.uiActionNajcesceBolesti_Click);
            // 
            // frmStatistike
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1344, 778);
            this.Controls.Add(this.uiActionNajcesceBolesti);
            this.Controls.Add(this.uiPrikaziCijepljenja);
            this.Controls.Add(this.uiActionPrikaziKontrole);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.uiActionPrikaziGraf);
            this.Controls.Add(this.uiGraf);
            this.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.Name = "frmStatistike";
            this.Text = "frmStatistike";
            this.Load += new System.EventHandler(this.frmStatistike_Load);
            this.Controls.SetChildIndex(this.uiGraf, 0);
            this.Controls.SetChildIndex(this.uiActionPrikaziGraf, 0);
            this.Controls.SetChildIndex(this.panel1, 0);
            this.Controls.SetChildIndex(this.uiActionPrikaziKontrole, 0);
            this.Controls.SetChildIndex(this.uiPrikaziCijepljenja, 0);
            this.Controls.SetChildIndex(this.uiActionNajcesceBolesti, 0);
            ((System.ComponentModel.ISupportInitialize)(this.uiGraf)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart uiGraf;
        private System.Windows.Forms.Button uiActionPrikaziGraf;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button uiActionPrikaziKontrole;
        private System.Windows.Forms.Button uiPrikaziCijepljenja;
        private System.Windows.Forms.Button uiActionNajcesceBolesti;
    }
}