using Shhh.Data;
using Shhh.Views;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Shhh
{
    public partial class App : Application
    {
        static ShDataBase database;

        public App()
        {
            InitializeComponent();

            NavigationPage nav = new NavigationPage(new Home())
            {
                BarBackgroundColor = (Color)App.Current.Resources["Primary_Color"],
                BarTextColor = Color.White
            };

            MainPage = nav;
        }

        public static ShDataBase DataBase
        {
            get
            {
                if (database == null)
                {
                    database = new ShDataBase();
                }
                return database;
            }
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
