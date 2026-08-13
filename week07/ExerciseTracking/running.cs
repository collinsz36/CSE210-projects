public class Running : Activity
{
    private double _distance;

    public Running(DateTime date, int minutes, double distance)
        : base(date, minutes)
    {
        _distance = distance;
    }

    public override double GetDistance()
    {
        return _distance;
    }

    public override double GetSpeed()
    {
        return _distance * 60 / GetMinutes();
    }

    public override double GetPace()
    {
        return GetMinutes() / _distance;
    }

    public override string GetSummary()
    {
        return GetDate().ToString("dd MMM yyyy") +
               "Running(" + GetMinutes() + " min) - " +
               "Distance: " + GetDistance().ToString("0.0") + "km" +
               "Speed: " + GetSpeed().ToString("0.0") + "kph" +
               "Pace: " + GetPace().ToString("0.00") + "min per km";
    }
}