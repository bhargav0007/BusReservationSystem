using ReservationDataAccessLayer.Models;
using ReservationServiceLayer.ViewModel;


namespace ReservationServiceLayer.Interfaces
{
    public interface IBusService
    {
        Task<IEnumerable<BusModel>> GetAllData();
        Task<BusModel> GetById(long Id);
        Task<Bus> AddData(BusModel data);
        Task<bool> UpdateData(long id, BusModel data);
        Task<bool> DeleteData(long id);

    }
}
