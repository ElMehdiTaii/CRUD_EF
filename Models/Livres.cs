using System;
using System.Collections.Generic;

namespace App.Models
{
    public partial class Livres
    {
        public Livres()
        {
            AbonnementLivres = new HashSet<AbonnementLivres>();
            ImageLivres = new HashSet<ImageLivres>();
        }

        public int Id { get; set; }
        public int? CategoryId { get; set; }
        public int? AuteurId { get; set; }
        public string Titre { get; set; }
        public string Langue { get; set; }
        public int? NombreDePage { get; set; }
        public DateTime? DatePuration { get; set; }
        public string Isbn { get; set; }

        public virtual Auteurs Auteur { get; set; }
        public virtual Categories Category { get; set; }
        public virtual ICollection<AbonnementLivres> AbonnementLivres { get; set; }
        public virtual ICollection<ImageLivres> ImageLivres { get; set; }
    }
}
