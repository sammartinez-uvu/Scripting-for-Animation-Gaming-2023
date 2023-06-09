using System.Collections;
using System.Collections.Generic;
using UnityEngine;


/// <summary>
/// This script is not ready for use, I am still trying to understand the Input.GetAxis Stuff 
/// </summary>
public class Custom_PlayerController : MonoBehaviour
{
    private float moveSpeed = 5f;
    private float jumpForce = 5f;
    private float gravity = 9.81f;
    

    private CharacterController controller;
    private Vector3 moveDirection;
    private bool isJumping;
    
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

        //Moving in x and z directions
        transform.Translate(moveSpeed * horizontallInput * Time.deltaTime, 0f, moveSpeed * verticalInput * Time.deltaTime);

        //Jumping

    }
}
