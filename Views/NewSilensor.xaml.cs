using Shhh.Models;
using Shhh.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Shhh.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class NewSilensor : ContentPage
    {
        private readonly NewSilensorViewModel vm;

        public NewSilensor()
        {
            InitializeComponent();

            BindingContext = vm = new NewSilensorViewModel();
        }

        private async void SaveButton_Clicked(object sender, EventArgs e)
        {
            var name = this.Name.Text.Trim();
            var remarks = this.Remarks.Text.Trim();

            var silensor = new Silensor
            {
                Name = name,
                Remarks = remarks
            };

            await vm.Save(silensor);
        }
    }
}