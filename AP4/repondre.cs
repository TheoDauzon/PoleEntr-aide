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
    
    public partial class repondre
    {
        public int IDINSCRIT { get; set; }
        public int IDSERVICE { get; set; }
        public System.DateTime DATEREP { get; set; }
        public Nullable<sbyte> ATTRIBUER { get; set; }
    
        public virtual inscrit inscrit { get; set; }
        public virtual service service { get; set; }
    }
}
