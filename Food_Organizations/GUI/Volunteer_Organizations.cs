//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace GUI
{
    using System;
    using System.Collections.Generic;
    
    public partial class Volunteer_Organizations
    {
        public int Organization_Kod { get; set; }
        public int Volunteer_Kod { get; set; }
        public int Epicenter_Kod { get; set; }
        public int Volunteer_Organizations_Kod { get; set; }
    
        public virtual Epicenter Epicenter { get; set; }
        public virtual Organization Organization { get; set; }
        public virtual Volunteer Volunteer { get; set; }
    }
}
