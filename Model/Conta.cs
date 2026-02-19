class Conta{
    int NumConta{set;get;}
     string Tipo{set;get;}
     string? Nome{set;get;}
     double Saldo{set;get;}
     bool Status{set;get;}

                //acessei o tipo antes de iniciar,corrigir depois
    public void AbrirConta(string nome,string tipo)
    {
        if (this.Status)
        {
            Console.WriteLine("Você já possui uma conta.");            
        }
        else if(tipo.ToLower()!="cc" && tipo.ToLower() != "cp")
        {
            Console.WriteLine("Escolha uma opção válida 'cc' ou 'cp'");
        }
        else
        {
            this.Saldo=this.Tipo=="cc"?50:150;
            this.Nome=nome;
            this.Tipo=tipo;
            this.Status=true;
            this.NumConta=NumAleatorio();
            Console.WriteLine("Conta criada.");
        }
    }
    public void FecharConta()
    {
        if (this.Saldo == 0 && this.Status==true)
        {
            this.Nome="usuário não encontrado";
            this.NumConta=00000000;
            this.Status=false;
            this.Tipo="";
            Console.WriteLine("Cont encerrada.");
            
        }else Console.WriteLine("Não é possível encerrar conta.");
    }
    public void Depositar(double valor){
        if (!this.Status)
        {
            Console.WriteLine("Abra uma conta para ter acesso a essa funcionalidade.");
        }else if (valor<=0)
        {
            Console.WriteLine("Informe um valor válido");
        }else this.Saldo+=valor;
    }
                //atualmente ta podendo sacar valor negativo kkkk verificar isso
    public void Sacar(double valor)
    {
        if (!this.Status)
        {
            Console.WriteLine("Abra uma conta para ter acesso a essa funcionalidade.");
        }           //   100 < -96
        else if (this.Saldo<valor)
        {
            Console.WriteLine("Saldo insuficiente");
        }else this.Saldo-=valor;
    }
    public void PagarMensal()
    {
        if (!this.Status)
        {
            Console.WriteLine("Abra uma conta para ter acesso a essa funcionalidade.");
            
        }
        else if (this.Saldo<50)
        {
            Console.WriteLine("Saldo insuficiente");
        }else
        {
        this.Saldo-=50;
         Console.WriteLine("Taxa debitada com sucesso.");
        }
    }

    static int NumAleatorio()
    {
        Random random=Random.Shared;
        return random.Next(10000000,100000000);
    }
    
    public void StatusGeralConta()
    {
        Console.WriteLine($"Conta aberta? {this.Status}.");
         Console.WriteLine($"Dono da Conta: {this.Nome}.");
        Console.WriteLine($"Numero da conta: {this.Tipo}:{this.NumConta}");
         Console.WriteLine($"Saldo R$:{this.Saldo},00");
        Console.WriteLine("-----------------------------");
    }
}