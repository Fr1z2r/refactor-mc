using System.Drawing;
using System.Security.Cryptography;

namespace RefactorMc;

public class MethodTask
{
    public void SomeTask()
    {
        SomeTask2(1,2,"Hello World");
        xxx();

    }

    private void xxx(){}
    
    //ctrl+alt+shift+up
    public async Task SomeTask2(int a, int b, string c)//ctrl+alt+shift+right  + safe delete c
    {
        //alt+shift+down // multicursor copy name to value
        //then reorder args
        var arg2 = 1;
        var arg3 = 2;
        var arg1 = 3;
    }   

    public void SomeTask3(int a, int b, string c)
    {
        File.ReadAllTextAsync("File1.txt"); // add await
    }

    private void ExtractMethod(Point a, Point b)
    {
        var distance1 = Math.Sqrt(Math.Pow(a.X, 2) + Math.Pow(a.Y, 2)); //ctrl+alt+v   +   ctrl+alt+m

        var c = a.X + b.X;
        
        var distance2 = Math.Sqrt(Math.Pow(a.X, 2) + Math.Pow(a.Y, 2));
        
        
    }


    private void RenameVars()
    {
        //ctrl+shift+/
        //rename data
        // ctrl+d
        
        /*var data = "some data";

        Console.WriteLine(data);*/
        
        var data = "other data";

        Console.WriteLine(data);
    }
}