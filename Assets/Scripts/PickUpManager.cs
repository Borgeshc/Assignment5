using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

//Hector
//Assignment 6
//This script generates windmills
//10/27/16

public class PickUpManager : MonoBehaviour
{
    GenerateWindmill genWindmill;
    public Text scoreText;
    int score;

    void Start()
    {
        genWindmill = GameObject.Find("GameManager").GetComponent<GenerateWindmill>();
    }
    public void Collected()
    {
        score++;
        scoreText.text = "Score: " + score;
        if (score >= genWindmill.pickUps.Count)
        {
            SceneManager.LoadScene("WinScreen");
        }
    }
}
