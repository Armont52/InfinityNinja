using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance { get; private set; }
    public Button buttonA, buttonB, buttonC;
    private State _currentState;

    public GameManager(){
        _currentState = new Distributor(this);
    }

    void Start()
    {
        
    }

    void Update()
    {
        
    }

    public void SetState(State state){
        _currentState = state;
    }

    public void PressA(){
        _currentState.PressedA();
    }

    public void PressB(){
        _currentState.PressedB();
    }

    public void PressC(){
        _currentState.PressedC();
    }

    // public void TimeSpend(){
    //     Invoke(nameof(_currentState.TimeSpent), 0.2f);
    // }
}
