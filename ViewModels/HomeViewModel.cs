using Shhh.Models;
using Shhh.Services.SilencorServices;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace Shhh.ViewModels
{
    public class HomeViewModel : BaseViewModel
    {
        private readonly ISilensorService service;

        private List<Silensor> data;

        public List<Silensor> Data
        {
            get { return data; }
            set
            {
                data = value;
                NotifyPropertyChanged();
            }
        }

        public HomeViewModel()
        {
            service = new SilensorService();
        }

        public async Task SetDataAsync()
        {
            Data = await service.GetSilensorsAsync();
        }

        public async Task SwitchSilensor(Silensor silensor)
        {
            if (silensor != null)
            {
                int status = await service.UpdateSilensorStatus(silensor);
            }
        }
    }
}
