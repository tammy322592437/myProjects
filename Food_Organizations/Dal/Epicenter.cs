//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Dal
{
    using System;
    using System.Collections.Generic;
    
    public partial class Epicenter
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Epicenter()
        {
            this.Volunteer_Organizations = new HashSet<Volunteer_Organizations>();
        }
    
        public int Organization_Kod { get; set; }
        public int Epicenter_Kod { get; set; }
        public string Epicenter_name { get; set; }
        public string Epicenter_Address { get; set; }
        public System.TimeSpan Pickup_Time { get; set; }
    
        public virtual Organization Organization { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Volunteer_Organizations> Volunteer_Organizations { get; set; }
    }
}