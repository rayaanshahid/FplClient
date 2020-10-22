using System;
using AutoMapper;
using FplClient.Api.Resources;
using FplClient.Core.Models;

namespace FplClient.Api.Mapping
{
    public class MappingProfile: Profile
    {
        public MappingProfile()
        {
            CreateMap<FplBasicEntry, FplBasicEntryResource>();
            CreateMap<FplAutomaticSub, FplAutomaticSubResource > ();
            CreateMap <FplClassicLeagueEntry, FplClassicLeagueEntryResource > ();
            CreateMap<FplEntryLeagues, FplEntryLeaguesResource>();
            CreateMap<FplEntryHeadToHeadLeague, FplEntryHeadToHeadLeagueResource>();
            CreateMap<FplEntryClassicLeague, FplEntryClassicLeagueResource>();
            CreateMap<FplClassicLeague, FplClassicLeagueResource>();

            CreateMap<FplNewLeagueEntries, FplNewLeagueEntriesResource>();
            CreateMap<FplClassicLeagueProperties, FplClassicLeaguePropertiesResource>();
            CreateMap<FplClassicLeagueStandings, FplClassicLeagueStandingsResource>();
            CreateMap<FplNewLeagueEntry, FplNewLeagueEntryResource>();
            CreateMap<FplClassicLeagueEntry, FplClassicLeagueEntryResource>();

            CreateMap<FplEntryHistory, FplEntryHistoryResource>();
            CreateMap<FplEntryHistoryChip, FplEntryHistoryChipResource>();
            CreateMap<FplEntrySeasonHistory, FplEntrySeasonHistoryResource>();
            CreateMap<FplEventEntryHistory, FplEventEntryHistoryResource>();                
        }
    }
}
