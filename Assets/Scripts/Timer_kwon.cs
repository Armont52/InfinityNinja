using System;
using TMPro;
using UnityEngine;

public class Timer_kwon : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI timeText; //unity에서 text 지정
    [SerializeField] float timeLimit = 60; //스테이지 제한시간
    private bool isGameStopped = false; // 게임 정지 여부
    private float timervalue; // 남은 시간
    LevelManager levelManager; //scene 넘기기용

    private void Start() {
        levelManager = FindFirstObjectByType<LevelManager>();
        isGameStopped = false; //게임 시작시 게임 진행 상태로 확실하게 변경
        timervalue = timeLimit; //시간 초기화 작업
    }

    void Update()
    {
        UpdateTimer(); // 계속 시간 업데이트
    }

    void UpdateTimer(){
        if(timervalue > 0 && !isGameStopped){ //시간이 남아 있고 게임 진행 중이라면
            timervalue -= Time.deltaTime; //기기별 차이 보정
            timeText.text = Math.Round(timervalue, 2).ToString(); //소숫점 2자리까지 시간을 text로 표시
        }else{ //시간이 초과 되었거나 게임이 정지되면
            FailGame(); //시간 초과시 실패코드 실행
            timervalue = timeLimit; //시간 초기화 작업
        }
    }

    public void ClearGame(){ //시간을 남기고 클리어시(적이 없을 시) 외부 호출용
        isGameStopped = true; //게임 정지
        //점수저장 = timervalue //추후 점수 저장 추가 예정
        //성공scene으로 전환 추가 예정
    }

    private void FailGame(){
        isGameStopped = true; //실패시(시간이 다 지나면) 정지 상태 부여
        //아직 결정하지 않았지만 실패scene 또는 실패panel을 가져오는 코드 작성 예정
    }

    public void setTimelimit(float time){ //외부에서 제한시간 지정시 사용
        timeLimit = time;
    }

}
