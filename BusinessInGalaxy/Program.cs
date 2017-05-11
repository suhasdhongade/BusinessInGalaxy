using BusinessInGalaxy.Controller;
using BusinessInGalaxy.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessInGalaxy
{
    class Program
    {
        static void Main(string[] args)
        {
            GalaxyModel model = new GalaxyModel();

            model.InputData = new List<string>();

            model.InputData.Add("glob is I");
            model.InputData.Add("prok is V");
            model.InputData.Add("pish is X");
            model.InputData.Add("tegj is L");
            model.InputData.Add("glob glob Silver is 34 Credits");
            model.InputData.Add("glob prok Gold is 57800 Credits");
            model.InputData.Add("pish pish Iron is 3910 Credits");
            model.InputData.Add("how much is pish tegj glob glob ?");

            foreach (string line in model.InputData)
            {
                Processor.ConversionProcess(model, line);
            }

        }
    }
}
