using UnityEngine;

public class NextB : State
{
    public NextB(GameManager gameManager) : base(gameManager){}

    public override void PressedA() => ChangeState(new NextBStun(_gameManager));
    public override void PressedB() => ChangeState(new Distributor(_gameManager));
    public override void PressedC() => ChangeState(new NextBStun(_gameManager));
}
