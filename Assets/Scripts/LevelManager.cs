using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour
{
    public void LoadMainMenu(){
        SceneManager.LoadScene("MainMenu");
    }
    
    public void LoadStageSelect(){
        SceneManager.LoadScene("StageSelect");
    }

    public void LoadStage1(){
        SceneManager.LoadScene("Stage1");
    }

    public void LoadStage2(){
        SceneManager.LoadScene("Stage2");
    }

    public void LoadStage3(){
        SceneManager.LoadScene("Stage3");
    }

    public void LoadGameOver(){
        SceneManager.LoadScene("GameOver");
    }
}
