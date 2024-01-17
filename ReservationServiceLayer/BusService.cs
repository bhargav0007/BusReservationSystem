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
    public class BusService : IBusService
    {
        private readonly ReservationFactory _reservationFactory;
        private readonly IRepository<Bus> _busRepository;
        private readonly IMapper<Bus, BusModel> _busMapper;

        public BusService(ReservationFactory reservationFactory, IMapper<Bus, BusModel> busMapper)
        {
            _reservationFactory = reservationFactory;
            _busRepository = _reservationFactory.CreateRepository<Bus>();
            _busMapper = busMapper;
        }

        public async Task<Bus> AddData(BusModel data)
        {
            var busData = _busMapper.Map(data);
            return await _busRepository.AddData(busData);
        }

        public Task<bool> DeleteData(long id)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<BusModel>> GetAllData()
        {
            var result = await _busRepository.GetAllData();
            return _busMapper.Maps(result);
        }

        public Task<BusModel> GetById(long Id)
        {
            throw new NotImplementedException();
        }

        public Task<bool> UpdateData(Bus data)
        {
            throw new NotImplementedException();
        }
    }
}
