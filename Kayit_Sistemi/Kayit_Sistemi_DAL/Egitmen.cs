//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Kayit_Sistemi_DAL
{
    using System;
    using System.Collections.Generic;
    
    public partial class Egitmen
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Egitmen()
        {
            this.EgitmenMaasi = new HashSet<EgitmenMaasi>();
            this.Kurs = new HashSet<Kurs>();
        }
    
        public int KullaniciID { get; set; }
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public string TC { get; set; }
        public string Email { get; set; }
        public string CepTelefonu { get; set; }
        public string Adres { get; set; }
        public System.DateTime DogumTarihi { get; set; }
    
        public virtual Kullanici Kullanici { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<EgitmenMaasi> EgitmenMaasi { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Kurs> Kurs { get; set; }
    }
}
