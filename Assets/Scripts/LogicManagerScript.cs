using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LogicManagerScript : MonoBehaviour
{
    private int _playerScore;

    public Text placeHolder;

    public GameObject GameOverScreen;

    void Start()
    {
        drawPlayerScore();
    }

    private void drawPlayerScore()
    {
        placeHolder.text = _playerScore.ToString();
    }

    public void AddScore(int pointsToAdd)
    {
        _playerScore += pointsToAdd;
        drawPlayerScore();
    }

    public void RestartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        GameOverScreen.SetActive(false);
    }

    public void GameOver()
    {
        GameOverScreen.SetActive(true);
    }

}