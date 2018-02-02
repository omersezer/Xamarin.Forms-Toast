using Android.Widget;
using Mesaj.Droid;
using Xamarin.Forms;

[assembly: Dependency(typeof(Mesaj_Android))]
namespace Mesaj.Droid
{
    public class Mesaj_Android : Mesaj.Helper.IMessage
    {
        public void KisaMesaj(string mesaj)
        {
            Toast.MakeText(Android.App.Application.Context, mesaj, ToastLength.Short).Show();

        }

        public void UzunMesaj(string mesaj)
        {
            Toast.MakeText(Android.App.Application.Context, mesaj, ToastLength.Long).Show();
        }
    }
}