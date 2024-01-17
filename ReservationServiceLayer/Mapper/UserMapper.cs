using ReservationDataAccessLayer.Models;
using ReservationServiceLayer.ViewModel;
using AutoMapper;
using ReservationCommon;

namespace ReservationServiceLayer.Mapper
{
    public class UserMapper : Mapper<User, UserModel>
    {
        private readonly IMapper _mapper;

        public UserMapper()
        {
            var config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<User, UserModel>();
                cfg.CreateMap<UserModel, User>();
            });

            _mapper = config.CreateMapper();
        }

        public override User Map(UserModel value)
        {
            return _mapper.Map<User>(value);
        }

        public override UserModel Map(User value)
        {
            return _mapper.Map<UserModel>(value);
        }

    }
}
