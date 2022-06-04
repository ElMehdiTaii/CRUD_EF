using System;
using System.Collections.Generic;

namespace App.Models
{
    public partial class Users
    {
        public int Id { get; set; }
        public int? AbonnementId { get; set; }
        public string Nom { get; set; }
        public string Prenom { get; set; }
        public DateTime? DateNaissance { get; set; }
        public string Adress { get; set; }

        public virtual Abonnements Abonnement { get; set; }
    }
}
