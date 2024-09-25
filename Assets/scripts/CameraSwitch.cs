using UnityEngine;
using UnityEngine.InputSystem;
using Cinemachine;

public class CameraSwitch : MonoBehaviour
{
    public InputAction cameraSwitch;
    private bool Switch;
    public CinemachineVirtualCamera Cam2;

    void Start()
    {
        Switch = true;
    }

    void Update()
    {
        if (Switch)
        {
            Debug.Log("Switch is on");
            if (cameraSwitch.triggered)
                Debug.Log("The switch got triggered");
            {
                Cam2.Priority = Cam2.Priority * -1;
                Debug.Log("Camera priority switched");
                Switch = false;
            }
        }
    }
}