class Person{
    public string? Name;
    public int Age;
    public bool Shorty;
    private string? Sex;

    public void ToPresent(){
        Console.WriteLine($"Olá,meu nome é {Name} e tenho {Age} anos.");
    }
    public string VerifyAge(){
        return Age >= 18 ? "Maior de idade" : "Menor de idade";
    }
}