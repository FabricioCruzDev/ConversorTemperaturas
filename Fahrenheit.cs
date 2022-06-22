using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConversorTemperaturas
{
    public class Fahrenheit
    {
       public string historia = "Esta escala foi criada pelo inventor do termômetro de mercúrio, Daniel Gabriel Fahrenheit. Na escala Fahrenheit a água vira gelo a 32ºF e ferve a 212ºF. Esta escala é mais usada nos países de língua inglesa, com exceção da Inglaterra, que já adotou o Celsius.";
       public string formulaC = "(°F − 32) × 5/9 = °C";
       public string formulaK = "(°F − 32) × 5/9 + 273,15 = K";
       public double resultado;
       
       public double convertCelcius (double temp)
       {
            return resultado = (temp - 32) * 5 / 9;
       }
       
       public double convertKelvin (double temp)
       {
           return resultado = (temp - 32) * 5 / 9 + 273.15;
       }
    }
}
