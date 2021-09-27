using Sonacid.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sonacid.ViewModels
{
    public class Masse_Lineique_IIViewModel
    {
        public int Id { get; set; }
        public int Nombre_Confirm { get; set; }
        public int Min { get; set; }
        public int Max { get; set; }
        public double Moy { get; set; }
      
        public int Nombre_Mesures { get; set; }
        public float Taux_Conformite { get; set; }
        public List<Masse_Lineique_II> Ml_I_list { get; set; }
    }
}
