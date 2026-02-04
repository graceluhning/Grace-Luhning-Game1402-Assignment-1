using UnityEngine;
using UnityEngine.SceneManagement;

public class Lives : MonoBehaviour
{
    [SerializeField] private GameObject gameOverMenu;

    public int livesLeft = 3;

    private bool gameOver = false;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start() // Lives left at the beginning of the game.
    {
        livesLeft = 3;

    }

    public void playerLostLife()
    {
        GameObject life1 = GameObject.FindWithTag("Life1"); // Player loses first heart first
        if (life1 != null)
        {
            Destroy(life1);
            livesLeft--;
        }
        else
        {
            GameObject life2 = GameObject.FindWithTag("Life2"); // Player loses second heart second
            if (life2 != null)
            {
                Destroy(life2);
                livesLeft--;
            }
            else
            {
                // Then Life3
                GameObject life3 = GameObject.FindWithTag("Life3"); // Player loses third heart third
                if (life3 != null)
                {
                    Destroy(life3);
                    livesLeft--;
                }
            }
        }


        if (livesLeft <= 0) // when lives at 0, run Game Over.
        {
            gameOver = true;
            gameOverMenu.SetActive(true);
            Time.timeScale = 0f;
            Debug.Log("Game Over");
        }
    }

    public void PlayAgain() // Play again button pressed
        {
            Time.timeScale = 1f;
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }

    }



