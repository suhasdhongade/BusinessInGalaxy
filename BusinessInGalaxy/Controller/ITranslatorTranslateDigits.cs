using BusinessInGalaxy.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessInGalaxy.Controller
{
    interface ITranslatorTranslateDigits
    {
        void TranslateDigits(GalaxyModel model, string line);
    }
   
}
