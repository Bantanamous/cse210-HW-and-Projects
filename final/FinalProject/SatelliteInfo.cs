public class SatelliteInfo
{
    private string name;
    private string tleLine1;
    private string tleLine2;
    
    public SatelliteInfo(string name, string tleLine1, string tleLine2)
    {
        this.name = name;
        this.tleLine1 = tleLine1;
        this.tleLine2 = tleLine2;
    }
    
    public string GetName()
    {
        return name;
    }
    
    public string GetTleLine1()
    {
        return tleLine1;
    }
    
    public string GetTleLine2()
    {
        return tleLine2;
    }
}