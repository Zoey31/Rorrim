using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LookingController : MonoBehaviour
{
    public float speed;
    public float mouseSensivity;

    public Transform playerBody;

    float xRotatation = 0f;

    // Start is called before the first frame update
    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
    }

    // Update is called once per frame
    void Update()
    {
        float mouseX = Input.GetAxis("Mouse X") * mouseSensivity * Time.deltaTime;
        float mouseY = Input.GetAxis("Mouse Y") * mouseSensivity * Time.deltaTime;

        xRotatation -= mouseY;
        xRotatation = Mathf.Clamp(xRotatation, -90f, 90f);

        transform.localRotation = Quaternion.Euler(xRotatation, 0f, 0f);
        playerBody.Rotate(Vector3.up * mouseX);
    }
}
