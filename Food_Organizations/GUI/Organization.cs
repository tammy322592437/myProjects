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
    
    public partial class Organization
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Organization()
        {
            this.Epicenter1 = new HashSet<Epicenter>();
            this.Meals_Menu = new HashSet<Meals_Menu>();
            this.Organization_Days1 = new HashSet<Organization_Days>();
            this.Selected_Menu_For_Help = new HashSet<Selected_Menu_For_Help>();
            this.Volunteer_Organizations = new HashSet<Volunteer_Organizations>();
        }
    
        public int Organization_Kod { get; set; }
        public string Organization_Name { get; set; }
        public string Organization_City { get; set; }
        public int Organizer_Kod { get; set; }
        public string Organization_Logo { get; set; }
        public string Organization_Describe { get; set; }
        public int Organization_Days { get; set; }
        public int Epicenter { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Epicenter> Epicenter1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Meals_Menu> Meals_Menu { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Organization_Days> Organization_Days1 { get; set; }
        public virtual Organizer Organizer { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Selected_Menu_For_Help> Selected_Menu_For_Help { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Volunteer_Organizations> Volunteer_Organizations { get; set; }
    }
}
