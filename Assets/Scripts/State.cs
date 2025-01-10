using UnityEngine;

public abstract class State
{
    protected GameManager _gameManager;

    protected State(GameManager gameManager){
        _gameManager = gameManager;
    }

    protected void ChangeState(State newState){
        _gameManager.SetState(newState);
    }

    public virtual void PressedA() {}
    public virtual void PressedB() {}
    public virtual void PressedC() {}
    public virtual void TimeSpent() {}

}
