using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeatherConverter
{
    public class Conversor
    {
        public int CelsiusToFahrenheit(int temperatura)
        {
            temperatura = (temperatura * 9 / 5) + 32;
            return temperatura;
        }

        public int CelsiusToKelvin(int temperatura)
        {
            return (int)(temperatura + 273.15);
        }
    }
}
