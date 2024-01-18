using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class Manager : MonoBehaviour
{

    public GameObject[] Levels;
    public GameObject ResetScreen, End;
    public GameObject Panel;
    int wrongAnswerCount;
    public AudioSource wrongAnswerSound;
    public AudioSource correctAnswerSound;
    int currentLevel;

    public void wrongAnswer()
    {
        wrongAnswerCount++;
        ResetScreen.SetActive(true);
        Debug.Log("Wrong Answer Count: " + wrongAnswerCount);
        Levels[currentLevel].SetActive(false);
        wrongAnswerSound.Play();
    }



    public void ResetGame()
    {
        Application.LoadLevel(Application.loadedLevel);
    }

    public void OnBackButtonClicked()
    {
        SceneManager.LoadScene("Menu");
    }


    public void Openpanel()
    {
        if (Panel != null)
        {
            bool isActive = Panel.activeSelf;
            Panel.SetActive(true);
            Time.timeScale = 0f;

        }
    }

    public void ResumeGame()
    {
        if (Panel != null)
        {
            bool isActive = Panel.activeSelf;
            Panel.SetActive(false);
        }

       
        Time.timeScale = 1f;

    }

    public void menu()
    {
        SceneManager.LoadScene("Menu");
    }

    public void levels()
    {
        SceneManager.LoadScene("catogory");
    }

    public void correctAnswer()
    {
        if(currentLevel + 1 != Levels.Length)
        {
            Levels[currentLevel].SetActive(false);

            currentLevel++;
            Levels[currentLevel].SetActive(true); 
            correctAnswerSound.Play();


        }
        else
        {
            End.SetActive(true);
            Levels[currentLevel].SetActive(false);
        }
    }
}
