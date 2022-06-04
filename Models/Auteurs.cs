using System;
using System.Collections.Generic;

namespace App.Models
{
    public partial class Auteurs
    {
        public Auteurs()
        {
            Livres = new HashSet<Livres>();
        }

        public int Id { get; set; }
        public string Nom { get; set; }
        public string Prenom { get; set; }

        public virtual ICollection<Livres> Livres { get; set; }
    }
}
