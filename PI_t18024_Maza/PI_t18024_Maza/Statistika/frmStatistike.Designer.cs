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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.uiGraf = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.uiActionPrikaziGraf = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.uiGraf)).BeginInit();
            this.SuspendLayout();
            // 
            // uiGraf
            // 
            chartArea3.Name = "ChartArea1";
            this.uiGraf.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            this.uiGraf.Legends.Add(legend3);
            this.uiGraf.Location = new System.Drawing.Point(293, 216);
            this.uiGraf.Name = "uiGraf";
            series3.ChartArea = "ChartArea1";
            series3.Legend = "Legend1";
            series3.Name = "Broj životinja";
            this.uiGraf.Series.Add(series3);
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
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(162, 428);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(5, 81);
            this.panel1.TabIndex = 14;
            // 
            // frmStatistike
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 632);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.uiActionPrikaziGraf);
            this.Controls.Add(this.uiGraf);
            this.Name = "frmStatistike";
            this.Text = "frmStatistike";
            this.Controls.SetChildIndex(this.uiGraf, 0);
            this.Controls.SetChildIndex(this.uiActionPrikaziGraf, 0);
            this.Controls.SetChildIndex(this.panel1, 0);
            ((System.ComponentModel.ISupportInitialize)(this.uiGraf)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart uiGraf;
        private System.Windows.Forms.Button uiActionPrikaziGraf;
        private System.Windows.Forms.Panel panel1;
    }
}