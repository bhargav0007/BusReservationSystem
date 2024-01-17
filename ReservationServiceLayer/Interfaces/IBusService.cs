using ReservationDataAccessLayer.Models;
using ReservationServiceLayer.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReservationServiceLayer.Interfaces
{
    public interface IBusService
    {
        Task<IEnumerable<BusModel>> GetAllData();
        Task<BusModel> GetById(long Id);
        Task<Bus> AddData(BusModel data);
        Task<bool> UpdateData(Bus data);
        Task<bool> DeleteData(long id);

    }
}
