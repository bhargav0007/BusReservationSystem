using ReservationCommon.Interface;
using ReservationDataAccessLayer;
using ReservationDataAccessLayer.Models;
using ReservationServiceLayer.Interfaces;
using ReservationServiceLayer.Mapper;
using ReservationServiceLayer.ViewModel;


namespace ReservationServiceLayer
{
    public class UserService : IUserService
    {
        public readonly ReservationFactory _reservationFactory;
        public readonly IRepository<User> _userRepository;
        public readonly IMapper<User,UserModel> _userMapper;

        public UserService(ReservationFactory reservationFactory,IMapper<User,UserModel> userMapper)
        {
            _reservationFactory = reservationFactory;
            _userRepository = _reservationFactory.CreateRepository<User>();
            _userMapper = userMapper;
        }

        public async Task<IEnumerable<UserModel>> GetAllData()
        {
            IEnumerable<User> result = await _userRepository.GetAllData();
            return _userMapper.Maps(result);
        }

        public async Task<UserModel> GetById(long Id)
        {
            var user = await _userRepository.GetById(Id);
            return _userMapper.Map(user);
        }

        public async Task<User> AddData(UserModel data)
        {
            var userData = _userMapper.Map(data);
            return await _userRepository.AddData(userData);
        }

        public async Task<bool> UpdateData(User data)
        {
            return await _userRepository.UpdateData(data);
        }

        public async Task<bool> DeleteData(long id)
        {
            return await _userRepository.DeleteData(id);
        }

    }
}
