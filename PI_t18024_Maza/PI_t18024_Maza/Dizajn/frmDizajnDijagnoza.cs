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
    public partial class frmDizajnDijagnoza : Form
    {
        public frmDizajnDijagnoza()
        {
            InitializeComponent();
            korisnickaPodrska.SetShowHelp(this, true);
            korisnickaPodrska.HelpNamespace = "https://github.com/foivz/r18024/blob/master/Datoteke/Korisnicka_dokumentacija/Korisnicka_dokumentacija.pdf";
        }

        private void uiActionClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
