using System;
using System.Collections.Generic;

namespace App.Models
{
    public partial class Abonnements
    {
        public Abonnements()
        {
            AbonnementLivres = new HashSet<AbonnementLivres>();
            Users = new HashSet<Users>();
        }

        public int Id { get; set; }
        public string Type { get; set; }
        public DateTime? DateDebut { get; set; }
        public DateTime? DateFin { get; set; }

        public virtual ICollection<AbonnementLivres> AbonnementLivres { get; set; }
        public virtual ICollection<Users> Users { get; set; }
    }
}
