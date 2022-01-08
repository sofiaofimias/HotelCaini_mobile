using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using SQLite;
using System.IO;
using HotelCaini_mobile.Tables;

namespace HotelCaini_mobile.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class RegistrationPage : ContentPage
    {
        public RegistrationPage()
        {
            InitializeComponent();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            var dbpath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "UserDatabase.db");
            var db = new SQLiteConnection(dbpath);
            db.CreateTable<RegUserTable>();

            var item = new RegUserTable()
            {
                UserName = EntryUserName.Text,
                Password = EntryUserPassword.Text
            };

            db.Insert(item);
            Device.BeginInvokeOnMainThread(async () =>
             {
                 var result = await this.DisplayAlert("Bravo!", "Te-ai înregistrat cu succes", "cancel", "ok");

                 if(result)
                 {
                     await Navigation.PushAsync(new LoginPage());
                 }
             }
            );
        }
    }
}