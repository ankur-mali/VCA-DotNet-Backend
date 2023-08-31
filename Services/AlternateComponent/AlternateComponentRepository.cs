using Microsoft.EntityFrameworkCore;
using VCA.Repositories;

namespace VCA.Services.AlternateComponent
{



    public class AlternateComponentRepository : IAlternateComponentRepository
    {
        private readonly AppDbContext _dbContext;

        public AlternateComponentRepository(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<List<Dictionary<string, object>>> FindByModelIdAndCompIdAsync(int modId, int compId)
        {
            var queryResult = await _dbContext.AlternateComponents
                .FromSqlRaw("SELECT c.id, c.comp_name " +
                            "FROM alternate_components a " +
                            "JOIN components c ON a.alt_comp_id = c.id " +
                            "WHERE a.mod_id = {0} AND a.comp_id = {1} AND a.comp_id <> a.alt_comp_id",
                            modId, compId)
                .ToListAsync();

            // Convert the result to a list of dictionaries
            var resultList = queryResult.Select(result => new Dictionary<string, object>
            {
                { "id", result.Id },
                { "deltaPrice", result.DeltaPrice },
                { "altCompId", new Dictionary<string, object>
                    {
                         { "id", result.AltComponent.Id },
                        { "compName", result.AltComponent.CompName }
                        // Include other properties of Component entity if needed
                    }
                }
            }).ToList();

            return resultList;
        }
    }
}
