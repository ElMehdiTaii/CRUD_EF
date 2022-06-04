using System;
using System.Collections.Generic;

namespace App.Models
{
    public partial class AbonnementLivres
    {
        public int Id { get; set; }
        public int? LivreId { get; set; }
        public int? AbonnementId { get; set; }

        public virtual Abonnements Abonnement { get; set; }
        public virtual Livres Livre { get; set; }
    }
}
