using System;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    private State _currentState;
    public Button buttonA, buttonB, buttonC;

    void Start()
    {
        _currentState = new Distributor(this);
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
