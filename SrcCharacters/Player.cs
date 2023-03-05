namespace escapade.SrcCharacters;

public class Player : Characters
{
    private byte _kills;
    private bool _isJumping;

    public Player()
        : base(200, 0, 0, "zul")
    {
        _kills = 0;
        _isJumping = false;
    }

    public void Jump()
    {
        // initiate jump if _isJumping = false
    }

    public void Jumping()
    {
        // update character's movement is _isJumping = true
    }

    public override void Death()
    {
        // player loses; game over.
    }
}