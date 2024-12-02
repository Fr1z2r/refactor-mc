namespace RefactorMc;


//shift-r: extract P1 & P2, then pullup P3
public class ExtractTask 
{
    public string Property1 { get; set; } //TreatWarningsAsErrors
    public string Property2 { get; set; }
    public string Property3 { get; set; }
}

//move interface to other file and dir, adjust namespace

