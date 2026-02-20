public class RemoteControl : IController
{
     int Volume{set;get;}
     bool Connected{set;get;}
     bool Playing{set;get;}

    public RemoteControl()
    {
        this.Volume=50;
        this.Connected=false;
        this.Playing=false;


    }

    public void On()
    {
        this.Connected=true;
    }

    public void Off()
    {
        this.Connected=false;
    }

    public void OpenMenu()
    {
        Console.WriteLine($"-----MENU-----");
        Console.WriteLine($"Está ligado? {this.Connected}");
        Console.WriteLine($"Está tocando? {this.Playing}");
        Console.Write($"Volume: {this.Volume} ");
        for(int i=0 ; i < this.Volume ; i++)
        {
            Console.Write("/");
        }
        Console.WriteLine();
    }

    public void CloseMenu()
    {
        Console.WriteLine("Fechando Menu...");
    }

    public void MoreVolume()
    {
        if(this.Connected) this.Volume+=5;
    }

    public void LessVolume()
    {
        if(this.Connected) this.Volume-=5;
    }

    public void OnMute()
    {
        if(this.Connected && this.Volume > 0) this.Volume=0;
    }

    public void OffMute()
    {
        if(this.Connected && this.Volume == 0) this.Volume=50;
    }

    public void Play()
    {
        if(this.Connected && !this.Playing) this.Playing=true;
    }

    public void Pause()
    {
        if(this.Connected && this.Playing) this.Playing=false;
    }
}