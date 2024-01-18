using ReservationDataAccessLayer.Models;
using ReservationDataAccessLayer.Repository;

namespace ReservationDataAccessLayer
{
    public class ReservationFactory
    {
        private readonly ReservationDbContext _context;

        public ReservationFactory(ReservationDbContext context)
        {
            _context = context;
        }

        public IRepository<T> CreateRepository<T>()
        {
            if (typeof(T) == typeof(User))
            {
                return new UserRepository(_context) as IRepository<T>;
            }
            if (typeof(T) == typeof(Bus)) 
            {
                return new BusRepository(_context) as IRepository<T>;
            }
            if (typeof(T) == typeof(Route)) 
            {
                return new RouteRepository(_context) as IRepository<T>;
            }
            if (typeof(T) == typeof(Booking)) 
            {
                return new BookingRepository(_context) as IRepository<T>;
            }
            throw new InvalidOperationException();
        }

    }
}
