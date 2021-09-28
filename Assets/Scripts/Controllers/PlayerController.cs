using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [Header("PLAYER INITIAL STATS")]
    public static bool playerIsAlive = false;
    public static Vector3 playerInitialPosition = Vector3.zero;
   
    private void Start()
    {
        //playerController = gameObject.AddComponent<FirstPersonController>();
    }

    void Update()
    {
        openMenu();
        FirstPersonController.moveControllerCharacter();
    }

    public static void changePlayerIsAlive( bool playerNewStatus) 
    {
        playerIsAlive = playerNewStatus;
    }

    public static void initialPositionOfPlayer()
    { 
        
    }

    void openMenu()
    {
        if (Input.GetKeyDown(ControllerConfig.openPlayerMenu))
        {
            //savePosition(position);
            GameController.unlockCursor();
            SceneController.getActualScene();
            SceneController.loadScene("Game_Menu");
        }
    }

    void savePosition(Vector3 position)
    {
        GameStatus.playerPosition = position;
    }
}
