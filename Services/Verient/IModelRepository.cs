using Azure;
using VCA.Models;
namespace VCA.Services.Verient


{
    public interface IModelRepository
    {
        Task<List<Model>> FindByManufacturerIdAndSegmentIdAsync(long manuId, long segId, int page = 1, int pageSize = 10);

        Task<List<Model>> FindAllByOrderByCreatedAtDescAsync(int page = 1, int pageSize = 10);
    }
}
