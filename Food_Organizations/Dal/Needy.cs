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
    
    public partial class Needy
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Needy()
        {
            this.Selected_Menu_For_Help = new HashSet<Selected_Menu_For_Help>();
        }
    
        public int Needy_Kod { get; set; }
        public int Number_Of_Persons { get; set; }
        public Nullable<System.DateTime> ExpireDate { get; set; }
        public string NeedyDescribe { get; set; }
        public Nullable<int> AmountToHelp { get; set; }
        public Nullable<int> QuantityUsed { get; set; }
    
        public virtual User User { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Selected_Menu_For_Help> Selected_Menu_For_Help { get; set; }
    }
}
