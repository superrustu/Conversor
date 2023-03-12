using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Conversor.Vistas
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Convertir : ContentPage
    {
        double cm;
        double mt;

        public Convertir()
        {
            InitializeComponent();
        }

        private void calcular()
        {
            cm = Convert.ToDouble(this.txtCm.Text);
            mt = cm / 100;

            this.lblResultado.Text = mt.ToString() + " m";
        }

        private void Validar()
        {
            if (!string.IsNullOrEmpty(this.txtCm.Text))
                calcular();
            else
                DisplayAlert("Error", "Ingrese una cantidad", "OK");
        }

        private void btnVolver_Clicked(object sender, EventArgs e)
        {
            Navigation.PopAsync();
        }

        private void btnCalcular_Clicked(object sender, EventArgs e)
        {
            this.Validar();
        }
    }
}