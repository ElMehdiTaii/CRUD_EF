using System;
using System.Collections.Generic;

namespace App.Models
{
    public partial class Categories
    {
        public Categories()
        {
            Livres = new HashSet<Livres>();
        }

        public int Id { get; set; }
        public string Libelle { get; set; }

        public virtual ICollection<Livres> Livres { get; set; }
    }
}
