public struct SpeedResult
{
    public double Mph { get; private set; }
    public double Kph { get; private set; }

    public SpeedResult(int mph, double kph){
        Mph = mph; Kph = kph;
    }

}