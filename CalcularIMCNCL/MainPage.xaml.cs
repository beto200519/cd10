using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace CalcularIMCNCL
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }
        private void button_clicked(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(peso.Text) && !string.IsNullOrEmpty(altura.Text))
            {
                var Peso = double.Parse(peso.Text);
                var Altura = double.Parse(altura.Text);
                var imc = Peso / (Altura * Altura);
                IMC.Text = imc.ToString();

                string Rango = "";
                if (imc < 18)
                {
                    Rango = "Estas muy flaco";
                }
                else if (imc <= 18.5 && imc <= 24.9)
                {
                    Rango = "Tu peso esta normal";
                }
                else if (imc < 25 && imc <= 29.9)
                {
                    Rango = "Te estas pasando un poco de peso";
                }
                else
                {
                    Rango = "obecidad";
                }

                DisplayAlert("Rango:", Rango, "Quitar");
            }
            else
            {
                DisplayAlert("Datos erroneos", "Ingresa todos los datos, PorFavor", "Quitar");
            }
        }
    }

}
