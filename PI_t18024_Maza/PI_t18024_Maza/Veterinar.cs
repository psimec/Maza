//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace PI_t18024_Maza
{
    using System;
    using System.Collections.Generic;
    
    public partial class Veterinar
    {
        public Veterinar()
        {
            this.Kontrola = new HashSet<Kontrola>();
        }
    
        public int ID_veterinar { get; set; }
        public string ime { get; set; }
        public string prezime { get; set; }
        public string adresa_stanovanja { get; set; }
        public string broj_telefona1 { get; set; }
        public string broj_telefona2 { get; set; }
        public string titula { get; set; }
        public System.DateTime datum_zaposlenja { get; set; }
        public System.DateTime datum_rodenja { get; set; }
        public string korime { get; set; }
        public string lozinka { get; set; }
    
        public virtual ICollection<Kontrola> Kontrola { get; set; }
    }
}
