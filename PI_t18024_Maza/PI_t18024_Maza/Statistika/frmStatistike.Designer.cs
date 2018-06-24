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
            this.uiActionPrikaziGraf.Location = new System.Drawing.Point(780, 131);
            this.uiActionPrikaziGraf.Name = "uiActionPrikaziGraf";
            this.uiActionPrikaziGraf.Size = new System.Drawing.Size(75, 23);
            this.uiActionPrikaziGraf.TabIndex = 3;
            this.uiActionPrikaziGraf.Text = "Prikaži graf";
            this.uiActionPrikaziGraf.UseVisualStyleBackColor = true;
            this.uiActionPrikaziGraf.Click += new System.EventHandler(this.uiActionPrikaziGraf_Click);
            // 
            // frmStatistike
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 632);
            this.Controls.Add(this.uiActionPrikaziGraf);
            this.Controls.Add(this.uiGraf);
            this.Name = "frmStatistike";
            this.Text = "frmStatistike";
            this.Controls.SetChildIndex(this.uiGraf, 0);
            this.Controls.SetChildIndex(this.uiActionPrikaziGraf, 0);
            ((System.ComponentModel.ISupportInitialize)(this.uiGraf)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart uiGraf;
        private System.Windows.Forms.Button uiActionPrikaziGraf;
    }
}