using System;
using UnityEngine;

public class FirstPersonController : MonoBehaviour
{
    [Header("SINGLETON")]
    private static FirstPersonController _instance;
    private static CharacterController characterController;
    [Header("CAMERA OPTIONS")]
    public Camera cam;
    public float mouseHorizontal = 3.0f;
    public float mouseVertical = 2.0f;
    public float minRotation = -65.0f;
    public float maxRotation = 60.0f;
    public float h_mouse, v_mouse;
    [Header("Position")]
    private static Vector3 move = Vector3.zero;


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

    private void Start()
    {
        characterController = GetComponent<CharacterController>();
    }

    void Update()
    {
        pointOfView();
    }

    public static FirstPersonController Instance
    {
        get { return _instance; }
    }

    void pointOfView() 
    {
        h_mouse = mouseHorizontal * Input.GetAxis("Mouse X");
        v_mouse += mouseVertical * Input.GetAxis("Mouse Y");

        v_mouse = Mathf.Clamp(v_mouse, minRotation, maxRotation);

        cam.transform.localEulerAngles = new Vector3(-v_mouse, 0, 0);
        transform.Rotate(0, h_mouse, 0);
    }

    public static void moveControllerCharacter()
    {
        //PlayerConfigs.isWalking = false;
        /*if (characterController.isGrounded)
        {
            move = new Vector3(Input.GetAxis("Horizontal"), 0.0f, Input.GetAxis("Vertical"));

            if (Input.GetKey(ControllerConfig.run))
            {
                runCharacter();
            }
            else
            {
                //walkCharacter();
            }

            if (Input.GetKey(ControllerConfig.jump))
            {
                jumpCharacter();
            }
        }

        //move.y -= PlayerConfigs.gravity * Time.deltaTime;

       characterController.Move(move * Time.deltaTime);*/
    }

    private static void jumpCharacter()
    {
        //move.y = PlayerConfigs.jumpSpeed;
    }

    private static void walkCharacter()
    {
        //PlayerConfigs.isWalking = true;
        //move = PlayerConfigs.player.transform.TransformDirection(move) * PlayerConfigs.walkSpeed;
    }

    private static void runCharacter()
    {
        //move = PlayerConfigs.player.transform.TransformDirection(move) * PlayerConfigs.runSpeed;
    }
}
