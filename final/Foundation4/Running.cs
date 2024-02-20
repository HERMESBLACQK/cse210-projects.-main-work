#pragma warning disable CA1050 // Declare types in namespaces
public class Running:Activity{
#pragma warning restore CA1050 // Declare types in namespaces

    private double _lenght;
#pragma warning disable IDE1006 // Naming Styles
    public void setLength(double l){
        _lenght = l;
    }
#pragma warning restore IDE1006 // Naming Styles
    public override double getDistance()
    {
         _distance= _lenght * 50/1000;
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
        return $"{_date} Running({_mins} min) Distance {getDistance()} miles, Speed {getSpeed()} mph, Pace: {getPace()} min per mile ";
    }
}