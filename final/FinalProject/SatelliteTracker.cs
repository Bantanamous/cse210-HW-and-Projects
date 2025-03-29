using System.Text.Json;
public class SatelliteTracker
{
    private const string ApiKey = "UUFAXX-YBP3HG-R5MBFP-5G0A";
    private const string BaseUrl = "https://api.n2yo.com/rest/v1/satellite/";
    
    public static async Task<SatelliteInfo> GetSatelliteInfo(int noradId)
    {
        string url = $"{BaseUrl}tle/{noradId}&apiKey={ApiKey}";
        using HttpClient client = new HttpClient();
        string response = await client.GetStringAsync(url);
        return JsonSerializer.Deserialize<SatelliteInfo>(response);
    }
    
    public static async Task<PassPrediction> GetNextPass(int noradId, double latitude, double longitude, double altitude)
    {
        string url = $"{BaseUrl}predicted_passes/{noradId}/{latitude}/{longitude}/{altitude}/1/&apiKey={ApiKey}";
        using HttpClient client = new HttpClient();
        string response = await client.GetStringAsync(url);
        return JsonSerializer.Deserialize<PassPrediction>(response);
    }
}