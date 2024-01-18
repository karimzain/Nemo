using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Windows.Speech;
using System.Collections.Generic;

public class VoiceRecognition : MonoBehaviour
{
    public Button button;
    public GameObject correctPanel;
    public GameObject incorrectPanel;
    public ParticleSystem correctVFX;
    public ParticleSystem incorrectVFX;
    public List<string> validAnswers = new List<string>(); // Replace with your valid answers for this question

    private KeywordRecognizer keywordRecognizer;

    void Start()
    {
        button.onClick.AddListener(StartSpeechRecognition);
    }

    private void StartSpeechRecognition()
    {
        keywordRecognizer = new KeywordRecognizer(validAnswers.ToArray());
        keywordRecognizer.OnPhraseRecognized += OnPhraseRecognized;
        keywordRecognizer.Start();
    }

    private void OnPhraseRecognized(PhraseRecognizedEventArgs args)
    {
        string spokenPhrase = args.text;

        bool isCorrectAnswer = false;
        foreach (string validAnswer in validAnswers)
        {
            if (spokenPhrase.ToLower() == validAnswer.ToLower())
            {
                isCorrectAnswer = true;
                break;
            }
        }

        if (isCorrectAnswer)
        {
            Debug.Log("Correct answer: " + spokenPhrase);
            // Activate the correct panel
            correctPanel.SetActive(true);
            incorrectPanel.SetActive(false);
            // Trigger correct VFX
            correctVFX.Play();
        }
        else
        {
            Debug.Log("Incorrect answer: " + spokenPhrase);
            // Activate the incorrect panel
            correctPanel.SetActive(false);
            incorrectPanel.SetActive(true);
            // Trigger incorrect VFX
            incorrectVFX.Play();
        }

        // Stop speech recognition after the answer is processed
        keywordRecognizer.Stop();
        keywordRecognizer.Dispose();
    }
}