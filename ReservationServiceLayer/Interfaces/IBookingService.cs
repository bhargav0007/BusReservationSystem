using ReservationDataAccessLayer.Models;
using ReservationServiceLayer.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReservationServiceLayer.Interfaces
{
    public interface IBookingService
    {
        Task<IEnumerable<Booking>> GetAllData();
        Task<Booking> GetById(long Id);
        Task<Booking> AddData(Booking data);
        Task<bool> UpdateData(Booking data);
        Task<bool> DeleteData(long id);
    }
}
