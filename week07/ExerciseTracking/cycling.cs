public class Cycling : Activity
{
    private double _speed;

    public Cycling(DateTime date, int minutes, double speed)
        : base(date, minutes)
    {
        _speed = speed;
    }

    public override double GetDistance()
    {
        return _speed * GetMinutes() / 60;
    }

    public override double GetSpeed()
    {
        return _speed;
    }

    public override double GetPace()
    {
        return 60 / _speed;
    }

    public override string GetSummary()
    {
        return GetDate().ToString("dd MMM yyyy") +
               "Cycling(" + GetMinutes() + " min)-" +
               "Distance: " + GetDistance().ToString("0.0") + "km" +
               "Speed: " + GetSpeed().ToString("0.0") + "kph" +
               "Pace: " + GetPace().ToString("0.00") + "min per km";
    }
}