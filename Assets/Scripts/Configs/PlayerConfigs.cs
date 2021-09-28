using UnityEngine;

public class PlayerConfigs:MonoBehaviour
{
    [Header("SINGLETON")]
    private static PlayerConfigs _instance;

    /*[Header("CUSTOMIZATION")]
    public static string playerName = "Motoko";

    [Header("PLAYER")]
    public static GameObject player;

    [Header("PLAYERMOVEVENT")]
    public static float walkSpeed = 6.0f;
    public static float runSpeed = 6.0f;
    public static float jumpSpeed = 8.0f;
    public static float gravity = 20.0f;
    public static bool isWalking;*/
  
   
    public static PlayerConfigs Instance
    {
        get { return _instance; }
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
}
