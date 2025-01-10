using UnityEngine;

public class NextC : State
{
    public NextC(GameManager gameManager) : base(gameManager){}

    public override void PressedA() => ChangeState(new NextCStun(_gameManager));
    public override void PressedB() => ChangeState(new NextCStun(_gameManager));
    public override void PressedC() => ChangeState(new Distributor(_gameManager));    
}
