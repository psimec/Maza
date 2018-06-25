using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PI_t18024_Maza;

namespace JedinicnoTestiranje
{
    [TestClass]
    public class DetaljiKontroleTest
    {
        [TestMethod]
        public void FormaDetaljiKontroleTest()
        {
            //ARRANGE
            Kontrola kontrolaTest = new Kontrola();
            kontrolaTest.ID_kontrola = 7;
            kontrolaTest.ID_veterinar = 2;
            kontrolaTest.ID_zivotinja = 3;
            kontrolaTest.status = "Obavljen";
            kontrolaTest.opis = "Kontrola";

            //ACT
            frmDetaljiKontrole detaljiKontroleTest = new frmDetaljiKontrole(kontrolaTest);
            

            //ASSERT
            Assert.IsTrue(detaljiKontroleTest.status);
            Assert.AreEqual(3, detaljiKontroleTest.zivotinja.ID_zivotinja);
            Assert.AreEqual(2, detaljiKontroleTest.vlasnik.ID_vlasnik);
        }
    }
}
