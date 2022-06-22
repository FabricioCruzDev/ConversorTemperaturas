using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConversorTemperaturas
{
    public class Celsius
    {
        public string historia = "A escala Celsius foi criada por Anders Celsius, um astrônomo sueco, em 1742. Na escala Celsius a água vira gelo a 0°C e ferve a 100°F. A escala Celsius é a mais comum de todas as escalas termométricas.";
        public string formulaK = "°C + 273,15 = K";
        public string formulaF = "(°C × 9/5) + 32 = °F";
        public double resultado;

        public double convertKelvin(double temp)
        {
            return resultado = temp + 273.15;
        }

        public double convertFahrenheit(double temp)
        {
            return resultado = (temp * 9/5) + 32;
        }
    }
}
