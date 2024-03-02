using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FPSCamera : MonoBehaviour
{
    // Start is called before the first frame update
    public Transform player;
    public float mouseSensi = 2f;
    float cameraVertRoat = 0f;
    bool lockedCursor = true;


    void Start()
    {
        Cursor.visible = false;
        Cursor.lockState = CursorLockMode.Locked;
        
    }

    // Update is called once per frame
    void Update()
    {
        float inputX = Input.GetAxis("Mouse X") * mouseSensi;
        float inputY = Input.GetAxis("Mouse Y") * mouseSensi;

        cameraVertRoat -= inputY;
        cameraVertRoat = Mathf.Clamp(cameraVertRoat, -90f, 90f);
        transform.localEulerAngles = Vector3.right * cameraVertRoat;

        player.Rotate(Vector3.up * inputX);
    }
}
