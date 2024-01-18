using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuManager : MonoBehaviour
{
    public GameObject pauseMenu;
    public GameObject settingsMenu;
    public AudioSource audioSource;


    private bool isPaused = false;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (isPaused)
                ResumeGame();
            else
                PauseGame();
        }
    }

    public void PlayGame()
    {
        SceneManager.LoadScene("catogory"); // Replace "Game" with the name of your game scene
    }

    public void QuitGame()
    {
        Application.Quit();
    }

    public void PauseGame()
    {
        isPaused = true;
        Time.timeScale = 0f;
        pauseMenu.SetActive(true);
    }

    public void ResumeGame()
    {
        isPaused = false;
        Time.timeScale = 1f;
        pauseMenu.SetActive(false);
    }

    public void OpenSettings()
    {
        settingsMenu.SetActive(true);
    }

    public void CloseSettings()
    {
        settingsMenu.SetActive(false);
    }

    public void ToggleSound()
    {

    }

    private void Start()
    {
        // Get the Audio Source component attached to this object
        audioSource = GetComponent<AudioSource>();

        // Play the background music
        PlayBackgroundMusic();
    }

    private void PlayBackgroundMusic()
    {
        // Check if the Audio Source and audio clip are assigned
        if (audioSource != null && audioSource.clip != null)
        {
            // Play the background music
            audioSource.loop = false;
            audioSource.Play();

            // Schedule the repeat if the audio clip has finished playing
            Invoke("RepeatBackgroundMusic", audioSource.clip.length);
        }
    }

    private void RepeatBackgroundMusic()
    {
        // Check if the Audio Source is playing
        if (audioSource != null && !audioSource.isPlaying)
        {
            // Set loop to true and play the background music again
            audioSource.loop = true;
            audioSource.Play();
        }
    }
}