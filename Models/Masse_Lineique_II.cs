using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sonacid.Models
{
    public class Masse_Lineique_II
    {
        public int Id { get; set; }
        public int N_ech { get; set; }
        public int Nombre { get; set; }
        public int SP_EBOU { get; set; }
        public int Mesures { get; set; }
        public int MLDivMoy { get; set; }
        public int Min { get; set; }
        public int Max { get; set; }
        public int Cible { get; set; }
        public float Reduction { get; set; }
        public int Conforme { get; set; }
    }
}
