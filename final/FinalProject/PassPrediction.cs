public class PassPrediction
{
    private double startAzimuth;
    private double endAzimuth;
    private DateTime startTime;
    private DateTime endTime;
    
    public PassPrediction(double startAzimuth, double endAzimuth, DateTime startTime, DateTime endTime)
    {
        this.startAzimuth = startAzimuth;
        this.endAzimuth = endAzimuth;
        this.startTime = startTime;
        this.endTime = endTime;
    }
    
    public double GetStartAzimuth()
    {
        return startAzimuth;
    }
    
    public double GetEndAzimuth()
    {
        return endAzimuth;
    }
    
    public DateTime GetStartTime()
    {
        return startTime;
    }
    
    public DateTime GetEndTime()
    {
        return endTime;
    }
}