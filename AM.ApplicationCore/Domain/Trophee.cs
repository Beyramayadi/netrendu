using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace AM.ApplicationCore.Domain
{
    public class Trophee
    {
        [DataType(DataType.Date)]
        public DateTime DateTrophee { get; set; }
        public double Recompense { get; set; }
        public int TropheeId { get; set; }
        public String TypeTrophee { get; set; }

        public Equipe Equipe { get; set; }


    }
}
