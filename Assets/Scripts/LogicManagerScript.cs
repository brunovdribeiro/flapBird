using UnityEngine;
using UnityEngine.UI;

public class LogicManagerScript : MonoBehaviour
{
    private int _playerScore = 0;

    public Text placeHolder;

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
}