using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace App5
{
    public class App : Application
    {
        public App()
        {
            MainPage = new NavigationPage(new MainPage());
        }
        protected override void OnStart()
        {
            base.OnStart();
        }
        protected override void OnSleep()
        {
            base.OnSleep();
        }
        protected override void OnResume()
        {
            base.OnResume();
        }
    }
}
