using System;
using TMPro;
using UnityEngine;

public class Timer : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI timeText;
    [SerializeField] float timelimit = 60;
    private bool inGame = false;
    private float timervalue;

    private void Start() {
        inGame = true;
    }

    void Update()
    {
        UpdateTimer();
    }

    void UpdateTimer(){
        timervalue -= Time.deltaTime;

        if(timervalue > 0){
            timeText.text = Math.Round(timervalue, 2).ToString();
        }else{
            inGame = false;
            timervalue = timelimit;
        }
    }

    void CancelTimer(){
        inGame = false;
    }

}
