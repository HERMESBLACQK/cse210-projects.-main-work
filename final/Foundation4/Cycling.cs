#pragma warning disable CA1050 // Declare types in namespaces
public class Cycling : Activity
#pragma warning restore CA1050 // Declare types in namespaces
{

   public override double getDistance()
    {
         return _distance;
    }
    public override double getSpeed()
    {
        _speed = (getDistance()/_mins) * 60;
        return _speed;
    }
    public override double getPace()
    {
        _pace = _mins / _distance;
        return _pace;
    }
    public override string GetSummary()
    {
        return $"{_date} Cycling ({_mins} min)- Distance {getDistance()}miles, Speed {getSpeed()} mph, Pace: {getPace()} min per mile ";
    }

}