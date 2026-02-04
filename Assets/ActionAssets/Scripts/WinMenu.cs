using UnityEngine;
using UnityEngine.SceneManagement;

public class WinMenu : MonoBehaviour
{
    [SerializeField] GameObject  winMenu;
    private bool isWon = false;
    
    public void Win() // Win Logic
    {
        if (isWon) return; // Win cannot run twice
        
        winMenu.SetActive(true); // set Win menu active and stop time
        Time.timeScale = 0f;
    }
    
    public void PlayAgain() // Play again logic
    {
        winMenu.SetActive(false);
        Time.timeScale = 1f;
        SceneManager.LoadScene("MainScene");
    }
}
