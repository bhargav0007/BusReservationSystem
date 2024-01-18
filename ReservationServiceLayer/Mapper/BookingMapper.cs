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
            var config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<BookingModel, Booking>();
                cfg.CreateMap<Booking, BookingModel>().ForMember(dest => dest.BusName, opt => opt.MapFrom(src => src.Bus.Name))
               .ForMember(dest => dest.UserName, opt => opt.MapFrom(src => src.User.FirstName + " " + src.User.LastName))
               .ForMember(dest => dest.Status, opt => opt.MapFrom(src => src.Status))
               .ForMember(dest => dest.BookingDate, opt => opt.MapFrom(src => src.BookingDate));

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
