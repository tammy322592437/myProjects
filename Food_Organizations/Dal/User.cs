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
    
    public partial class User
    {
        public int User_kod { get; set; }
        public string First_Name { get; set; }
        public string Last_Name { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public string HomeTown { get; set; }
        public string Telephone { get; set; }
        public bool Is_Active { get; set; }
        public int User_Type { get; set; }
        public int OrganizationKod { get; set; }
        public Nullable<int> TypeMessage { get; set; }
    
        public virtual Needy Needy { get; set; }
        public virtual Organization Organization { get; set; }
        public virtual Organizer Organizer { get; set; }
        public virtual Volunteer Volunteer { get; set; }
    }
}