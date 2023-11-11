using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

//code creds to All Thing Game Dev - dustinmorman
[RequireComponent(typeof(CharacterController))]
public class FPSScript : MonoBehaviour
{
    //public Camera playerCamera;
    public float walkSpeed = 6f;
    //public float runSpeed = 12f;
    public float jumpPower = 7f;
    public float gravity = 10f;

    //public float lookSpeed = 2f;
    //public float lookXLimit = 45f;
    public Rigidbody rb;

    Vector3 forward;
    Vector3 moveDirection = Vector3.zero;
    //float rotationX = 0;

    public bool canMove = true;

    CharacterController characterController;

    void Start()
    {
        characterController = GetComponent<CharacterController>();
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }

    void FixedUpdate()
    {
        forward = transform.forward * walkSpeed * Time.fixedDeltaTime;
        rb.MovePosition(rb.position + forward);
    }

    void Update()
    {

        #region Handles Movement
        forward = transform.TransformDirection(Vector3.forward);
        Vector3 right = transform.TransformDirection(Vector3.right);

        // Press Left Shift to run
        //bool isRunning = Input.GetKey(KeyCode.LeftShift);
        //float curSpeedX = canMove ? (isRunning ? runSpeed : walkSpeed) * Input.GetAxis("Vertical") : 0;
        float curSpeedX = canMove ? (walkSpeed) : 0; //* Input.GetAxis("Vertical") : 0;
        //float curSpeedY = canMove ? (isRunning ? runSpeed : walkSpeed) * Input.GetAxis("Horizontal") : 0;
        float curSpeedY = canMove ? (walkSpeed) * Input.GetAxis("Horizontal") : 0;
        
        float movementDirectionY = moveDirection.y;
        moveDirection = (forward * curSpeedX) + (right * curSpeedY);

        #endregion

        #region Handles Jumping
        if (Input.GetButton("Jump") && canMove && characterController.isGrounded)
        {
            moveDirection.y = jumpPower;
        }
        else
        {
            moveDirection.y = movementDirectionY;
        }

        if (!characterController.isGrounded)
        {
            moveDirection.y -= gravity * Time.deltaTime;
        }

        #endregion

        #region Handles Rotation
        characterController.Move(moveDirection * Time.deltaTime);

        if (canMove)
        {
            //rotationX += -Input.GetAxis("Mouse Y") * lookSpeed;
            //rotationX = Mathf.Clamp(rotationX, -lookXLimit, lookXLimit);
            //playerCamera.transform.localRotation = Quaternion.Euler(rotationX, 0, 0);
            //transform.rotation *= Quaternion.Euler(0, Input.GetAxis("Mouse X") * lookSpeed, 0);
        }

        #endregion
    }
}
