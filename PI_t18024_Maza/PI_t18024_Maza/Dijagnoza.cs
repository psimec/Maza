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
    
    public partial class dijagnoza
    {
        public dijagnoza()
        {
            this.propisani_lijek = new HashSet<propisani_lijek>();
        }
    
        public int ID_dijagnoza { get; set; }
        public string simptomi { get; set; }
        public string naziv_bolesti { get; set; }
        public string terapija { get; set; }
        public string napomena { get; set; }
        public int ID_kontrola { get; set; }
        public int ID_bolest { get; set; }
    
        public virtual bolest bolest { get; set; }
        public virtual kontrola kontrola { get; set; }
        public virtual ICollection<propisani_lijek> propisani_lijek { get; set; }
    }
}
