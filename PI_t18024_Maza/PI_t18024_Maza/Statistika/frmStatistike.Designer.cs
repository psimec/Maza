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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
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
            chartArea1.Name = "ChartArea1";
            this.uiGraf.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.uiGraf.Legends.Add(legend1);
            this.uiGraf.Location = new System.Drawing.Point(293, 216);
            this.uiGraf.Name = "uiGraf";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Broj životinja";
            this.uiGraf.Series.Add(series1);
            this.uiGraf.Size = new System.Drawing.Size(539, 344);
            this.uiGraf.TabIndex = 2;
            this.uiGraf.Text = "chart1";
            // 
            // uiActionPrikaziGraf
            // 
            this.uiActionPrikaziGraf.Location = new System.Drawing.Point(242, 117);
            this.uiActionPrikaziGraf.Name = "uiActionPrikaziGraf";
            this.uiActionPrikaziGraf.Size = new System.Drawing.Size(89, 36);
            this.uiActionPrikaziGraf.TabIndex = 3;
            this.uiActionPrikaziGraf.Text = "Prikaži vrste životinja";
            this.uiActionPrikaziGraf.UseVisualStyleBackColor = true;
            this.uiActionPrikaziGraf.Click += new System.EventHandler(this.uiActionPrikaziGraf_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(162, 428);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(5, 81);
            this.panel1.TabIndex = 14;
            // 
            // uiActionPrikaziKontrole
            // 
            this.uiActionPrikaziKontrole.Location = new System.Drawing.Point(354, 117);
            this.uiActionPrikaziKontrole.Name = "uiActionPrikaziKontrole";
            this.uiActionPrikaziKontrole.Size = new System.Drawing.Size(89, 36);
            this.uiActionPrikaziKontrole.TabIndex = 15;
            this.uiActionPrikaziKontrole.Text = "Prikaži kontrole";
            this.uiActionPrikaziKontrole.UseVisualStyleBackColor = true;
            this.uiActionPrikaziKontrole.Click += new System.EventHandler(this.uiActionPrikaziKontrole_Click);
            // 
            // uiPrikaziCijepljenja
            // 
            this.uiPrikaziCijepljenja.Location = new System.Drawing.Point(463, 117);
            this.uiPrikaziCijepljenja.Name = "uiPrikaziCijepljenja";
            this.uiPrikaziCijepljenja.Size = new System.Drawing.Size(100, 36);
            this.uiPrikaziCijepljenja.TabIndex = 16;
            this.uiPrikaziCijepljenja.Text = "Prikaži cijepljenja po vrsti";
            this.uiPrikaziCijepljenja.UseVisualStyleBackColor = true;
            this.uiPrikaziCijepljenja.Click += new System.EventHandler(this.uiPrikaziCijepljenja_Click);
            // 
            // uiActionNajcesceBolesti
            // 
            this.uiActionNajcesceBolesti.Location = new System.Drawing.Point(582, 117);
            this.uiActionNajcesceBolesti.Name = "uiActionNajcesceBolesti";
            this.uiActionNajcesceBolesti.Size = new System.Drawing.Size(100, 36);
            this.uiActionNajcesceBolesti.TabIndex = 17;
            this.uiActionNajcesceBolesti.Text = "Prikaži najčešće bolesti";
            this.uiActionNajcesceBolesti.UseVisualStyleBackColor = true;
            this.uiActionNajcesceBolesti.Click += new System.EventHandler(this.uiActionNajcesceBolesti_Click);
            // 
            // frmStatistike
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 632);
            this.Controls.Add(this.uiActionNajcesceBolesti);
            this.Controls.Add(this.uiPrikaziCijepljenja);
            this.Controls.Add(this.uiActionPrikaziKontrole);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.uiActionPrikaziGraf);
            this.Controls.Add(this.uiGraf);
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