namespace RefactorMc;

public class GeneralTask
{
    private int PrivateNumber; //code style settings
    
    //alt-f12 for warn and errors
    //ctrl +m +o
    //ctrl-f12
    
    
    //alt+ins or .ctor
    
    
    
    public void InlineTask()
    {
        //ctrl+w
        var methodTask = new MethodTask();  //ctrl+alt+n, then ctrl+alt+v
        methodTask.SomeTask2(1,2,"Hello World");  //ctrl+b + ctrl-tab + ctrl-e
    }

    public void LiveTemplates()
    {
        //cw, prop, for, forr, foreach, myt, testa, ctor
    }

    
}