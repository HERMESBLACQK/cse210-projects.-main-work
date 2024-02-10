public abstract class Goals{

    private string _name;

    private string _description;
    private int _points;
    private int _completedTime;

    public Goals(){ }
    public virtual void setName(string name){
        _name = name;
    }
    public virtual string getName(){
        return _name;
    }
    public void setCompletedTime(int t){
        _completedTime = t;
    }

    public void setDesc(string desc){
        _description = desc;
    }
    public virtual string getDesc(){
        return _description;
    }

    public void setPoints(int point){
        _points = point;
    }
    public virtual string getPoints(){
        return _name;
    }

    public virtual int getCompletedTime(){
        return _completedTime;
    }
    public abstract string display();
    public abstract string recordEvents();

}