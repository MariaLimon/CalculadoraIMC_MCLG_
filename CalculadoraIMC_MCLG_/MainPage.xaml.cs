using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace CalculadoraIMC_MCLG_
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }
        double imc;
        private void Button_Clicked(object sender, EventArgs e)
        {
            CalcularIMC(double.Parse(Peso.Text), double.Parse(Altura.Text));
            //DECLARAR VARIABLES Y ADIGNAR VALOR
            //var peso = float.Parse(Peso.Text);
            //var altura = float.Parse(Altura.Text);
            //REALIZAR CALCULO
            //float imc = (peso / (altura * altura));

            //ENVIAR RESULTADO
            IMC.Text = imc.ToString();


            //CONDICIONAR
            string resultado = " ";
            if (imc < 18.5)
            {
                resultado = "Bajo peso";
            }
            else if(imc>=18.5 && imc < 24.9 )
            { 
                resultado = "Peso normal";
            
            }
            else if (imc >= 18.5 && imc <= 29.9)
            {
                resultado = "Sobre peso";

            }
            else if (imc > 29.9)
            {
                resultado = "Obesidad";

            }

            DisplayAlert("Resultado: ", resultado, "Quitar");
        }

        private void CalcularIMC(double p, double a)
        {
            imc = p / Math.Pow(a,2);
        }
    }
}
