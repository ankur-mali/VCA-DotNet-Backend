using Microsoft.AspNetCore.Mvc;
using VCA.Services.Verient;

namespace VCA.Controllers
{
    [ApiController]
    [Route("api/models")]
    public class ModelController : ControllerBase
    {
        private readonly IModelRepository _modelRepository;

        public ModelController(IModelRepository modelRepository)
        {
            _modelRepository = modelRepository;
        }

        [HttpGet]
        [Route("all")]
        public async Task<IActionResult> GetAllModels()
        {
            var models = await _modelRepository.FindAllByOrderByCreatedAtDescAsync();
            return Ok(models);
        }

        [HttpGet]
        [Route("manufacturer/{manuId}/{segId}")]
        public async Task<IActionResult> GetModelsByManufacturerAndSegment(int manuId, int segId)
        {
            var models = await _modelRepository.FindByManufacturerIdAndSegmentIdAsync(manuId, segId);
            return Ok(models);
        }
    }
}
