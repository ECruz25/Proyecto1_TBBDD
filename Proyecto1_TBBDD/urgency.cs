//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Proyecto1_TBBDD
{
    using System;
    using System.Collections.Generic;
    
    public partial class urgency
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public urgency()
        {
            this.incidents = new HashSet<incident>();
        }
    
        public int UrgencyID { get; set; }
        public string UrgencyName { get; set; }
        public string UrgencyDescription { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<incident> incidents { get; set; }
    }
}
