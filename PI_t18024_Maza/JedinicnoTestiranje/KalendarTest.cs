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
            frmKalendar frmKalendar = new frmKalendar();

            DateTime datumOd = DateTime.Now;
            DateTime datumDo = DateTime.Now;

            frmKalendar.OdrediTjedan(new DateTime(2018, 6, 19).Date);


            Assert.IsTrue(datumOd.Date == new DateTime(2018, 6, 18).Date && datumDo.Date == new DateTime(2018, 6, 24).Date);
        }
    }
}
