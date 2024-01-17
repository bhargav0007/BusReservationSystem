using Microsoft.EntityFrameworkCore;
using ReservationDataAccessLayer.Models;


namespace ReservationDataAccessLayer.Repository
{
    public class UserRepository : IRepository<User>
    {
        private readonly ReservationDbContext _context;

        public UserRepository(ReservationDbContext context)
        {
            _context = context;
        }

        public async Task<User> AddData(User data)
        {
            await _context.Users.AddAsync(data);
            await _context.SaveChangesAsync();
            return data;
        }

        public async Task<bool> DeleteData(long id)
        {
            User? user = await _context.Users.FindAsync(id);
            if (user != null)
            {
                _context.Remove(user);
                return true;
            }
            return false;
        }

        public async Task<IEnumerable<User>> GetAllData()
        {
            return await _context.Users.ToListAsync();
        }

        public async Task<User> GetById(long Id)
        {
            return await _context.Users.FindAsync(Id);
        }

        public async Task<bool> UpdateData(User data)
        {
            User? result = await _context.Users.FindAsync(data.Id);
            if (result != null)
            {
                _context.Entry(data).State = EntityState.Modified;
                await _context.SaveChangesAsync();
                return true;
            }
            return false;
        }
    }
}
