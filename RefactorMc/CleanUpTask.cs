namespace RefactorMc;

public class CleanUpTask
{
    //ctrl+alt+l or ctrl+alt+f
    public CleanUpTask()
    {
var someParam = 0;
    }

    public IEnumerable<int> GenerateRandomNumbers(int count)
    {
        //reverse loop
        //convert to while
        for (int i = 0; 
             i < count; i++)
        {//remove braces
            yield return new Random().Next();
            
            
            
        } }
}