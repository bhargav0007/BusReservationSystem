using Microsoft.EntityFrameworkCore;
using ReservationDataAccessLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReservationDataAccessLayer.Repository
{
    public class BusRepository : IRepository<Bus>
    {
        private readonly ReservationDbContext _context;
        public BusRepository(ReservationDbContext context)
        {
            _context = context;
        }
        public async Task<Bus> AddData(Bus data)
        {
            await _context.Buss.AddAsync(data);
            await _context.SaveChangesAsync();
            return data;
        }

        public Task<bool> DeleteData(long id)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<Bus>> GetAllData()
        {
            return await _context.Buss.ToListAsync();
        }

        public Task<Bus> GetById(long Id)
        {
            throw new NotImplementedException();
        }

        public Task<bool> UpdateData(Bus data)
        {
            throw new NotImplementedException();
        }
    }
}
