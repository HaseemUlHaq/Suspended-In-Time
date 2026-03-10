using UnityEngine;

public class GameStart : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public GameObject instructionPanel;
    public GameObject startButton;

    void Start()
    {
        // Pause the game at the beginning
        Time.timeScale = 0f;
    }

    public void StartGame()
    {
        // Resume the game
        Time.timeScale = 1f;

        // Hide UI
        instructionPanel.SetActive(false);
        startButton.SetActive(false);
    }
}