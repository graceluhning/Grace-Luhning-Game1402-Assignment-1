using UnityEngine;
using UnityEngine.SceneManagement;
public class Mainmenu : MonoBehaviour
{
    public void PlayGame() // Play button function
    {
        SceneManager.LoadScene("MainScene");
    }

    public void QuitGame() // Quit game button function
    {
        Application.Quit();
    }
    
    public void PlayAgain() // Play button function
    {
        SceneManager.LoadScene("MainScene");
    }
}
