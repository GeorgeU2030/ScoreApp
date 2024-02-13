using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using backend.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace backend.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class SeasonController : ControllerBase
    {
        private readonly ScoreAppContext _context;

        public SeasonController(ScoreAppContext context)
        {
            _context = context;
        }


        [HttpGet("{id}")]
        public async Task<ActionResult<Season>> GetSeason(int id)
        {
            var season = await _context.Seasons.FindAsync(id);

            if (season == null)
            {
                return NotFound();
            }

            return season;
        }

        [HttpPost("{tournamentId}")]
        public async Task<ActionResult<Season>> PostSeason(int tournamentId, [FromBody] Season season)
        {
            var lastseason = await _context.Seasons
                .Where(s => s.TournamentId == tournamentId)
                .OrderByDescending(s => s.Edition)
                .FirstOrDefaultAsync();

            season.Edition = (lastseason != null) ? lastseason.Edition + 1 : 1;
            season.TournamentId = tournamentId;
            
            _context.Seasons.Add(season);
            await _context.SaveChangesAsync();
            return CreatedAtAction("GetSeason", new { id = season.Id }, season);
        }

        [HttpGet("ByTournament/{tournamentId}")]
        public async Task<ActionResult<IEnumerable<Season>>> GetSeasonsByTournament(int tournamentId)
        {
            var seasons = await _context.Seasons
                .Where(s => s.TournamentId == tournamentId)
                .ToListAsync();

            if (seasons == null || !seasons.Any())
            {
                return NotFound($"No season for torney with ID {tournamentId}.");
            }

            return seasons;
        }

    }
}