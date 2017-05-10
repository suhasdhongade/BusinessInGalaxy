using BusinessInGalaxy.GalaxyReference;
using BusinessInGalaxy.GalaxySystem;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessInGalaxy.Model
{
    class GalaxyModel : Galaxy
    {
        public RomanDigit RomanDigit { get; set; }
        public List<Metal> Metals { get; set; }
        public List<Subtitute> Subtitutes { get; set; }

        public List<string> InputData { get; set; }

        public override void InitialseGalaxySystem()
        {
            RomanDigit = new RomanDigit();
            Metals = new List<Metal>();
            Subtitutes = new List<Subtitute>();
        }
    }
}
