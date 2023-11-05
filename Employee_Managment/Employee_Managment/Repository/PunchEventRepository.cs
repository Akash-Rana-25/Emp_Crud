using Employee_Managment.Context;
using Employee_Managment.Models;
using Microsoft.EntityFrameworkCore;

namespace Employee_Managment.Repository
{
    public class PunchEventRepository : IPunchEventRepository
    {
        private readonly ApplicationDbContext _context;

        public PunchEventRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<PunchEvent>> GetPunchEventAsync()
        {
            return await _context.PunchEvents.ToListAsync();
        }

        public async Task CreatePunchEventAsync(PunchEvent punchEvent)
        {
            _context.PunchEvents.Add(punchEvent);
            await _context.SaveChangesAsync();
        }
    }
}
