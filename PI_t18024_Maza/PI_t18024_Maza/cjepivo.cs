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
    
    public partial class Cjepivo
    {
        public Cjepivo()
        {
            this.Kontrola = new HashSet<Kontrola>();
        }
    
        public int IdCjepivo { get; set; }
        public string Ime { get; set; }
        public double Doza { get; set; }
        public string Proizvodac { get; set; }
        public System.DateTime RokTrajanja { get; set; }
        public double Cijena { get; set; }
    
        public virtual ICollection<Kontrola> Kontrola { get; set; }
    }
}