using Polo_TestSite.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Polo_TestSite.ViewModels
{
    public class HomeModels
    {
        public IEnumerable<Slider> Sliders { get; set; }
        public IEnumerable<Description> Descriptions { get; set; }

        public IEnumerable<Welcome> Welcomes { get; set; }
        public IEnumerable<What_We> What_Wes { get; set; }
    }
}
