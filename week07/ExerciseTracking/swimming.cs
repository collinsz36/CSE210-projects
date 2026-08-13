public class Swimming : Activity
{
    private int _laps;

    public Swimming(DateTime date, int minutes, int laps)
        : base(date, minutes)
    {
        _laps = laps;
    }

    public override double GetDistance()
    {
        return _laps * 50 / 1000;
    }

    public override double GetSpeed()
    {
        return GetDistance() * 60 / GetMinutes();
    }

    public override double GetPace()
    {
        return GetMinutes() / GetDistance();
    }

    public override string GetSummary()
    {
        return GetDate().ToString("dd MMM yyyy") +
               "Swimming(" + GetMinutes() + " min)-" +
               "Distance: " + GetDistance().ToString("0.0") + "km" +
               "Speed: " + GetSpeed().ToString("0.0") + "kph" +
               "Pace: " + GetPace().ToString("0.00") + "min per km";
    }
}