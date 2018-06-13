﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PI_t18024_Maza
{
    public partial class frmDodajZivotinju : Form
    {
        Vlasnik vlasnik;
        public frmDodajZivotinju(Vlasnik vlasnik)
        {
            this.vlasnik = vlasnik;
            InitializeComponent();
            uiOdabirSpola.Items.Add("m");
            uiOdabirSpola.Items.Add("ž");
        }

        private void DodajZivotinjuForm_Load(object sender, EventArgs e)
        {
        }

        private void uiVrsta_TextChanged(object sender, EventArgs e)
        {
            if(uiVrsta.Text == "Pas")
            {
                lblBrojCipa.Visible = true;
                uiBrojCipa.Visible = true;
            }
        }
    }
}
