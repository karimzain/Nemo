using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class choose_learn : MonoBehaviour
{
    public void learnlevel1()
    {
        SceneManager.LoadScene("learn level1"); // Replace "Game" with the name of your game scene
    }

    public void learnlevel2()
    {
        SceneManager.LoadScene("learn level2"); // Replace "Game" with the name of your game scene
    }

    public void learnlevel3()
    {
        SceneManager.LoadScene("learn level3"); // Replace "Game" with the name of your game scene
    }

    public void back()
    {
        SceneManager.LoadScene("catogory");
    }
}

