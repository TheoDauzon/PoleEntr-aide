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
    
    public partial class service
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public service()
        {
            this.repondre = new HashSet<repondre>();
        }
    
        public int IDSERVICE { get; set; }
        public int IDINSCRIT { get; set; }
        public int IDDEPARTEMENT { get; set; }
        public int IDTYPE { get; set; }
        public string DESCRIPTIFSERVICE { get; set; }
        public string PHOTO { get; set; }
        public System.DateTime DATEDEBUT { get; set; }
        public int DUREEJOURS { get; set; }
        public int PRIX { get; set; }
        public System.DateTime DATEDEPOT { get; set; }
        public int REALISER { get; set; }
    
        public virtual course course { get; set; }
        public virtual departement departement { get; set; }
        public virtual formation formation { get; set; }
        public virtual inscrit inscrit { get; set; }
        public virtual loisirs loisirs { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<repondre> repondre { get; set; }
        public virtual type type { get; set; }
        public virtual tache_menagere tache_menagere { get; set; }
        public virtual transport transport { get; set; }
    }
}
