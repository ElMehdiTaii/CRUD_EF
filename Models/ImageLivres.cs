using System;
using System.Collections.Generic;

namespace App.Models
{
    public partial class ImageLivres
    {
        public int Id { get; set; }
        public string ImageCouverture { get; set; }
        public string ImageResume { get; set; }
        public string ImageAutre { get; set; }
        public int? LivreId { get; set; }

        public virtual Livres Livre { get; set; }
    }
}
