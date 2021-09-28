using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonController : MonoBehaviour
{
    private GameManager _gameManager;
    public Button
        btnNewGame,
        btnLoadGame,
        btnOptions,
        btnQuitGame,
        btnGoMenu,
        btnReturnToGame,
        btnSaveGame;

    private void Start()
    {
        _gameManager = FindObjectOfType<GameManager>();

        btnAction(btnNewGame, SceneConfig.firstScene, "scene");
        btnAction(btnOptions, SceneConfig.mainOptions, "scene");
        btnAction(btnGoMenu, SceneConfig.mainTitle, "scene");
        btnAction(btnLoadGame, SceneConfig.loadMenu, "scene");
        btnAction(btnSaveGame, "", "save");
        btnAction(btnQuitGame, "", "quit");
    }



    void btnAction(Button btnName, string url, string type) 
    {
        if (type == "scene")
        {
            if (btnName)
            {
                btnName.GetComponent<Button>().onClick.AddListener(() => _gameManager.loadScene(url));
            }
        }
        else if (type == "quit")
        {
            if (btnName)
            {
                btnName.GetComponent<Button>().onClick.AddListener(() => Application.Quit());
            }
        }
         else if (type == "save")
        {
            if (btnName)
            {
                btnName.GetComponent<Button>().onClick.AddListener(() => _gameManager.saveGame());
            }
        }
    }
}
