#pragma warning disable CA1050 // Declare types in namespaces
public abstract class Activity
#pragma warning restore CA1050 // Declare types in namespaces
{

    protected string _name;
    protected double _speed;
    protected double _pace;
    protected double _mins;
    protected double _distance;
    protected string _date;


#pragma warning disable IDE1006 // Naming Styles
    public void setSpeed(double speed)
#pragma warning restore IDE1006 // Naming Styles
    {
        _speed = speed;
    }

#pragma warning disable IDE1006 // Naming Styles
    public void setPace(double pace){
        
        _pace = pace;
    }
#pragma warning restore IDE1006 // Naming Styles

#pragma warning disable IDE1006 // Naming Styles
    public void setDistance(double dist){
        _distance = dist;
    }
#pragma warning restore IDE1006 // Naming Styles

#pragma warning disable IDE1006 // Naming Styles
    public void setTime(double time){
        _mins = time;
    }
#pragma warning restore IDE1006 // Naming Styles
#pragma warning disable IDE1006 // Naming Styles
    public void setDate(string date){
        _date = date;
    }
#pragma warning restore IDE1006 // Naming Styles
#pragma warning disable IDE1006 // Naming Styles
    public virtual double getDistance()
#pragma warning restore IDE1006 // Naming Styles
    {
        return _distance;
    }

#pragma warning disable IDE1006 // Naming Styles
    public virtual double getSpeed(){
        return _speed;
    }
#pragma warning restore IDE1006 // Naming Styles

#pragma warning disable IDE1006 // Naming Styles
    public virtual double getPace()
#pragma warning restore IDE1006 // Naming Styles
    {
        return _pace;
    }

    public abstract string GetSummary();
}