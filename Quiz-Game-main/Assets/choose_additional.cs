using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class choose_additional : MonoBehaviour
{
    public void Conversation()
    {
        SceneManager.LoadScene("ConversationExample"); // Replace "Game" with the name of your game scene
    }

    public void SpeechRecognition()
    {
        SceneManager.LoadScene("SpeechRecognitionExample"); // Replace "Game" with the name of your game scene
    }

    public void TextToImage()
    {
        SceneManager.LoadScene("TextToImageExample"); // Replace "Game" with the name of your game scene
    }

    public void back()
    {
        SceneManager.LoadScene("catogory"); // Replace "Game" with the name of your game scene
    }
}
