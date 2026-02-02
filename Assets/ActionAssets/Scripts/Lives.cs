using UnityEngine;

public class Lives : MonoBehaviour
{

    public int livesLeft = 3;
    private bool gameOver = false;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
      
        
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
            Debug.Log ("Game Over");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
