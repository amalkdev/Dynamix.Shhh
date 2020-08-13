using Shhh.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Shhh.Services.SilencorServices
{
    public class SilensorService : ISilensorService
    {
        public async Task<List<Silensor>> GetSilensorsAsync()
        {
            return await App.DataBase.GetDataAsync<Silensor>();
        }

        public async Task<int> CreateSilensor(Silensor silensor)
        {
            return await App.DataBase.SaveData(silensor);
        }

        public async Task<int> UpdateSilensorStatus(Silensor silensor)
        {
            return await App.DataBase.UpdateDataAsync(silensor);
        }
    }
}
