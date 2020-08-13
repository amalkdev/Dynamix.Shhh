using Shhh.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Shhh.Services.SilencorServices
{
    public interface  ISilensorService
    {
        Task<List<Silensor>> GetSilensorsAsync();

        Task<int> CreateSilensor(Silensor silensor);

        Task<int> UpdateSilensorStatus(Silensor silensor);
    }
}
