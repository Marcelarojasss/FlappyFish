using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LogicScript : MonoBehaviour
{
    public int playerScore; // Tracks the player's score
    public Text scoreText; 
    
    public GameObject gameOverScreen; // UI Text element to display the score

    // Adds a specific score to the player's total and updates the UI
    [ContextMenu("Increase Score")] // Allows this method to be called manually in the Unity Editor for testing
    public void addScore(int scoreToAdd)
    {
        playerScore += scoreToAdd; // Add the specified score to the player's total
        if (scoreText != null)
        {
            scoreText.text = playerScore.ToString(); // Update the score text in the UI
        }
        else
        {
            Debug.LogError("ScoreText is not assigned in the Inspector!");
        }
    }

    // Restarts the current game by reloading the active scene
    public void restartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name); // Reload the active scene
    }
    public void gameOver()
    {
        gameOverScreen.SetActive(true);
    }
}
