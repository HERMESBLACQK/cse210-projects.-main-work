public class Checklist:Goals{

    private int _bonusTime;
    private int _accomplishBonus;
    private int _completedTime = 0;

    public override string display()
    {
        return $"{this.getName()}, {this.getDesc()} {this.getCompletedTime()}";
    }

    public override int getCompletedTime(){
        //the getcompleted time function will increase the time completed by 1 if a certain conditio is met.
        return _completedTime;
    }
    public override string recordEvents(){

        // this record event should take in the new point allocated and set it as the gained point then add it to the total points
        //then return the new strings containing the updated values.
        return "Eternal";
        }
}