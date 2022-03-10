using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    [SerializeField]
    private TextMeshProUGUI _textScore;

    [SerializeField]
    private Button _buttonRestart;

    private int score;

    private void Start()
    {
        score = 0;
        DisplayScore();
    }

    public void RestartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    public void AddScore()
    {
        score += 1;
        DisplayScore();
        CheckScore();
    }

    private void CheckScore()
    {
        if(score==5)
        {
            _buttonRestart.gameObject.SetActive(true);
            _textScore.gameObject.SetActive(false);
        }
    }    

    private void DisplayScore()
    {
        _textScore.text = score.ToString();
    }
}