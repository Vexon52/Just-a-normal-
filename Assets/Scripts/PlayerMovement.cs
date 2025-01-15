using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private float playerSpeed = 5f;

    private Vector3 playerMoveDirection;
    private float playerInputX;
    private float playerInputZ;

    private CharacterController characterController;

    void Start()
    {
        characterController = GetComponent<CharacterController>();
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = true;
    }

    void Update()
    {
        playerInputX = Input.GetAxis("Horizontal");
        playerInputZ = Input.GetAxis("Vertical");

        playerMoveDirection = transform.forward * playerInputZ + transform.right * playerInputX;

        characterController.Move(playerMoveDirection * playerSpeed * Time.deltaTime);
    }
}
