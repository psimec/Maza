using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PI_t18024_Maza;

namespace JedinicnoTestiranje
{
    [TestClass]
    public class ValidacijaDodavanjaVlasnikaTest
    {
        [TestMethod]
        public void ValidacijaUnosa1()
        {
            PI_t18024_Maza.frmAzurirajVlasnike azurirajVlasnike1 = new frmAzurirajVlasnike();
            bool validacija1 = azurirajVlasnike1.ValidacijaVlasnika("Marko", "Markić","Ulica 1232");
            Assert.AreEqual(true, validacija1, "Unos je ispravan");
        }
        [TestMethod]
        public void ValidacijaUnosa2()
        {
            PI_t18024_Maza.frmAzurirajVlasnike azurirajVlasnike1 = new frmAzurirajVlasnike();
            bool validacija2 = azurirajVlasnike1.ValidacijaVlasnika("123", "Markić", "Ulica 1232");
            Assert.AreEqual(false, validacija2, "Unos je ispravan");
        }
    }
}
