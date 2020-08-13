using Shhh.Models;
using Shhh.ViewModels;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Shhh.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Home : ContentPage
    {
        private readonly HomeViewModel vm;

        public Home()
        {
            InitializeComponent();
            BindingContext = vm = new HomeViewModel();
        }

        protected override async void OnAppearing()
        {
            base.OnAppearing();

            await vm.SetDataAsync();
        }

        private async void AddButton_Clicked(object sender, EventArgs e)
        {
            await App.Current.MainPage.Navigation.PushAsync(new NewSilensor());
        }

        private async void SilensorsList_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            Silensor item = (Silensor)e.Item;
            if (item != null)
            {
                await App.Current.MainPage.Navigation.PushAsync(new SilensorAction(item));
            }
        }
    }
}