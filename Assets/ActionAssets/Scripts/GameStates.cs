using UnityEngine;

public class GameManager : MonoBehaviour
{
    public enum GameState
    {
        Start,
        Playing,
        Paused,
        GameOver
    }

    private GameState _currentGameState = GameState.Start;

    private void Start() // start the game
    {
        StartGame();
    }

    private void Update()
    {
        // Automatically move from Start to Playing
        if (_currentGameState == GameState.Start)
        {
            BeginPlaying();
        }

        // Pause / Resume
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (_currentGameState == GameState.Playing)
                PauseGame();
            else if (_currentGameState == GameState.Paused)
                ResumeGame();
        }
    }

    private void StartGame()
    {
        _currentGameState = GameState.Start;
        Debug.Log("=== Starting Game ===");
    }

    private void BeginPlaying()
    {
        _currentGameState = GameState.Playing;
        Time.timeScale = 1f;
        Debug.Log("=== Game Playing ===");
    }

    private void PauseGame()
    {
        _currentGameState = GameState.Paused;
        Time.timeScale = 0f;
        Debug.Log("=== Game Paused ===");
    }

    private void ResumeGame()
    {
        _currentGameState = GameState.Playing;
        Time.timeScale = 1f;
        Debug.Log("=== Game Resumed ===");
    }

    public void EndGame()
    {
        _currentGameState = GameState.GameOver;
        Time.timeScale = 0f;
        Debug.Log("=== Game Over ===");
        

    }
}