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

        [HttpGet]
        [Route("GetTournament/{id}")]
        public async Task<IActionResult> GetTournament(int id)
        {
            var tournament = await _context.Tournaments.FirstOrDefaultAsync(t => t.TournamentId == id);
            return Ok(tournament);
        }
    }
}