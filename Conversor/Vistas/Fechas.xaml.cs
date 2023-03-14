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
    public partial class Fechas : ContentPage
    {
        public Fechas()
        {
            InitializeComponent();
        }

        private void dtFecha_DateSelected(object sender, DateChangedEventArgs e)
        {
            lblResultado.Text = dtFecha.Date.ToString("MM dd, yyyy");
        }

        private void TimePicker_PropertyChanged(object sender, System.ComponentModel.PropertyChangedEventArgs e)
        {
            lblHora.Text = TpHora.Time.ToString();
        }
    }
}