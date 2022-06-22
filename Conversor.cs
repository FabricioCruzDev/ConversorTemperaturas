using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConversorTemperaturas
{
    struct Conversor
    {
        
        public int  Escala;
        public string Historia;
        public double Temp;
        public double Resultado;
        public int Botao;
        public string Formula;
        
        public void Converter()
        {
            if (Escala == 1)
            {
                Celsius converter = new Celsius();
                Historia = converter.historia;
                if (Botao == 2)
                {
                    Formula = converter.formulaF;
                    converter.convertFahrenheit(Temp);
                    Resultado = converter.resultado;
                }
                if (Botao == 3)
                {
                    Formula = converter.formulaK;
                    converter.convertKelvin(Temp);
                    Resultado = converter.resultado;
                }
                
                }

            if (Escala == 2)
            {
                Fahrenheit converter = new Fahrenheit();
                Historia = converter.historia;
                if (Botao == 1)
                {
                    Formula = converter.formulaC;
                    converter.convertCelcius(Temp);
                    Resultado = converter.resultado;
                }
                if (Botao == 3)
                {
                    Formula = converter.formulaK;
                    converter.convertKelvin(Temp);
                    Resultado = converter.resultado;
                }

            }

            if (Escala == 3)
            {
                kelvin converter = new kelvin();
                Historia = converter.historia;
                if (Botao == 1)
                {
                    Formula = converter.formulaC;
                    converter.convertCelcius(Temp);
                    Resultado = converter.resultado;
                }
                if (Botao == 2)
                {
                    Formula = converter.formulaF;
                    converter.convertFahrenheit(Temp);
                    Resultado = converter.resultado;
                }
            }
        }
        

    }
     
}
