//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WindowsFormsApp1
{
    using System;
    using System.Collections.Generic;
    
    public partial class registryRecord
    {
        public int ID { get; set; }
        public Nullable<int> titleID { get; set; }
        public string firstName { get; set; }
        public string middleName { get; set; }
        public string lastName { get; set; }
        public string district { get; set; }
        public string poBox { get; set; }
        public string gender { get; set; }
        public Nullable<System.DateTime> dateOfBirth { get; set; }
        public Nullable<int> parishID { get; set; }
    
        public virtual difParish difParish { get; set; }
        public virtual typeofTitle typeofTitle { get; set; }
    }
}