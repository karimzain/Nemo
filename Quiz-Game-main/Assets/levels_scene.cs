using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class levels_scene : MonoBehaviour
{
    public void test()
    {
        SceneManager.LoadScene("choose test level"); // Replace "Game" with the name of your game scene
    }

    public void learn()
    {
        SceneManager.LoadScene("choose learn level"); // Replace "Game" with the name of your game scene
    }

    public void dyslexia()
    {
        SceneManager.LoadScene("dylexia level1"); // Replace "Game" with the name of your game scene
    }

    public void additional()
    {
        SceneManager.LoadScene("choose additional level"); // Replace "Game" with the name of your game scene
    }

    public void back()
    {
        SceneManager.LoadScene("Menu");
    }
}
