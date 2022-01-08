using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using HotelCaini_mobile.Views;
using System;
using HotelCaini_mobile.Data;
using System.IO;

namespace HotelCaini_mobile
{
    public partial class App : Application
    {
        static ReviewDatabase database;

        public static ReviewDatabase Database
        {
            get
            {
                if (database == null)
                {
                    database = new
                   ReviewDatabase(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.
                   LocalApplicationData), "ShoppingList.db3"));
                }
                return database;
            }
        }
        public App()
        {
            InitializeComponent();

            //MainPage = new MainPage();

            MainPage = new NavigationPage(new LoginPage());
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
