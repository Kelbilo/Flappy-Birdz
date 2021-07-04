using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public GameObject gameOverCanvas;
    public GameObject startCanvas;
    public GameObject scoreCanvas;
    public GameObject bird;
    public GameObject spawner;

    public static int score = 0;
    public static int highscore;

    public Text scoreTxt;
    public Text startHscore;
    public Text gOhScore;

    private void Start()
    {
        startHscore.text = "Highscore: " + score;
        scoreCanvas.SetActive(false);
        startCanvas.SetActive(true);
        Time.timeScale = 1;
        bird.SetActive(false);
        spawner.SetActive(false);
        score = 0;
        highscore = PlayerPrefs.GetInt("highscore", highscore);
        
        startHscore.text = "Highscore: " + highscore;
    }

    private void Update()
    {
        scoreTxt.text = score.ToString();
        CheckScore();
    }

    public void GameStart()
    {
        scoreCanvas.SetActive(true);
        startCanvas.SetActive(false);
        bird.SetActive(true);
        spawner.SetActive(true);
        
    }

    public void GameOver()
    {
        gameOverCanvas.SetActive(true);
        scoreCanvas.SetActive(false);
        Time.timeScale = 0;
        gOhScore.text = "Score: " + score;
    }

    public void Replay()
    {
        SceneManager.LoadScene(0);
        scoreCanvas.SetActive(true);
        spawner.SetActive(true);
    }
    
    void CheckScore()
    {
        if (score > highscore)
        {
            highscore = score;
            
            PlayerPrefs.SetInt("highscore", highscore);
        }
    }
}
