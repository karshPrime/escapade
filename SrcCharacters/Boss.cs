namespace escapade.SrcCharacters;

public class Boss : Characters
{
    private bool _spawn;

    public Boss()
        : base(250, 0, 0, "boss")
    {
        _spawn = false; // will spawn only when player reaches end of the map
    }

    public void Bounce()
    {
        // boss will bounce on its location; add that effect
    }
    
    public override void Death()
    {
        // player wins; game over.
    }
}