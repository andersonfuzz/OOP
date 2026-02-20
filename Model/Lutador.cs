public class Lutador : ILutador
{
    private string? Nome{set;get;}
    private string? Nacionalidade{set;get;}
    private string? Categoria{set;get;}
    private int Idade{set;get;}
    private int Vitorias{set;get;}
    private int Derrotass{set;get;}
    private int Empates{set;get;}
    private double Peso
    {
        set
        {          
            this.Categoria = this.Peso switch
        {
            <= 70.3 => "Leve",
            <= 83.9 => "Medio",
            _ => "Pesado",
        };
            
        }
        get{return Peso;}
        }
    private double Altura{set;get;}

    public Lutador(string nome,string nacionalidade,int idade,int vitorias,int empates,int derrotas,double peso,double altura)
    {
        this.Nome=nome;
        this.Nacionalidade=nacionalidade;
        this.Idade=idade;
        this.Vitorias=vitorias;
        this.Empates=empates;
        this.Derrotass=derrotas;
        this.Peso=peso;
        this.Altura=altura;

       

    }

    public void Apresentar()
    {
        Console.WriteLine("xxxxxxIS TIME!xxxxxx");
        Console.WriteLine($"Nome: | {this.Nome} |");
        Console.WriteLine($"Nacionalidade: | {this.Nacionalidade} |");
        Console.WriteLine($"Idade: | {this.Idade} |");
        Console.WriteLine($"Altura: | {this.Altura} |");
        Console.WriteLine($"Peso: | {this.Peso} |");
        Console.WriteLine($"Categoria: | {this.Categoria} |");
        Console.WriteLine($"|{this.Vitorias} Vitorias x |{this.Empates} Empates| x |{this.Derrotass} Derrotas| |");
        Console.WriteLine("xxxxxxxxxxxxxxxxxxxxx");
    }

    public void EmpatarLuta()
    {
        throw new NotImplementedException();
    }

    public void GanharLuta()
    {
        throw new NotImplementedException();
    }

    public void PerderLuta()
    {
        throw new NotImplementedException();
    }

    public void Status()
    {
        throw new NotImplementedException();
    }
}