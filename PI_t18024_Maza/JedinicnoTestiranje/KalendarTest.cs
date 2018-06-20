using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PI_t18024_Maza;

namespace JedinicnoTestiranje
{
    [TestClass]
    public class KalendarTest
    {
        [TestMethod]
        public void OdrediTjedanTest()
        {    
            //ARRANGE
            frmKalendar frmKalendar = new frmKalendar();

            //ACT
            frmKalendar.OdrediTjedan(new DateTime(2018, 6, 19).Date);
            
            //ASSERT
            Assert.IsTrue(frmKalendar.datumOd == new DateTime(2018, 6, 18).Date && frmKalendar.datumDo == new DateTime(2018, 6, 24).Date);
        }

        [TestMethod]
        public void KreirajAktivnostTest()
        {
            //ARRANGE
            frmKalendar frmKalendar = new frmKalendar();

            using(var db = new MazaEntities())
            {
                Kontrola kontrola = db.Kontrola.FirstOrDefault();

                //ACT
                var test = frmKalendar.KreirajAkrivnost(kontrola);

                //ASSERT
                Assert.IsTrue(test != null && test.Text != "");
            }        
        }
    }
}
