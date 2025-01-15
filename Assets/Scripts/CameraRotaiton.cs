using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class CameraRotaiton : MonoBehaviour
{
    [Range(1,10)]
    [SerializeField] private float sensivity = 2f;
    private float maxAngale = 80f;

    private float rotationX = 0f;

    private float mouseX;
    private float mouseY;

    
    void Update()
    {
        mouseX = Input.GetAxis("Mouse X");
        mouseY = Input.GetAxis("Mouse Y");

        transform.parent.Rotate(Vector3.up * mouseX * sensivity);

        rotationX -= mouseY * sensivity;

        rotationX = Mathf.Clamp(rotationX, -maxAngale, maxAngale);
        transform.localRotation = Quaternion.Euler(rotationX, 0f, 0f);
    }
}
