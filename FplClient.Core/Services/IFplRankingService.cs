using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using FplClient.Core.Models;

namespace FplClient.Core.Services
{
    public interface IFplRankingService
    {
        public Task<FplBasicEntry> GetTeam(int teamId);
        public Task<FplClassicLeague> GetClassicLeague(int leagueId);
        public Task<FplEntryHistory> GetHistoryforTeam(int teamId);
        public Task<IEnumerable<FplEntryHistory>> GetHistoryForLeague(int leagueId, int gameWeek);
    }
}
