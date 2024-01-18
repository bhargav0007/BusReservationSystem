using AutoMapper;
using ReservationCommon.Interface;
using ReservationDataAccessLayer;
using ReservationDataAccessLayer.Models;
using ReservationServiceLayer.Interfaces;
using ReservationServiceLayer.ViewModel;
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
        private readonly IMapper<Booking, BookingModel> _mapper;
        public BookingService(ReservationFactory reservationFactory,IMapper<Booking,BookingModel> mapper) 
        {
            _reservationFactory = reservationFactory;
            _bookingRepository = _reservationFactory.CreateRepository<Booking>();
            _mapper = mapper;
        }
        public Task<Booking> AddData(Booking data)
        {
            throw new NotImplementedException();
        }

        public Task<bool> DeleteData(long id)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<BookingModel>> GetAllData()
        {
            var result = await _bookingRepository.GetAllData();
            return _mapper.Maps(result);
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
