using TMPro;
using UnityEngine;

public class PlayerCanvas : MonoBehaviour
{
    [SerializeField] private TMP_Text _loginText;
    [SerializeField] private TMP_Text _scoreText;

    public void SetLoginText(string login)
    {
        _loginText.text = login;
    }

    public void SetScore(int score)
    {
        _scoreText.text = $"Your score: {score.ToString()}";
    }
}
