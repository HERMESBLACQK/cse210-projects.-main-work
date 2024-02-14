#pragma warning disable CA1050 // Declare types in namespaces
public class Swimming:Activity{
#pragma warning restore CA1050 // Declare types in namespaces

    private int _numberOfLap;


#pragma warning disable IDE1006 // Naming Styles
    public void setLap(int lap){
        _numberOfLap = lap;
    }
#pragma warning restore IDE1006 // Naming Styles
    public override double getDistance()
    {
         _distance= _numberOfLap * 50/1000;
         return _distance;
    }
    public override double getSpeed()
    {
        _speed = getDistance()/_mins;
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