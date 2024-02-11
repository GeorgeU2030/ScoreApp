using backend.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace backend.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class TournamentController : ControllerBase
    {
        private readonly ScoreAppDbContext _context;

        public TournamentController(ScoreAppDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        [Route("GetTournaments")]
        public async Task<IActionResult> GetTournaments()
        {
            var tournaments = await _context.Tournaments.ToListAsync();
            return Ok(tournaments);
        }
    }
}