using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour
{
    private string currentSceneName;

    private void Start() {
        currentSceneName = SceneManager.GetActiveScene().name;
    }

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

    public void LoadCurrentScene(){
        SceneManager.LoadScene(currentSceneName);
    }
}
