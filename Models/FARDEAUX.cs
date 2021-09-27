using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVC_SONASID.Models
{
    public class FARDEAUX
    {
        public int Id { get; set; }
        public string Idicateur { get; set; }
        public int Non_Conforme { get; set; }
        public int Derogeable { get; set; }
        public int conforme { get; set; }
        public double Moyenne { get; set; }

    }
}

