using System.Data;

class Caneta
{
     string modelo;
     float ponta;
    bool tampada;

    //Construtor
    public Caneta()
    {
        this.Destampar();
    }
    public Caneta(float ponta,string modelo)
    {
        this.SetPonta(ponta);
        this.SetModelo(modelo);
        this.SetTampada(true);
    }
    //Metodos Acessores e Modificadores
    public bool GetTampada()
    {
        return this.tampada;
    }
    public void SetTampada(bool tampada)
    {
        this.tampada=tampada;
    }
    public string GetModelo(){
        return this.modelo;
    }
    public void SetModelo(string modelo)
    {
        this.modelo=modelo;
    }
    public float GetPonta()
    {
        return this.ponta;
    }
    public void SetPonta(float ponta)
    {
        this.ponta=ponta;
    }

    public void Tampar()
    {
        this.SetTampada(true);
    }
    public void Destampar()
    {
        this.SetTampada(false);
    }

    public void Rabiscar()
    {
        Console.WriteLine(GetTampada()==true?"Rabiscando":"Destampe antes de rabiscar.");
    }
    public void Status()
    {
        Console.WriteLine($"Modelo da caneta é {GetModelo()}");
        Console.WriteLine($"A ponta usada é {GetPonta()}");
        Console.WriteLine($"Está tampada? {this.GetTampada()}");
    }
}