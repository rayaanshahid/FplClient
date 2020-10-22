using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using ClosedXML.Excel;
using FplClient.Core.Models;
using FplClient.Core.Models.File;
using FplClient.Core.Services;
using Newtonsoft.Json;

namespace FplClient.Services
{
    public class FplRankingService: IFplRankingService
    {
        private readonly HttpClient client;

        public FplRankingService()
        {
            client = new HttpClient();
        }

        async Task<FplClassicLeague> IFplRankingService.GetClassicLeague(int leagueId)
        {
            ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;
            var url = ClassicLeagueUrlFor(leagueId, 1);
            var json = await client.GetStringAsync(url);
            return await Task.FromResult(JsonConvert.DeserializeObject<FplClassicLeague>(json));
        }

        async Task<FplBasicEntry> IFplRankingService.GetTeam(int teamId)
        {
            ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;
            var url = $"https://fantasy.premierleague.com/api/entry/{teamId}/";
            var json = await client.GetStringAsync(url);
            return await Task.FromResult(JsonConvert.DeserializeObject<FplBasicEntry>(json));
        }

        async Task<FplEntryHistory> IFplRankingService.GetHistoryforTeam(int teamId)
        {
            ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;
            var url = HistoryUrlFor(teamId);
            var json = await client.GetStringAsync(url);
            return await Task.FromResult(JsonConvert.DeserializeObject<FplEntryHistory>(json));
        }

        async Task<IEnumerable<FplEntryHistory>> IFplRankingService.GetHistoryForLeague(int leagueId, int gameWeek)
        {
            List<FplEntryHistory> histories = new List<FplEntryHistory>();

            ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;
            var url = ClassicLeagueUrlFor(leagueId, 1);
            var json = await client.GetStringAsync(url);
            var league = JsonConvert.DeserializeObject<FplClassicLeague>(json);

            foreach (FplClassicLeagueEntry entry in league.Standings.Entries){
                var historyUrl = HistoryUrlFor(entry.Entry);
                var historyJson = await client.GetStringAsync(historyUrl);
                histories.Add(JsonConvert.DeserializeObject<FplEntryHistory>(historyJson));
            }

            CreateExcelFile(histories, league.Standings.Entries, gameWeek);
            return await Task.FromResult(histories);
        }

        private static string ClassicLeagueUrlFor(int leagueId, int? page)
        {
            var baseUrl = $"http://fantasy.premierleague.com/api/leagues-classic/{leagueId}/standings/";
            var suffix = $"?page_new_entries={page ?? 1}&page_standings={page ?? 1}";
            return $"{baseUrl}{suffix}";
        }

        private static string HistoryUrlFor(int teamId)
        {
            return $"https://fantasy.premierleague.com/api/entry/{teamId}/history/";
        }
        private static int[] MaxPointsPerGameWeek(List<PointsHistory> pointsHistories, int gameWeek)
        {
            int[] maximums = new int[gameWeek];
            for (int i = 0; i < gameWeek; i++)
            {
                maximums[i] = pointsHistories[0].PlayerGWPoints[i];
                for (int j = 1; j <  pointsHistories.Count; j++)
                {
                    if ( maximums[i] < pointsHistories[j].PlayerGWPoints[i])
                    {
                        maximums[i] = pointsHistories[j].PlayerGWPoints[i];
                    }
                }
            }
            return maximums;
        }
        private static void CreateExcelFile(List<FplEntryHistory> histories, IEnumerable<FplClassicLeagueEntry> entries, int gameWeek)
        {
            //Fill in players names
            List<string> names = new List<string>();
            foreach (var entry in entries)
            {
                names.Add(entry.PlayerName);
            }

            //Fill in the data
            List<PointsHistory> pointsHistories = new List<PointsHistory>();
            foreach (var history in histories)
            {
                PointsHistory pointsHistory = new PointsHistory();
                pointsHistory.PlayerGWPoints = new List<int>();
                var count = history.GameweekHistory.Count;
                int start;
                if (count == gameWeek)
                {
                    start = 0;
                }
                else
                {
                    start = gameWeek - count;
                }
                int listIndex = 0;
                foreach (var gwHistory in history.GameweekHistory)
                {
                    if (listIndex < start)
                    {
                        for (listIndex = 0; listIndex < start; listIndex++)
                        {
                            pointsHistory.PlayerGWPoints.Add(0);
                        }
                    }

                    pointsHistory.PlayerGWPoints.Add(gwHistory.Points);
                }
                pointsHistories.Add(pointsHistory);
            }

            var maxPoints = MaxPointsPerGameWeek(pointsHistories, gameWeek);

            //create an Excel file
            using (var workbook = new XLWorkbook())
            {
                var worksheet = workbook.Worksheets.Add("Season History");
                var currentRow = 1;

                worksheet.Cell(currentRow, 1).Value = "Game Week";
                worksheet.Cell(currentRow, 1).Style.Fill.BackgroundColor = XLColor.FromArgb(220, 220, 220);
                int nameIndex = 0;
                for (int index = 2; index < names.Count+2; index++)
                {
                    worksheet.Cell(currentRow, index).Value = names[nameIndex];
                    worksheet.Cell(currentRow, index).Style.Fill.BackgroundColor = XLColor.FromArgb(220, 220, 220);
                    nameIndex++;
                }

                int column = 1;
                for (int gw = 1; gw <= gameWeek; gw++)
                {
                    worksheet.Cell(gw+1, column).Value = gw;
                }
                int points;
                for (int player = 0; player < pointsHistories.Count; player++)
                {
                    points = 0;
                    column++;
                    int count = pointsHistories[player].PlayerGWPoints.Count;
                    for (int row = 2; row < count+ 2; row++)
                    {
                        
                        worksheet.Cell(row, column).Value = pointsHistories[player].PlayerGWPoints[points];
                        if (maxPoints[points] == pointsHistories[player].PlayerGWPoints[points])
                        {
                            worksheet.Cell(row, column).Style.Fill.BackgroundColor = XLColor.FromArgb(144, 238, 144);
                        }
                        points++;
                    }
                }
                workbook.SaveAs("LeagueHistory.xlsx");
            }
        }
    }
}
