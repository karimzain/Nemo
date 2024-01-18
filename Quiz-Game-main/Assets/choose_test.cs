using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class choose_test : MonoBehaviour
{
    public void testlevel1()
    {
        SceneManager.LoadScene("test level1"); // Replace "Game" with the name of your game scene
    }

    public void testlevel2()
    {
        SceneManager.LoadScene("test level2"); // Replace "Game" with the name of your game scene
    }

    public void testlevel3()
    {
        SceneManager.LoadScene("test level3"); // Replace "Game" with the name of your game scene
    }

    public void back()
    {
        SceneManager.LoadScene("catogory");
    }
}
