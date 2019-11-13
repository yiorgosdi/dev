using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Zacharoplasteio_Core3.Models; 

namespace Zacharoplasteio_Core3.ViewModels
{
    public class PiesListViewModel
    {
        public IEnumerable<Pie> Pies { get; set; }
        public string CurrentCategory { get; set; }
    }
}
