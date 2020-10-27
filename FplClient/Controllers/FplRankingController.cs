using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Net;
using Newtonsoft.Json;
using FplClient.Core.Models;
using FplClient.Core.Services;
using AutoMapper;
using FplClient.Api.Resources;
using ClosedXML.Excel;
using FplClient.Api.Resources.File;
using System.IO;

namespace FplClient.Controllers
{
    [ApiController]
    [Route("fplclient/")]
    public class FplRankingController : ControllerBase
    {
        private readonly IFplRankingService fplRankingService;
        private readonly IMapper mapper;
        public FplRankingController(IFplRankingService fplRankingService,IMapper mapper)
        {
            this.mapper = mapper;
            this.fplRankingService = fplRankingService;
        }

        [HttpGet]
        [Route("entry/{teamId}")]
        public async Task<FplBasicEntryResource> GetTeam(int teamId)
        {
            var basicEntry = await fplRankingService.GetTeam(teamId);
            var basicEntryResources = mapper.Map<FplBasicEntry, FplBasicEntryResource>(basicEntry);
            return basicEntryResources;
        }

        [HttpGet]
        [Route("league/{leagueId}")]
        public async Task<FplClassicLeagueResource> GetClassicLeague(int leagueId)
        {
            var league = await fplRankingService.GetClassicLeague(leagueId);
            var leagueResource = mapper.Map<FplClassicLeague, FplClassicLeagueResource>(league);
            return leagueResource;
        }

        [HttpGet]
        [Route("history/team/{teamId}")]
        public async Task<FplEntryHistoryResource> GetHistoryforTeam(int teamId)
        {
            var history = await fplRankingService.GetHistoryforTeam(teamId);
            var historyResource = mapper.Map<FplEntryHistory, FplEntryHistoryResource>(history);
            return historyResource;
        }

        [HttpGet]
        [Route("history/league/{leagueId}/gameweek/{gameWeek}")]
        public async Task<IEnumerable<FplEntryHistoryResource>> GetHistoryForLeague(int leagueId, int gameWeek)
        {
            var histories = await fplRankingService.GetHistoryForLeague(leagueId,gameWeek);
            var historiesResource = mapper.Map<IEnumerable<FplEntryHistory>, IEnumerable<FplEntryHistoryResource>>(histories);
            return historiesResource;
        }
    }
}
