//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré à partir d'un modèle.
//
//     Des modifications manuelles apportées à ce fichier peuvent conduire à un comportement inattendu de votre application.
//     Les modifications manuelles apportées à ce fichier sont remplacées si le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Projet.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;

    public partial class Transplantation
    {
        [DisplayName("Code transplant")]
        public int Code_Transplant { get; set; }

        [DisplayName("Nom médecin")]
        public string Nom_Medecin { get; set; }

        [DisplayName("Code patient")]
        public int Code_Patient { get; set; }

        [DisplayName("Code donneur")]
        public int Code_Donneur { get; set; }

        public virtual Donneur Donneur { get; set; }
        public virtual Patient Patient { get; set; }
    }
}
