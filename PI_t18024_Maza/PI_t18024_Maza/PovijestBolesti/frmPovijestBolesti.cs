﻿using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PI_t18024_Maza
{
    public partial class frmPovijestBolesti : Form
    {
        #region Globalne varijable

        private Zivotinja zivotinja;

        #endregion

        #region Konstruktor

        /// <summary>
        /// Konstrukor forme Povijest bolesti
        /// </summary>
        /// <param name="zivotinja"> Proslijedena zivotinja </param>

        public frmPovijestBolesti(Zivotinja zivotinja)
        {
            InitializeComponent();
            this.zivotinja = zivotinja;
            this.StartPosition = FormStartPosition.CenterScreen;
            korisnickaPodrska.SetShowHelp(this, true);
            korisnickaPodrska.HelpNamespace = "https://github.com/foivz/r18024/blob/master/Datoteke/Korisnicka_dokumentacija/Korisnicka_dokumentacija.pdf";
        }

        #endregion

        #region Dogadaji

        private void povijestBolesti_Load(object sender, EventArgs e)
        {
            _18024_DBDataSet.EnforceConstraints = false;
            // TODO: This line of code loads data into the '_18024_DBDataSet.PovijestBolesti' table. You can move, or remove it, as needed.
            this.PovijestBolestiTableAdapter.FillByZivotinjaID(this._18024_DBDataSet.PovijestBolesti, zivotinja.ID_zivotinja);
            // TODO: This line of code loads data into the '_18024_DBDataSet.vlasnik' table. You can move, or remove it, as needed.
            this.vlasnikTableAdapter.FillByZivotinjaId(this._18024_DBDataSet.vlasnik, zivotinja.ID_zivotinja);
            // TODO: This line of code loads data into the '_18024_DBDataSet.zivotinja' table. You can move, or remove it, as needed.
            this.zivotinjaTableAdapter.FillByZivotinjaId(this._18024_DBDataSet.zivotinja, zivotinja.ID_zivotinja);

            this.reportViewer1.RefreshReport();
        }

        #endregion
    }
}
