using BowlersAPI.Data;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;

namespace BowlersAPI.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class BowlingLeagueController : ControllerBase
    {
        private readonly BowlingLeagueContext _context;

        public BowlingLeagueController(BowlingLeagueContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IEnumerable<BowlerAndTeamViewModel> Get()
        {
            var bowlerData = (
                from bowler in _context.Bowlers
                join team in _context.Teams on bowler.TeamId equals team.TeamId
                select new BowlerAndTeamViewModel
                {
                    BowlerId = bowler.BowlerId,
                    BowlerLastName = bowler.BowlerLastName,
                    BowlerFirstName = bowler.BowlerFirstName,
                    BowlerMiddleInit = bowler.BowlerMiddleInit,
                    BowlerAddress = bowler.BowlerAddress,
                    BowlerCity = bowler.BowlerCity,
                    BowlerState = bowler.BowlerState,
                    BowlerZip = bowler.BowlerZip,
                    BowlerPhoneNumber = bowler.BowlerPhoneNumber,
                    TeamName = team.TeamName
                }
            ).ToList();

            return bowlerData;
        }
    }

    public class BowlerAndTeamViewModel
    {
        public int BowlerId { get; set; }
        public string BowlerLastName { get; set; }
        public string BowlerFirstName { get; set; }
        public string BowlerMiddleInit { get; set; }
        public string BowlerAddress { get; set; }
        public string BowlerCity { get; set; }
        public string BowlerState { get; set; }
        public string BowlerZip { get; set; }
        public string BowlerPhoneNumber { get; set; }
        public string TeamName { get; set; }
    }
}
