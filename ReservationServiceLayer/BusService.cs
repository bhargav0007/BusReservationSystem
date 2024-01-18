using ReservationCommon.Interface;
using ReservationDataAccessLayer;
using ReservationDataAccessLayer.Models;
using ReservationServiceLayer.Interfaces;
using ReservationServiceLayer.ViewModel;


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

        public async Task<bool> DeleteData(long id)
        {
            return await _busRepository.DeleteData(id);
        }

        public async Task<IEnumerable<BusModel>> GetAllData()
        {
            var result = await _busRepository.GetAllData();
            return _busMapper.Maps(result);
        }

        public async Task<BusModel> GetById(long Id)
        {
            var result = await _busRepository.GetById(Id);
            return _busMapper.Map(result);
        }

        public async Task<bool> UpdateData(long id,BusModel data)
        {
            var result = _busMapper.Map(data);
            return await _busRepository.UpdateData(result);

        }
    }
}
