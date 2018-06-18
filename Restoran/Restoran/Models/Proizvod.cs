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
    
    public partial class Proizvod
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Proizvod()
        {
            this.StavkaPorudzbenices = new HashSet<StavkaPorudzbenice>();
            this.StavkaRacunas = new HashSet<StavkaRacuna>();
        }
    
        public int Id { get; set; }
        public string Naziv { get; set; }
        public int Lager { get; set; }
        public int Cena { get; set; }
    
        public virtual Jelo Jelo { get; set; }
        public virtual Pice Pice { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<StavkaPorudzbenice> StavkaPorudzbenices { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<StavkaRacuna> StavkaRacunas { get; set; }
    }
}