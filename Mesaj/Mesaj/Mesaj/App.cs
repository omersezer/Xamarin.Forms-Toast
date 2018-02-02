using Mesaj.Views;
using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace Mesaj
{
    public class App : Application
    {
        public App()
        {
            MainPage = new AnaSayfa();
        }
    }
}
