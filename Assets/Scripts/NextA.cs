using UnityEngine;

public class NextA : State
{
    public NextA(GameManager gameManager) : base(gameManager){}
    
    public override void PressedA() => ChangeState(new Distributor(_gameManager));
    public override void PressedB() => ChangeState(new NextAStun(_gameManager));
    public override void PressedC() => ChangeState(new NextAStun(_gameManager));
}
