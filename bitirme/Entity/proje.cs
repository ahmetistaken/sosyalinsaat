//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace bitirme.Entity
{
    using System;
    using System.Collections.Generic;
    
    public partial class proje
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public proje()
        {
            this.ilan = new HashSet<ilan>();
        }
    
        public int ID { get; set; }
        public int miteahhitID { get; set; }
        public string ad { get; set; }
        public string adres { get; set; }
        public Nullable<int> isSayisi { get; set; }
        public string foto { get; set; }
    
        public virtual muteahhit muteahhit { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ilan> ilan { get; set; }
    }
}