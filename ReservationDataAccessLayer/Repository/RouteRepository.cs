using ReservationDataAccessLayer.Models;


namespace ReservationDataAccessLayer.Repository
{
    public class RouteRepository : IRepository<Route>
    {
        public readonly ReservationDbContext _context; 
        public RouteRepository(ReservationDbContext context) 
        {
            _context = context;
        
        }
        public Task<Route> AddData(Route data)
        {
            throw new NotImplementedException();
        }

        public Task<bool> DeleteData(long id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Route>> GetAllData()
        {
            throw new NotImplementedException();
        }

        public Task<Route> GetById(long Id)
        {
            throw new NotImplementedException();
        }

        public Task<bool> UpdateData(Route data)
        {
            throw new NotImplementedException();
        }
    }
}
