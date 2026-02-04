using Unity.VisualScripting;
using UnityEngine;

public class PauseMenu : MonoBehaviour
{
    [SerializeField] GameObject  pauseMenu;
    private bool isPaused = false;
    
    public void Pause() // when pause pressed, stop time and activate the menu.
    {
        pauseMenu.SetActive(true);
        Time.timeScale = 0f;
    }
    
    public void Resume() // when resume pressed, restart time and disable the menu.
    {
        pauseMenu.SetActive(false);
        Time.timeScale = 1f;
    }
    
}
