using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Code designed to make a cube move with the Character Controller component. It moves but I can't get gravity to work on it.  Still troubleshooting it
/// The gravity solves and at the beginning of the game it works, but then it doesn't update almost as if it was in the Start() but it's not
/// Any suggestions to fix this would be appreciated!
/// </summary>

public class PlayerController : MonoBehaviour
{

    // character controller component initialize
    private CharacterController controller;
    
    //movement variables
    private float moveSpeed = 5.5f;
    private Vector3 moveDirection;
    private float horizontalInput;
    private float verticalInput;


    //jumping variables
    private float gravity = 9.81f;
    private bool isGrounded = true;
    private bool isJumping = true;
    private float jumpForce = 5f;
 

    // Start is called before the first frame update
    void Start()
    {
        GameObject playerCharacter = GameObject.FindGameObjectWithTag("Player");
        controller = playerCharacter.GetComponent<CharacterController>();

    }

    // Update is called once per frame
    void Update()
    {
        
        //Basic movement and Inputs
        horizontalInput = Input.GetAxis("Horizontal");
        verticalInput = Input.GetAxis("Vertical");
        
        moveDirection = new Vector3(horizontalInput * moveSpeed, 0, verticalInput * moveSpeed);
 
        controller.Move(moveDirection * Time.deltaTime);

        //Gravity but it doesn't work???
        moveDirection.y = gravity * Time.deltaTime;





    }
}
