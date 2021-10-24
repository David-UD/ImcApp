using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using ImcApp.Model;

namespace ImcApp
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            imcLabel.Text = string.Empty;
            situacionNutricionalLabel.Text = string.Empty;
        }

        private void CalcularButton_Clicked(object sender, EventArgs e)
        {
            string pesoEnCadena = PesoEntry.Text;
            string estaturaEnCadena = EstaturaEntry.Text;
            //conversion de texto a decimal
            decimal peso, estatura;
            if (decimal.TryParse(pesoEnCadena, out peso) &&
                decimal.TryParse(estaturaEnCadena, out estatura))
            {
                CalculadoraImc cimc = new CalculadoraImc(peso, estatura);
                //imc = peso / (estatura * estatura);
                imcLabel.Text = string.Format("{0:F4}", cimc.Imc);
                situacionNutricionalLabel.Text = cimc.SituacionNutricional;
                //imcLabel.Text = imc.ToString();
                //imcLabel.Text = string.Format("{0:F4}", imc);
            }
        }

        private void LimpiarButton_Clicked(object sender, EventArgs e)
        {
            PesoEntry.Text = string.Empty;
            EstaturaEntry.Text = string.Empty;
            imcLabel.Text = string.Empty;
            situacionNutricionalLabel.Text = string.Empty;
        }
    }
}
