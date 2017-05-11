using BusinessInGalaxy.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessInGalaxy.Controller
{
    class DigitsTranslator : ITranslator
    {
        public void Translate(GalaxyModel model)
        {
            string[] words = model.InputData[0].Split(new[] { " is " }, StringSplitOptions.RemoveEmptyEntries);
        }
    }

}
