class Pessoa
{
    //Atributos
    public string? Nome; 
    public int Idade;

    public Pessoa()
    {
        this.Nome="Nenhum nome atribuído";
        this.Idade=0;
    }
    //Método de apresentaçã
    public static void Apresentacao(string Nome)
    {
        Console.WriteLine($"Olá,meu nome é {Nome}");
    }
    public string VerificarIdade()
    {
        return Idade>=18?"Maior de idade":"Menor de idade";
    }
    public void Status()
    {
        Console.WriteLine($"Nome: {this.Nome},idade {this.Idade}");
    }
}