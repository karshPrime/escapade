namespace escapade.SrcCharacters;

public class Slimes : Characters
{
    public Slimes(short startX, short startY) 
        : base(1, startX, startY, "slime") {}

    public void Bounce()
    {
        // slimes bounce to walk; add that effect
    }
}