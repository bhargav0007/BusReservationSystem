using Microsoft.EntityFrameworkCore;
using ReservationDataAccessLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReservationDataAccessLayer.Repository
{
    public class BookingRepository : IRepository<Booking>
    {
        private readonly ReservationDbContext _context;

        public BookingRepository(ReservationDbContext context) {  _context = context; }
        public Task<Booking> AddData(Booking data)
        {
            throw new NotImplementedException();
        }

        public Task<bool> DeleteData(long id)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<Booking>> GetAllData()
        {
            return await _context.Bookings.ToListAsync();
        }

        public Task<Booking> GetById(long Id)
        {
            throw new NotImplementedException();
        }

        public Task<bool> UpdateData(Booking data)
        {
            throw new NotImplementedException();
        }
    }
}
