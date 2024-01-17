using ReservationDataAccessLayer.Models;
using ReservationServiceLayer.ViewModel;

namespace ReservationServiceLayer.Interfaces
{
    public interface IUserService
    {
        Task<IEnumerable<UserModel>> GetAllData();
        Task<UserModel> GetById(long Id);
        Task<User> AddData(UserModel data);
        Task<bool> UpdateData(User data);
        Task<bool> DeleteData(long id);
    }
}
