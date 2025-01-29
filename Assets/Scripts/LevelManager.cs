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

    public void LoadStage(){
        SceneManager.LoadScene("Stage");
    }

    public void LoadGameOver(){
        SceneManager.LoadScene("GameOver");
    }

    public void LoadCurrentScene(){
        SceneManager.LoadScene(currentSceneName);
    }

    public void SetStageNumber(int number){
        Singleton.instance.StageNumber = number;
    }
}
