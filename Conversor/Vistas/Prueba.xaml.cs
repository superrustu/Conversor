using Conversor.Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Rg.Plugins.Popup.Services;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Conversor.Vistas
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Prueba : ContentPage
    {
        public IList<Mcomidas> Comidas { get; private set; }
        public Prueba()
        {
            InitializeComponent();

            Comidas = new List<Mcomidas>();
            Comidas.Add(new Mcomidas
            {
                Nombre="Encebollado",
                Imagen="atras.png"
            });
            Comidas.Add(new Mcomidas
            {
                Nombre = "Cazuela",
                Imagen = "atras.png"
            }); 
            Comidas.Add(new Mcomidas
            {
                Nombre = "Bolon",
                Imagen = "atras.png"
            }); 
            Comidas.Add(new Mcomidas
            {
                Nombre = "Bollo",
                Imagen = "atras.png"
            }); 
            Comidas.Add(new Mcomidas
            {
                Nombre = "Tigrillo",
                Imagen = "tarjeta.png"
            });

            BindingContext = this;
        }

        private void btnPopup_Clicked(object sender, EventArgs e)
        {
            PopupNavigation.Instance.PushAsync(new AlertaPopup());
        }
    }
}