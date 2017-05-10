using BusinessInGalaxy.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessInGalaxy.Controller
{
    class DigitsTranslator : ITranslatorTranslateDigits
    {
        public void TranslateDigits(GalaxyModel model, string line)
        {
            string[] words = line.Split(new[] { " is " }, StringSplitOptions.RemoveEmptyEntries);

        }
    }

}
