﻿using MVC_SONASID.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVC_SONASID.ViewModels
{
    public class FARDEAUXVeiwModel
    {
        public int score { get; set; }
        public int nbr_verification { get; set; }
        public double conforme { get; set; }
        public List<FARDEAUX> ListC { get; set; }
    }
}
