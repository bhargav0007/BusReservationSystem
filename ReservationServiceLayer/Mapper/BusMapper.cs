using AutoMapper;
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
    public class BusMapper : Mapper<Bus, BusModel>
    {
        private readonly IMapper _mapper;
        public BusMapper()
        {
            var config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<Bus, BusModel>();
                cfg.CreateMap<BusModel, Bus>();

            });
            _mapper = config.CreateMapper();
        }

        public override Bus Map(BusModel value)
        {
            return _mapper.Map<Bus>(value);
        }

        public override BusModel Map(Bus value)
        {
            return _mapper.Map<BusModel>(value);
        }
    }
}
