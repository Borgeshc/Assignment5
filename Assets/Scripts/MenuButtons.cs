using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

//Hector
//Assignment 6
//This script generates windmills
//10/27/16

public class MenuButtons : MonoBehaviour
{
    public void Play()
    {
        SceneManager.LoadScene("Game");
    }
    public void Quit()
    {
        Application.Quit();
    }
    public void MainMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }
}
