using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    [Header("INSTANCE")]
    private static GameManager _instance;
    private bool gameIsPause = false;

    private void Start()
    {
        loadScene(SceneConfig.mainTitle);
    }

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
        openMenu();
    }

    public static GameManager Instance
    {
        get { return _instance; }
    }

    public void startGame() 
    {
        loadScene(SceneConfig.firstScene);    
    }

    public void endGame() 
    {
        loadScene(SceneConfig.endScene);
    }



    public static void lockCursor()
    {
        Cursor.lockState = CursorLockMode.Locked;
    }

    public static void unlockCursor()
    {
        Cursor.lockState = CursorLockMode.None;
    }

    void openMenu()
    {
        if (Input.GetKeyDown(ControllerConfig.openPlayerMenu) && !gameIsPause)
        {
            unlockCursor();
            loadScene(SceneConfig.gameOptions);
        }
    }

    public void saveGame() { }

    public void loadGame() { }

    public  void loadScene(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }

}
