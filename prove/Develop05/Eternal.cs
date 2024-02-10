public class Eternal:Goals{

    
    public override string display()
    {
        return $"{getName()}, {getDesc()}, {getPoints()}";
    }
    public override string recordEvents(){

        // this record event should take in the new point allocated and set it as the gained point then add it to the total points.
        return "Eternal";
        }
}