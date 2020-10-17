using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MBOapi.Database.Entity
{
    [Table("Utilisateur")]
    public class Utilisateur
    {
        [Key]
        public int IdUtilisateur { get; set; }
        public string NomUtilisateur { get; set; }
        public string LoginUtilisateur { get; set; }
        public string MotDePasseUtilisateur { get; set; }
        public string EmailUtilisateur { get; set; }
    }
}
