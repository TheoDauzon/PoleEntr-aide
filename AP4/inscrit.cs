//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré à partir d'un modèle.
//
//     Des modifications manuelles apportées à ce fichier peuvent conduire à un comportement inattendu de votre application.
//     Les modifications manuelles apportées à ce fichier sont remplacées si le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace AP4
{
    using System;
    using System.Collections.Generic;
    
    public partial class inscrit
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public inscrit()
        {
            this.message = new HashSet<message>();
            this.repondre = new HashSet<repondre>();
            this.service = new HashSet<service>();
        }
    
        public int IDINSCRIT { get; set; }
        public string NOMINSCRIT { get; set; }
        public string PRENOMINSCRIT { get; set; }
        public string MAIL { get; set; }
        public string MDPINSCRIT { get; set; }
        public string TELINSCRIT { get; set; }
        public System.DateTime DATENAISSANCE { get; set; }
        public string ADRESSE { get; set; }
        public Nullable<int> CREDIT { get; set; }
        public short ADMIN { get; set; }
        public short STATUT { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<message> message { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<repondre> repondre { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<service> service { get; set; }
    }
}
