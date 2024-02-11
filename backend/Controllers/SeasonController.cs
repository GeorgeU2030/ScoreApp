using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using System.Text.Json.Serialization;
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
        private readonly ScoreAppDbContext _context;

        public SeasonController(ScoreAppDbContext context)
        {
            _context = context;
        }

        [HttpPost]
        [Route("AddSeason/{torneyId}")]
        public IActionResult AddSeason(int torneyId)
        {
            try
            {
                var torney = _context.Tournaments
                    .Include(t => t.Seasons)
                    .FirstOrDefault(t => t.TournamentId == torneyId);

                if (torney == null)
                {
                    return NotFound("Torney not found");
                }

                var lastSeason = torney.Seasons.OrderByDescending(s => s.SeasonId).FirstOrDefault();
                var newEdition = (lastSeason?.Edition ?? 0) + 1;
                var newSeason = new Season
                {
                    Edition = newEdition,
                    TournamentId = torneyId
                };

                torney.Seasons.Add(newSeason);
                _context.SaveChanges();

                var jsonSerializerOptions = new JsonSerializerOptions
                {
                    ReferenceHandler = ReferenceHandler.Preserve
                };  

                return Ok(JsonSerializer.Serialize(newSeason, jsonSerializerOptions));
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Error interno del servidor: {ex.Message}");
            }
        }

    }
}