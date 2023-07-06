using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro; //Text Mesh Pro name spaced added to access library for UI

public class ScoreManager : MonoBehaviour
{

    public int score; // Defines Score value

    public TextMeshProUGUI scoreText; // Visual text to be modified

    public void IncreaseScore(int amount) { // Method when called increase score by predetermined amount set in score var
        //score plus the new amount, then update the score text
        score += amount;
        UpdateScoreText();

    }

    public void DecreaseScore(int amount) { // Method when called decreases score by predetermined amount set in score var
        //score minus the new amount, then update the score text
        score -= amount;
        UpdateScoreText();
    }

    public void UpdateScoreText(){ // Method updates score in HUD UI Text

        scoreText.text = "Score: "+ score;
    }
}
