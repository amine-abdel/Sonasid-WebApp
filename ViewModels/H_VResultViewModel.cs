using Sonacid.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sonacid.ViewModels
{
    public class H_VResultViewModel
    {
        public float Min_mesures { get; set; }
        public float Max_mesures { get; set; }
        public List<H_V> HV { get; set; }
    }
}
