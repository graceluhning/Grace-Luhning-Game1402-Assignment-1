using UnityEngine;
using UnityEngine.SceneManagement;

public class Lives : MonoBehaviour
{
    [SerializeField] private GameObject gameOverMenu;

    public int livesLeft = 3;
    
    private bool gameOver = false;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        livesLeft = 3;
        
    }

    public void playerLostLife()
    {
        if (!gameOver)
        {
            livesLeft--;
        }

        if (livesLeft <= 0)
        {
            gameOver = true;
            gameOverMenu.SetActive(true);
            Time.timeScale = 0f;
            Debug.Log ("Game Over");
        }
    }

    public void PlayAgain()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
