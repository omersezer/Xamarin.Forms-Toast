using Mesaj.Helper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Mesaj.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class AnaSayfa : ContentPage
	{
		public AnaSayfa ()
		{
			InitializeComponent ();
		}
        
        // Tıkla butonuna tıklandığında 
        private void btnTikla_Clicked(object sender,EventArgs e)
        {
            string mesaj = "Bu bir mesajdır";
            DependencyService.Get<IMessage>().UzunMesaj(mesaj);
        }

    }
}