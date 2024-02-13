using System.Text.Json;
using System.Text.Json.Serialization;
using backend.DTO;
using backend.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace backend.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class TournamentController : ControllerBase
    {
        private readonly ScoreAppContext _context;

        public TournamentController(ScoreAppContext context)
        {
            _context = context;
        }

        [HttpGet]
        [Route("GetTournaments")]
        public async Task<ActionResult<IEnumerable<Tournament>>> GetTournaments()
        {
            return await _context.Tournaments.ToListAsync();
        }

        [HttpGet]
        [Route("GetTournament/{id}")]
        public async Task<ActionResult<TournamentDTO>> GetTournament(int id)
        {
            var tournament = await _context.Tournaments.FindAsync(id);
            if (tournament == null)
            {
                return NotFound();
            }

            var seasons = await _context.Seasons
                .Where(s => s.TournamentId == id)
                .ToListAsync();

            var tournamentDTO = new TournamentDTO
            {
                Tournament = tournament,
                Seasons = seasons
            };

            return tournamentDTO;
        }

    }
}