using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [Header("INSTANCE")]
    private static GameManager _instance;


    private void Awake()
    {
        if (_instance != null && _instance != this)
        {
            Destroy(this.gameObject);
            return;
        }

        _instance = this;
        DontDestroyOnLoad(this.gameObject);
    }

    private void Update()
    {
        endGame();
    }

    public void startGame() 
    {
        PlayerController.changePlayerIsAlive(true);
        SceneController.loadScene(SceneConfig.firstScene);    
    }

    public void endGame() 
    {
        if (!PlayerController.playerIsAlive)
        {
            SceneController.loadScene(SceneConfig.endScene);
        }
    }

    public void quitGame()
    {
        Application.Quit();
    }

}
