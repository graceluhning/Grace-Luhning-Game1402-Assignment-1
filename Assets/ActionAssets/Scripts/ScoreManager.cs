using UnityEngine;
using TMPro;
/// <summary>
/// Score for the game.
/// </summary>
public class ScoreManager : MonoBehaviour
{
    public static ScoreManager Instance { get; private set; } // Static instance so other scripts can access, but not change it

    public int Score { get; private set; } // Players current score. 
    
    public TextMeshProUGUI scoreText; // TextMeshPro UI

    private void Awake()
    
    {
        if (scoreText != null) // set scoretext format
        {
            scoreText.text = "SCORE: " + Score;
        }
        
        if (Instance != null && Instance != this) // if another scoremanager exists, destroy it.
        {
            Destroy(gameObject);
            return;
        }
        Instance = this; // make this the only instance.
    }

    public void AddPoints(int amount) // when coin collected, get points
    {
        
        Score += amount;
        
       
        if (scoreText != null)
        {
            scoreText.text = "SCORE: " + Score; // Score text format
        }
    }
}