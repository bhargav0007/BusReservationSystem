using AutoMapper;
using Microsoft.EntityFrameworkCore.Diagnostics;
using ReservationCommon;
using ReservationDataAccessLayer.Models;
using ReservationServiceLayer.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReservationServiceLayer.Mapper
{
    public class BookingMapper : Mapper<Booking, BookingModel>
    {
        private readonly IMapper _mapper;


        public BookingMapper() 
        {
            var config = new MapperConfiguration(cfg => {
                cfg.CreateMap<Booking, BookingModel>();
                cfg.CreateMap<BookingModel, Booking>();
            });

            _mapper = config.CreateMapper();
        }
        public override Booking Map(BookingModel value)
        {
            return _mapper.Map<Booking>(value);
        }

        public override BookingModel Map(Booking value)
        {
            return _mapper.Map<BookingModel>(value);
        }
    }
}
