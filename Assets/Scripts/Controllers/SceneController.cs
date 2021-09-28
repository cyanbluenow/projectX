using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneController : MonoBehaviour
{

    void Start(){}

    void Update(){}
    public static void loadScene(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }

    public static void getActualScene()
    {
        GameStatus.playerActualScene = SceneManager.GetActiveScene().name;
        print(GameStatus.playerActualScene);
    }

    public void returnToGame()
    {

        loadScene(GameStatus.playerActualScene);
    }


    
}
