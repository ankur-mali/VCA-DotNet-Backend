using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using System.Data;
using VCA.Repositories;

namespace VCA.Services.Vehical
{
    public class VehicleRepository : IVehicleRepository
    {
        private readonly AppDbContext _dbContext;

        public VehicleRepository(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<List<Dictionary<string, object>>> FindCompByModelIdAsync(int modelId, char compType)
        {
            string query = "SELECT DISTINCT(comp_id), is_configurable, comp_type, comp_name " +
                           "FROM vehicles " +
                           "JOIN components ON vehicles.comp_id = components.id " +
                           "JOIN models ON vehicles.mod_id = @modelId " +
                           "WHERE vehicles.comp_type = @compType";

            var modelIdParam = new SqlParameter("@modelId", SqlDbType.BigInt);
            modelIdParam.Value = modelId;

            var compTypeParam = new SqlParameter("@compType", SqlDbType.Char);
            compTypeParam.Value = compType;

            var result = await _dbContext.Set<IVehicleRepository>().FromSqlRaw(query, modelIdParam, compTypeParam).ToListAsync();

            var resultList = new List<Dictionary<string, object>>();
            foreach (var item in result)
            {
                var dictionary = new Dictionary<string, object>();
                foreach (var kvp in (item as ICollection<KeyValuePair<string, object>>))
                {
                    dictionary.Add(kvp.Key, kvp.Value);
                }
                resultList.Add(dictionary);
            }

            return resultList;
        }
    }
}
