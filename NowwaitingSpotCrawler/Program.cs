using Microsoft.EntityFrameworkCore;
using NowwaitingSpotCrawler.Contexts;
using NowwaitingSpotCrawler.Dtos.SpotDetail.Response;
using NowwaitingSpotCrawler.Entities;
using NowwaitingSpotCrawler.Helpers;
using System.Net.Http.Json;

Logger.Log("START..");

//상수
const int MAX_ERROR_COUNT = 5000;
const string CONNECTION_STRING = "Data Source=localhost\\SQLEXPRESS;Initial Catalog=NowWaiting;Integrated Security=True";

//초기화
var context = new WaitingDBContext(CONNECTION_STRING);
var client = new HttpClient();

//DB
await context.Database.EnsureCreatedAsync();

//SpotId
var maxSpotId = context.Spots.OrderByDescending(x => x.Id).FirstOrDefault()?.Id ?? 0;
var spotId = maxSpotId + 1;
Logger.Log($"maxSpotId: {maxSpotId}");

//조회
var errorCount = 0;
try
{
    context.Database.OpenConnection();
    context.Database.ExecuteSqlRaw("SET IDENTITY_INSERT dbo.TBL_SPOT ON");

    for (; ; spotId++)
    {
        var response = await client.GetAsync($"https://nowwaiting.co/web_api/v1/spots/{spotId}");

        //Spot 정보가 없는 경우
        if (response.StatusCode == System.Net.HttpStatusCode.NotFound)
        {
            errorCount++;

            if (errorCount < MAX_ERROR_COUNT)
            {
                Logger.Log($"ERROR - spotId:{spotId}, errorCount:{errorCount}");
                continue;
            }

            break;
        }
        errorCount = 0;

        //Insert
        var spotDetailResponse = await response.Content.ReadFromJsonAsync<SpotDetailResponse>();
        var spot = new SpotEntity
        {
            Id = spotDetailResponse.Id,
            Name = spotDetailResponse.Name,
            Phone = spotDetailResponse.Phone,
            Address = spotDetailResponse.Address,
            SpotType = spotDetailResponse.SpotType
        };
        context.Spots.Add(spot);

        //Save
        try
        {
            await context.SaveChangesAsync();

            Logger.Log($"SAVED {spotId}");
        }
        catch (Exception ex)
        {
            Logger.Log($"SAVE EXCEPTION - {ex.Message}");
        }
    }
}
finally
{
    context.Database.ExecuteSqlRaw("SET IDENTITY_INSERT dbo.TBL_SPOT OFF");
    context.Database.CloseConnection();
}

Logger.Log("END..");
Console.ReadLine();