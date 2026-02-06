class Student
{
    // Maneira 01
    private string? _name;
    public string Name{
        get{return _name;}
        set{_name = value;}
    }
    // Maneira 02
    public double Average {get;set;}
}