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

    public partial class Utilisateur
    {
        public int Code_U { get; set; }
        [DisplayName("Nom")]
        public string Nom_U { get; set; }
        [DisplayName("Nom d'utilisateur")]
        public string Nom_Utilisateur_U { get; set; }
        [DisplayName("Prénom")]
        public string Prenom_U { get; set; }
        public int Code_Role { get; set; }
        [DisplayName("Mot de passe")]
        public string Mdp_U { get; set; }
        public Nullable<System.DateTime> Date_U { get; set; }
        [DisplayName("Adresse email")]
        public string Email_U { get; set; }
    
        public virtual Role_User Role_User { get; set; }
    }
}
