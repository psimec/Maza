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
    
    public partial class Zivotinja
    {
        public Zivotinja()
        {
            this.kontrolas = new HashSet<kontrola>();
        }
    
        public int ID_zivotinja { get; set; }
        public string ime { get; set; }
        public string spol { get; set; }
        public string vrsta { get; set; }
        public System.DateTime datum_rodenja { get; set; }
        public Nullable<int> broj_cipa { get; set; }
        public int težina { get; set; }
        public Nullable<System.DateTime> datum_uginuca { get; set; }
        public int ID_vlasnik { get; set; }
    
        public virtual ICollection<kontrola> kontrolas { get; set; }
        public virtual vlasnik vlasnik { get; set; }
    }
}
