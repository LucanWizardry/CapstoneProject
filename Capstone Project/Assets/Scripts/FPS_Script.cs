using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(CharacterController))]
public class FPS_Script : MonoBehaviour
{
    public float movement_speed = 7.5f;
    public float mouseSensitivity = 5.0f;
    float rotateUpDown = 0;
    public float upDownRange = 60.0f;
    public float jumpSpeed = 27.0f;

    float verticalVelocity = 0;
    CharacterController characterController;
    // Start is called before the first frame update
    void Start()
    {
        Screen.lockCursor = true;
        characterController = GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {
        float rotateSide = Input.GetAxis("Mouse X") * mouseSensitivity;
        transform.Rotate(0, rotateSide, 0);

        rotateUpDown-= Input.GetAxis("Mouse Y") * mouseSensitivity;
        rotateUpDown = Mathf.Clamp(rotateUpDown, -upDownRange, upDownRange);
        Camera.main.transform.localRotation = Quaternion.Euler(rotateUpDown, 0, 0);

        float forwardSpeed = Input.GetAxis("Vertical") * movement_speed;
        float sideSpeed = Input.GetAxis("Horizontal") * movement_speed;

        verticalVelocity+= Physics.gravity.y *Time.deltaTime;
        if (characterController.isGrounded && Input.GetButtonDown("Jump")){
            verticalVelocity = jumpSpeed;
        }

        Vector3 speed = new Vector3(sideSpeed, verticalVelocity, forwardSpeed);
        speed = transform.rotation * speed;

        characterController.Move(speed * Time.deltaTime);
    }
}
