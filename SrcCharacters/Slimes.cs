namespace Escapade.SrcCharacters;

public class Slimes : Characters
{
    public Slimes(short startX, short startY) 
        : base(1, startX, startY, "slime") {}

    public void Bounce()
    {
        // slimes bounce to walk; add that effect
    }
    
    public override void Death()
    {
        // poof the slime
    }
}