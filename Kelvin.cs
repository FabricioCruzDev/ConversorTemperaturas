using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConversorTemperaturas
{
    public class kelvin
    {
        public string historia = "A escala Kelvin adota como ponto de partida (0 K) o zero absoluto, ou seja, o ponto onde ocorre esta ausência total de vibração das moléculas. Nesta escala o gelo se forma a 273K e a água ferve a 373K(ao nível do mar). Esta escala é muito usada no meio científico, já que ela pertence ao Sistema Internacional(SI). ";
        public string formulaC = "K − 273,15 = °C";
        public string formulaF = "(K − 273,15) × 9/5 + 32 = °F";
        public double resultado;


        public double convertCelcius(double temp)
        {
            return resultado = temp - 273.15;
        }

        public double convertFahrenheit(double temp)
        {
            return resultado = (temp - 273.15) * 9 / 2 + 32;
        }
    }
}
