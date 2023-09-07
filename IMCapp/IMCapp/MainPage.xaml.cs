using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace IMCapp
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            if(!string.IsNullOrEmpty(Altura.Text) && !string.IsNullOrEmpty(Peso.Text))
            {
                var altura = double.Parse(Altura.Text);

                var peso = double.Parse(Peso.Text);

                var imc = peso / (altura * altura);
                IMC.Text = imc.ToString();

                string resultado = "";

                if (imc < 18.5)
                {
                    resultado = "Estas por debajo de tu peso...";
                }
                else if (imc >= 18.5 && imc <= 24.9)
                {
                    resultado = "Estas en tu peso ideal! Buen Trabajo!";
                }
                else if (imc >= 25 && imc <= 29.9)
                {
                    resultado = "Tienes Sobrepeso!";
                }
                else
                {
                    resultado = "Tienes Obesidad!!! Ten mucho cuidado!!";
                }

                DisplayAlert("Resultado!", resultado, "Ok");
            }
            else
            {
                DisplayAlert("ATENCION", "NO SE DETECTAN DATOS", "OK");
            }

            
        }
    }
}
