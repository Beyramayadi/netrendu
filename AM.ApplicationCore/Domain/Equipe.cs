using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AM.ApplicationCore.Domain
{
    public class Equipe
    {
        public String AdresseLocal { get; set; }
        public int EquipeId { get; set; }
        public String Logo { get; set; }
        public String NomEquipe { get; set; }

        public ICollection<Membre> Membres { get; set; }

        public ICollection<Trophee> Trophees { get; set; }


    }
}
