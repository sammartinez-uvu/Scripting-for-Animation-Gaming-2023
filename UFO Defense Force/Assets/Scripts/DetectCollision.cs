using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectCollision : MonoBehaviour
{
    //Soud effects
    public AudioClip explosionSound;
    
    private AudioSource enemyAudio;

    //Score Management
    public ScoreManager scoreManager; //Store reference to score manager

    public int scoreToGive;

    void Start() {

        scoreManager = GameObject.Find("ScoreManager").GetComponent<ScoreManager>(); //Find ScoreManager game object and reference ScoreManager script component
        enemyAudio = GetComponent<AudioSource>(); //Get audio comp of sound
    }
    
    void OnTriggerEnter(Collider other) { // Once the Trigger has been entered record collision in argument variable "other"

        enemyAudio.PlayOneShot(explosionSound, 1.0f);
        scoreManager.IncreaseScore(scoreToGive); //Increase the Score
        Destroy(gameObject); //destroys object
        Destroy(other.gameObject); //destroys the other collided object

    }

}