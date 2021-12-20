using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookExchange.Core.Models
{
    // many to one
    public class BookExchange : BaseEntity
    {
        public DateTime DateEchange { get; set; }
        [ForeignKey("LivreId")]
        public Livre Livre { get; set; }
        public int LivreId { get; set; }
        // many to one
        [ForeignKey("UtilisateurId")]
        public Utilisateur Utilisateur { get; set; }
        public int UtilisateurId { get; set; }
    }
}
