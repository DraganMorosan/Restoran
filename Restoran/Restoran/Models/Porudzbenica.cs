//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Restoran.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Porudzbenica
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Porudzbenica()
        {
            this.StavkaPorudzbenices = new HashSet<StavkaPorudzbenice>();
        }
    
        public int Id { get; set; }
        public int DobavljacId { get; set; }
    
        public virtual Dobavljac Dobavljac { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<StavkaPorudzbenice> StavkaPorudzbenices { get; set; }
    }
}
