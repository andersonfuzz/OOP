public interface IController
{
    public abstract void On();
    public abstract void Off();
    public abstract void OpenMenu();
    public abstract void CloseMenu();
    public abstract void MoreVolume();
    public abstract void LessVolume();
    public abstract void OnMute();
    public abstract void OffMute();
    public abstract void Play();
    public abstract void Pause();
}