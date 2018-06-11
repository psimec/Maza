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
    public partial class NovaKontrola : Form
    {
        public NovaKontrola()
        {
            InitializeComponent();
        }

        private void NovaKontrola_Load(object sender, EventArgs e)
        {
            using (var db = new MazaEntities())
            {
                uiOdabirVeterinar.DataSource = db.Veterinar.ToList();
                uiOdabirVeterinar.DisplayMember = "Ime";
                uiOdabirVeterinar.ValueMember = "ID_Veterinar";

                uiOdabirZivotinja.DataSource = db.Zivotinja.ToList();
                uiOdabirZivotinja.DisplayMember = "Ime";
                uiOdabirZivotinja.ValueMember = "ID_Zivotinja";

                uiOdabirStatus.SelectedIndex = 1;
            }    
        }

        private void uiActionOdustani_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void uiActionUredu_Click(object sender, EventArgs e)
        {
            if (uiOdabirStatus.Text != "" && uiUnosOpis.Text != "" )
            {
                using (var db = new MazaEntities())
                {
                    Zivotinja zivotinja = uiOdabirZivotinja.SelectedItem as Zivotinja;
                    Veterinar veterinar = uiOdabirVeterinar.SelectedItem as Veterinar;

                    MessageBox.Show(zivotinja.IdZivotinja.ToString());

                    db.Zivotinja.Attach(zivotinja);
                    db.Veterinar.Attach(veterinar);

                    Kontrola kontrola = new Kontrola
                    {
                        IdVeterinar = veterinar.IdVeterinar,
                        IdZivotinja = zivotinja.IdZivotinja,
                        DatumKontrole = uiOdabirDatum.Value,
                        Status = uiOdabirStatus.Text,
                        Opis = uiUnosOpis.Text,
                        Zivotinja = zivotinja,
                        Veterinar = veterinar
                    };

                    db.Kontrola.Add(kontrola);
                    db.SaveChanges();
                }
                this.Close();
            }
            else
            {
                return;
            }     
        }
    }
}
