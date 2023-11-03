using AspPixabayReact.BLL.DTO;
using Microsoft.AspNetCore.Mvc;

namespace AspPixabayReact.BLL.Interfaces
{
    public interface IPicsService
    {
        Task<ActionResult<IEnumerable<PicsDTO>>> GetAllHitsAsync(string? request);
    }
}
