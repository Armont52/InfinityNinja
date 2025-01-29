using UnityEngine;

public class Singleton : MonoBehaviour
{
    /*
        씬 전환과 관계 없이 유지되어야 하는 데이터를 저장하는 클래스
        Singleton.instance로 접근 가능
        (예: Singleton.instance.StageNumber = 1;)
    */

    public static Singleton instance;
    public int StageNumber;

    void Awake()
    {
        if(instance == null){
            instance = this;
        }
        else if (instance != this){
            Destroy(gameObject);
        }
        DontDestroyOnLoad(gameObject);
    }

    void Start()
    {
        
    }

    void Update()
    {
        
    }
}
