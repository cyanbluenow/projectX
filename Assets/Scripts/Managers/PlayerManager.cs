using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerManager : MonoBehaviour
{
    private static PlayerManager _instance;
    [Header("PLAYER HEALTH")]
    public bool playerIsAlive = true;

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
        //CheckPlayerLife();
    }

    public static PlayerManager Instance
    {
        get { return _instance; }
    }

    /*private void CheckPlayerLife() 
    {
        if (!playerIsAlive)
        {
            playerDead();
        }
    }

    public void playerDead()
    {
        GameManager.endGame();
    }*/
}
