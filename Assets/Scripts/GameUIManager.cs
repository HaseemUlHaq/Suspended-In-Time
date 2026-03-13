using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.XR;
using System.Collections.Generic;

public class GameUIManager : MonoBehaviour
{
    public GameObject instructionPanel;
    public GameObject startButton;
    public GameObject pauseMenu;
    public Transform playerHead;

    private InputDevice rightController;
    private bool isPaused = false;
    private bool buttonPressedLastFrame = false;

    void Start()
    {
        //Time.timeScale = 0f;

        instructionPanel.SetActive(true);
        startButton.SetActive(true);
        pauseMenu.SetActive(false);

        GetRightController();
    }

    void Update()
    {
        if (!rightController.isValid)
            GetRightController();

        bool primaryButtonPressed;

        if (rightController.TryGetFeatureValue(CommonUsages.primaryButton, out primaryButtonPressed))
        {
            if (primaryButtonPressed && !buttonPressedLastFrame)
            {
                TogglePause();
            }

            buttonPressedLastFrame = primaryButtonPressed;
        }
    }

    void GetRightController()
    {
        List<InputDevice> devices = new List<InputDevice>();
        InputDevices.GetDevicesAtXRNode(XRNode.RightHand, devices);

        if (devices.Count > 0)
            rightController = devices[0];
    }

    public void StartGame()
    {
        Time.timeScale = 1f;

        instructionPanel.SetActive(false);
        startButton.SetActive(false);
    }

    void TogglePause()
    {
        if (Time.timeScale == 1f)
            PauseGame();
        else
            ResumeGame();
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