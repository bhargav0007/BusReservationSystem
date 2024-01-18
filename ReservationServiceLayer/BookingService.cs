using ReservationDataAccessLayer;
using ReservationDataAccessLayer.Models;
using ReservationServiceLayer.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReservationServiceLayer
{
    public class BookingService : IBookingService
    {
        private readonly ReservationFactory _reservationFactory;
        private readonly IRepository<Booking> _bookingRepository;
        public BookingService(ReservationFactory reservationFactory) 
        {
            _reservationFactory = reservationFactory;
            _bookingRepository = _reservationFactory.CreateRepository<Booking>();
        }
        public Task<Booking> AddData(Booking data)
        {
            throw new NotImplementedException();
        }

        public Task<bool> DeleteData(long id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Booking>> GetAllData()
        {
            return _bookingRepository.GetAllData();
        }

        public Task<Booking> GetById(long Id)
        {
            throw new NotImplementedException();
        }

        public Task<bool> UpdateData(Booking data)
        {
            throw new NotImplementedException();
        }
    }
}
