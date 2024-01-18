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

        public async Task<bool> DeleteData(long id)
        {
            var data = await _context.Buss.FirstOrDefaultAsync(x => x.Id == id);
            if (data != null)
            {
                _context.Remove(data);
                _context.SaveChanges();
                return true;
            }
            return false;

        }

        public async Task<IEnumerable<Bus>> GetAllData()
        {
            return await _context.Buss.ToListAsync();
        }

        public async Task<Bus> GetById(long Id)
        {
            var result = await _context.Buss.FirstOrDefaultAsync(x => x.Id == Id);
            return result;
        }

        public async Task<bool> UpdateData(Bus data)
        {
            var bus = await GetById(data.Id);
            if (bus != null)
            {
                _context.Entry(data).State = EntityState.Modified;
                _context.SaveChanges();
                return true;
            }
            return false;
        }
    }
}
