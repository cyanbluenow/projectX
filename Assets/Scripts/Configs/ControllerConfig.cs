using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControllerConfig : MonoBehaviour
{
    private static ControllerConfig _instance;
    public static KeyCode jump = KeyCode.Space;
    public static KeyCode run = KeyCode.RightShift;
    public static KeyCode openPlayerMenu = KeyCode.Escape;

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

    public static ControllerConfig Instance
    {
        get { return _instance; }
    }
}
