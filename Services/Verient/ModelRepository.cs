using VCA.Repositories;
using VCA.Models;
using Microsoft.EntityFrameworkCore;
using VCA.Services.Verient;
using System.Linq;

namespace VCA.Services.Verient

{
    public class ModelRepository : IModelRepository
    {
        private readonly AppDbContext _dbContext;

        public ModelRepository(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<List<Model>> FindByManufacturerIdAndSegmentIdAsync(int manuId, int segId, int page = 1, int pageSize = 10)
        {
            return await _dbContext.Models
                .Where(m => m.ManuId == manuId && m.SegId == segId)
                .Skip((page - 1) * pageSize)
                .Take(pageSize)
                .Include(m => m.Manufacturer) // Include the Manufacturer navigation property
                .Include(m => m.Segment) // Include the Segment navigation property
                .ToListAsync();
        }

        public async Task<List<Model>> FindAllByOrderByCreatedAtDescAsync(int page = 1, int pageSize = 10)
        {
            return await _dbContext.Models
                .OrderByDescending(m => m.CreatedAt)
                .Skip((page - 1) * pageSize)
                .Take(pageSize)
                .Include(m => m.Manufacturer) // Include the Manufacturer navigation property
                .Include(m => m.Segment) // Include the Segment navigation property
                .ToListAsync();
        }
    }

}
