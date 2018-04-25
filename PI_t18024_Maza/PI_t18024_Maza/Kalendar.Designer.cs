namespace PI_t18024_Maza
{
    partial class Kalendar
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
            Calendar.DrawTool drawTool1 = new Calendar.DrawTool();
            this.panel1 = new System.Windows.Forms.Panel();
            this.uiActionOdjava = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.uiKalendar = new Calendar.DayView();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel1.Controls.Add(this.uiActionOdjava);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1008, 45);
            this.panel1.TabIndex = 0;
            // 
            // uiActionOdjava
            // 
            this.uiActionOdjava.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.uiActionOdjava.FlatAppearance.BorderSize = 0;
            this.uiActionOdjava.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.uiActionOdjava.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.uiActionOdjava.Location = new System.Drawing.Point(922, 10);
            this.uiActionOdjava.Name = "uiActionOdjava";
            this.uiActionOdjava.Size = new System.Drawing.Size(81, 28);
            this.uiActionOdjava.TabIndex = 2;
            this.uiActionOdjava.Text = "Odjava";
            this.uiActionOdjava.UseVisualStyleBackColor = false;
            this.uiActionOdjava.Click += new System.EventHandler(this.uiActionOdjava_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel2.Controls.Add(this.button4);
            this.panel2.Controls.Add(this.button3);
            this.panel2.Controls.Add(this.button2);
            this.panel2.Controls.Add(this.button1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 45);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(140, 587);
            this.panel2.TabIndex = 1;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button4.Location = new System.Drawing.Point(0, 240);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(140, 37);
            this.button4.TabIndex = 3;
            this.button4.Text = "Kontrola";
            this.button4.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button3.Location = new System.Drawing.Point(0, 180);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(140, 37);
            this.button3.TabIndex = 2;
            this.button3.Text = "Vlasnici";
            this.button3.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button2.Location = new System.Drawing.Point(0, 120);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(140, 37);
            this.button2.TabIndex = 1;
            this.button2.Text = "Životinje";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button1.Location = new System.Drawing.Point(0, 60);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(140, 37);
            this.button1.TabIndex = 0;
            this.button1.Text = "Kalendar";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // uiKalendar
            // 
            drawTool1.DayView = this.uiKalendar;
            this.uiKalendar.ActiveTool = drawTool1;
            this.uiKalendar.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.uiKalendar.DaysToShow = 5;
            this.uiKalendar.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.uiKalendar.Location = new System.Drawing.Point(137, 45);
            this.uiKalendar.Name = "uiKalendar";
            this.uiKalendar.SelectionEnd = new System.DateTime(((long)(0)));
            this.uiKalendar.SelectionStart = new System.DateTime(((long)(0)));
            this.uiKalendar.Size = new System.Drawing.Size(871, 587);
            this.uiKalendar.StartDate = new System.DateTime(((long)(0)));
            this.uiKalendar.TabIndex = 2;
            this.uiKalendar.Text = "dayView1";
            this.uiKalendar.WorkingHourEnd = 20;
            // 
            // Kalendar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 632);
            this.Controls.Add(this.uiKalendar);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Kalendar";
            this.Text = "Kalendar";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button uiActionOdjava;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private Calendar.DayView uiKalendar;
    }
}

