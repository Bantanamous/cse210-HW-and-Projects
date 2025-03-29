using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;

public class Program
{
    public static async Task Main(string[] args)
    {
        int issId = 25544;
        double latitude = 40.7128;
        double longitude = -74.0060;
        double altitude = 10.0;
        
        SatelliteInfo issInfo = await SatelliteTracker.GetSatelliteInfo(issId);
        Console.WriteLine($"Satellite: {issInfo.GetName()}\nTLE1: {issInfo.GetTleLine1()}\nTLE2: {issInfo.GetTleLine2()}");
        
        PassPrediction nextPass = await SatelliteTracker.GetNextPass(issId, latitude, longitude, altitude);
        Console.WriteLine($"Next pass starts at {nextPass.GetStartTime()} with azimuth {nextPass.GetStartAzimuth()}");
    }
}