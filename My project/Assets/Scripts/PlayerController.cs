using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    // character controller component initialize
    private CharacterController controller;
    
    //movement variables
    private float moveSpeed = 5.5f;
    private Vector3 moveDirection;
    private float horizontalInput;
    private float verticalInput;

    // Start is called before the first frame update
    void Start()
    {
        GameObject playerCharacter = GameObject.FindGameObjectWithTag("Player");
        controller = playerCharacter.GetComponent<CharacterController>();

    }

    // Update is called once per frame
    void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        verticalInput = Input.GetAxis("Vertical");

        moveDirection = new Vector3(horizontalInput * moveSpeed, 0, verticalInput * moveSpeed);
        controller.Move(moveDirection * Time.deltaTime);

        /*
        if (controller.isGrounded && Input.GetButtonDown("Jump")) { 
            isJumping = true;
        }
        
        

        if(isJumping == false) {


            if (isJumping == true)
            {
                moveDirection.y = jumpForce;
            }
            else {
                moveDirection.y = gravity * Time.deltaTime;

            }
        
        }
        */
    }
}
