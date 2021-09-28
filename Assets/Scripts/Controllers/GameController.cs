using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    void Start() { }

    void Update(){}

    public static void lockCursor()
    {
        Cursor.lockState = CursorLockMode.Locked;
    }

    public static void unlockCursor()
    {
        Cursor.lockState = CursorLockMode.None;
    }

    public void saveGame(){ }

    public void loadGame(){ }
}
