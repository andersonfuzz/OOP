class Conta{
    string? NumConta{set;get;}
     string Tipo{set;get;}
     string? Dono{set;get;}
     double Saldo{set;get;}
     bool Status{set;get;}

    public Conta(string tipo,string dono)
    {
        this.NumConta=NumAleatorio();
        this.Status=true;
        this.Tipo=tipo;
        this.Dono=dono;
        switch (tipo)
        {
            case "cc":
            this.Saldo=50;
            break;
            case "cp":
            this.Saldo=150;
            break;
            default:
            Console.WriteLine("Tipo de conta inválida,não foi possível abrir sua conta.");
            break;
        }
    }

    public void AbrirConta(){}
    public void FecharConta(){}
    public void Depositar(){}
    public void Sacar(){}
    public void PagarMensal(){}
    
    string NumAleatorio()
    {
        Random random=Random.Shared;
        string num="";

        for(int i = 0; i < 10; i++)
        {
            num += random.Next(0, 9).ToString();
        }
        return num;
    }
    public void StatusGeralConta()
    {
        Console.WriteLine($"Conta aberta?{this.Status}. Dono da Conta: {this.Dono}.Saldo {this.Saldo}");
        Console.WriteLine($"Numero da conta: {this.Tipo}:{this.NumConta}");
    }
}