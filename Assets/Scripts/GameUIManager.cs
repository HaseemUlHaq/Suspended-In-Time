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
        if (context.performed && !isPaused)
        {
            PauseGame();
        }
    }

    public void StartGame()
    {
        Time.timeScale = 1f;

        instructionPanel.SetActive(false);
        startButton.SetActive(false);
    }

    public void PauseGame()
    {
        if (isPaused) return; // prevents repeated triggering

        Time.timeScale = 0f;
        isPaused = true;

        Vector3 menuPosition = playerHead.position
                             + playerHead.forward * 2.0f;

        pauseMenu.transform.position = menuPosition;

        pauseMenu.transform.LookAt(playerHead);
        pauseMenu.transform.Rotate(0, 180, 0);

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