using System;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;
    private int StageNumber;
    public TextMeshProUGUI timerUI;
    public bool isPaused = false;
    private State _currentState;
    private Timer timer = new Timer();
    public Button buttonA, buttonB, buttonC;


    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else if (Instance != this)
        {
            Destroy(gameObject);
        }
    }

    void Start()
    {
        _currentState = new Distributor(this);
        timer.Set(1,0); // 타이머 작동 테스트 용. 추후 삭제
    }

    void Update()
    {   
        if (isPaused != timer.isPaused)
        {
            if (isPaused)
                timer.Pause();
            else
                timer.Resume();
        }
        
        if (!isPaused && !timer.IsFinished())
        {
            timerUI.text = timer.GetTime();
        }
    }

    public void SetStageNumber(int number){
        StageNumber = number;
    }

    public void PauseGame(){
        isPaused = true;
    }

    public void ResumeGame(){
        isPaused = false;
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
