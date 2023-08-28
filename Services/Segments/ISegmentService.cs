using Microsoft.EntityFrameworkCore;
using VCA.Models;
using VCA.Repositories;
namespace VCA.Services.Segments
{
    public interface ISegmentService
    {
        List<Segment> GetAllSegments();

    }

}
