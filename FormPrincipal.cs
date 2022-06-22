using System;
using System.Windows.Forms;

namespace ConversorTemperaturas
{
    public partial class frm_Principal : Form
    {
        int escolha;

        public frm_Principal()
        {
            InitializeComponent();
        }


        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lb_Escala.SelectedIndex == 0)
            {
                btn_Celsius.Enabled = false;
                btn_Fahrenheit.Enabled = true;
                btn_Kelvin.Enabled = true;
                tb_Valor.Enabled = true;
                tb_Valor.Clear();
                escolha = 1;
                escala(1);
            }
            if (lb_Escala.SelectedIndex == 1)
            {
                btn_Celsius.Enabled = true;
                btn_Kelvin.Enabled = true;
                tb_Valor.Enabled = true;
                tb_Valor.Clear();
                escolha = 2;
                escala(2);
            }
            if (lb_Escala.SelectedIndex == 2)
            {
                btn_Celsius.Enabled = true;
                btn_Fahrenheit.Enabled = true;
                tb_Valor.Enabled = true;
                tb_Valor.Clear();
                escolha = 3;
                escala(3);
            }
        }

        private void btn_Celsius_Click(object sender, EventArgs e)
        {
            double temp = Convert.ToDouble(tb_Valor.Text);
            calculo(escolha, 1, temp);
        }
     
        private void btn_Fahrenheit_Click(object sender, EventArgs e)
        {
            double temp = Convert.ToDouble(tb_Valor.Text);
            calculo(escolha, 2, temp);
        }

        
        private void btn_Kelvin_Click(object sender, EventArgs e)
        {
            double temp = Convert.ToDouble(tb_Valor.Text);
            calculo(escolha, 3, temp);
        }

        private void escala(int escala)
        {
            Conversor resultado = new Conversor();
            resultado.Escala = escala;
            resultado.Converter();
            rt_Sobre.Text = resultado.Historia;
        }

        private void calculo(int escolha, int botao, double temp)
        {
            Conversor calculo = new Conversor();
            calculo.Escala = escolha;
            calculo.Temp = temp;
            calculo.Botao = botao;
            calculo.Converter();
            rt_Formula.Text = calculo.Formula;
            tb_Resultado.Text = Convert.ToString(calculo.Resultado);
        }

        private void btn_Sair_Click(object sender, EventArgs e)
        {
           Environment.Exit(0);
        }
    }
}
