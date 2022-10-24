using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AM.ApplicationCore.Domain
{
    public class Membre
    {
        [DataType(DataType.Date)]
        public DateTime DateNaissance { get; set; }
        public int Identifiant { get; set; }

        public String Nom { get; set; }
        public String Prenom { get; set; }

        public ICollection<Equipe> Equipes { get; set; }

    }
}
