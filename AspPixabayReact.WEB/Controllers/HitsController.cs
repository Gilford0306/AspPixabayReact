using AspPixabayReact.BLL.DTO;
using AspPixabayReact.BLL.Interfaces;
using AspPixabayReact.BLL.Services;
using Microsoft.AspNetCore.Mvc;

namespace AspPixabayReact.WEB.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class HitsController : ControllerBase
    {
        private IPicsService _hitsService;
        public HitsController()
        {
            _hitsService = new PicsService();
        }

        [HttpPost("GetHits")]
        public async Task<ActionResult<IEnumerable<PicsDTO>>> GetAllAsync(string? request)
        {
            return Ok(await _hitsService.GetAllHitsAsync(request));
        }
    }
}
