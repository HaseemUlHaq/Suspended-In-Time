using UnityEngine;
using UnityEngine.SceneManagement;

public class GameUIManager : MonoBehaviour
{
    public GameObject instructionPanel;
    public GameObject startButton;
    public GameObject pauseButton;
    public GameObject pauseMenu;

    void Start()
    {
        //Time.timeScale = 0f;

        instructionPanel.SetActive(true);
        startButton.SetActive(true);

        pauseButton.SetActive(false);
        pauseMenu.SetActive(false);
    }

    public void StartGame()
    {
        Time.timeScale = 1f;

        instructionPanel.SetActive(false);
        startButton.SetActive(false);

        pauseButton.SetActive(true);
    }

    public void PauseGame()
    {
        Time.timeScale = 0f;

        pauseMenu.SetActive(true);
        pauseButton.SetActive(false);
    }

    public void ResumeGame()
    {
        Time.timeScale = 1f;

        pauseMenu.SetActive(false);
        pauseButton.SetActive(true);
    }

    public void RestartGame()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}