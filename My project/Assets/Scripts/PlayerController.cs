using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    private float moveSpeed = 5f;
    private float jumpForce = 5f;
    private float gravity = 9.81f;


    private CharacterController controller;
    private Vector3 moveDirection;
    private bool isJumping;
    private bool isGrounded;


    // Start is called before the first frame update
    void Start()
    {
        GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {
        float horizontallInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");

        if (controller.isGrounded && Input.GetButtonDown("Jump")) { 
            isJumping = true;
        }
        
        controller.Move(moveDirection * Time.deltaTime);

        if(isJumping == false) {


            if (isJumping == true)
            {
                moveDirection.y = jumpForce;
            }
            else {
                moveDirection.y = gravity * Time.deltaTime;

            }
        }
    }
}
