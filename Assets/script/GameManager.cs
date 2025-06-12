using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public GameObject target;
    public TextMeshProUGUI scoreText;
    public GameObject gameOverPanel;

    int score = 0;
    float timer = 2f;

    void Start()
    {
        score = 0;
        scoreText.text = "Score: 0";
        SpawnTarget();
        gameOverPanel.SetActive(false);
    }

    public void OnTargetTapped()
    {
        score++;
        scoreText.text = "Score: " + score;
        SpawnTarget();
        timer = Mathf.Max(0.5f, 2f - score * 0.1f); // reduce time as score increases
    }

    void SpawnTarget()
    {
        Vector2 pos = new Vector2(Random.Range(100, Screen.width - 100), Random.Range(200, Screen.height - 200));
        target.GetComponent<RectTransform>().position = pos;
    }

    void Update()
    {
        timer -= Time.deltaTime;
        if (timer <= 0)
        {
            GameOver();
        }
    }

    void GameOver()
    {
        gameOverPanel.SetActive(true);
        target.SetActive(false);
    }

    public void RestartGame()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene(0);
    }
}
    
