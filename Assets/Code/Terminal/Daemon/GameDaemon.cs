#pragma warning disable 0649
public class GameDaemon : GameFile
{
    public Node Node { get; set; }
    public virtual void Panic(){
        Node.RemoveFile(this);
    }
}