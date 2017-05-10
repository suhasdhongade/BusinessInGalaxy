using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessInGalaxy.GalaxyReference
{
    internal class RomanDigitReferance
    {
        public char Symbol { get; set; }
        public int Currency { get; set; }
    }

    internal class RomanDigit
    {
        Dictionary<char, RomanDigitReferance> _RomanDigits;
        public RomanDigit()
        {
            _RomanDigits = new Dictionary<char, RomanDigitReferance>();

            _RomanDigits.Add('I', new RomanDigitReferance { Symbol = 'I', Currency = 1 });
            _RomanDigits.Add('V', new RomanDigitReferance { Symbol = 'V', Currency = 5 });
            _RomanDigits.Add('X', new RomanDigitReferance { Symbol = 'X', Currency = 10 });
            _RomanDigits.Add('L', new RomanDigitReferance { Symbol = 'L', Currency = 50 });
            _RomanDigits.Add('C', new RomanDigitReferance { Symbol = 'C', Currency = 100 });
            _RomanDigits.Add('D', new RomanDigitReferance { Symbol = 'D', Currency = 500 });
            _RomanDigits.Add('M', new RomanDigitReferance { Symbol = 'M', Currency = 1000 });
        }

        public RomanDigitReferance GetCurrency(char key)
        {
            return _RomanDigits[key];
        }

    }


}
