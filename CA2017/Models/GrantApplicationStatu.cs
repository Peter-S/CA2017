//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CA2017.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class GrantApplicationStatu
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public GrantApplicationStatu()
        {
            this.GrantApplications = new HashSet<GrantApplication>();
        }
    
        public int GrantApplicationStatusKey { get; set; }
        public string GrantApplicationStatusTerm { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<GrantApplication> GrantApplications { get; set; }
    }
}
