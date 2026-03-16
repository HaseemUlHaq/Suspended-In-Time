using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.InputSystem;

public class GameUIManager : MonoBehaviour
{
    public GameObject instructionPanel;
    public GameObject startButton;
    public GameObject pauseMenu;
    public Transform playerHead;

    public InputActionReference pauseAction;

    private bool isPaused = false;

    void Start()
    {
        //Time.timeScale = 0f;

        pauseAction.action.actionMap.Enable();
        instructionPanel.SetActive(true);
        pauseMenu.SetActive(true);
        startButton.SetActive(true);
        pauseMenu.SetActive(false);
    }

    void OnEnable()
    {
        pauseAction.action.performed += OnPausePressed;
        pauseAction.action.Enable();
    }

    void OnDisable()
    {
        pauseAction.action.performed -= OnPausePressed;
        pauseAction.action.Disable();
    }

    //void PausePressed(InputAction.CallbackContext context)
    //{
    //    OnPausePressed();
    //}

    void OnPausePressed(InputAction.CallbackContext context)
    {
        Debug.Log("Pause button pressed");
        if (!isPaused)
            PauseGame();
        else
            ResumeGame();
    }

    public void StartGame()
    {
        Time.timeScale = 1f;

        instructionPanel.SetActive(false);
        startButton.SetActive(false);
    }

    public void PauseGame()
    {
        Time.timeScale = 0f;
        isPaused = true;

        pauseMenu.transform.position = playerHead.position + playerHead.forward * 1.5f;
        pauseMenu.transform.LookAt(playerHead);

        pauseMenu.SetActive(true);
    }

    public void ResumeGame()
    {
        Time.timeScale = 1f;
        isPaused = false;

        pauseMenu.SetActive(false);
    }

    public void RestartGame()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}