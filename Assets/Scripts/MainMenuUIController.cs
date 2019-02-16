using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MainMenuUIController : MonoBehaviour
{
    [SerializeField] private GameObject _mainMenu;
    [SerializeField] private GameObject _optionsMenu;
    [SerializeField] private AudioController _audioController;
    
    public void LogACall()
    {
        Debug.Log("Something called me!");
    }

    public void ShowOptions()
    {
        _mainMenu.SetActive(false);
        _optionsMenu.SetActive(true);
    }

    public void ShowMainMenu()
    {
        _mainMenu.SetActive(true);
        _optionsMenu.SetActive(false);
    }

    public void SetAudioState(Toggle state)
    {
        _audioController.ToggleMute(state.isOn);
    }

    public void StartGame()
    {
        SceneManager.LoadScene(1);
    }
}