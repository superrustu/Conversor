using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Rg.Plugins.Popup;
using Rg.Plugins.Popup.Pages;
using Rg.Plugins.Popup.Services;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Conversor.Vistas
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class AlertaPopup : PopupPage
	{
		public AlertaPopup ()
		{
			InitializeComponent ();
		}

        private void btnOk_Clicked(object sender, EventArgs e)
        {
			PopupNavigation.Instance.PopAsync();
        }
    }
}