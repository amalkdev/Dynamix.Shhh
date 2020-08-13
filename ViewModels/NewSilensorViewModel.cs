using Shhh.Models;
using Shhh.Services.SilencorServices;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace Shhh.ViewModels
{
    public class NewSilensorViewModel : BaseViewModel
    {
        private readonly ISilensorService service;

        public NewSilensorViewModel()
        {
            service = new SilensorService();
        }

        public async Task Save(Silensor silensor)
        {
            silensor.CreatedDate = DateTime.UtcNow;

            int status = await service.CreateSilensor(silensor);

            await App.Current.MainPage.Navigation.PopAsync();
        }
    }
}
