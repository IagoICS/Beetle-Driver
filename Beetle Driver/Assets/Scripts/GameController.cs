using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour
{
     public float score;
    public GameObject gameOver;
    public AudioSource audioSource;
    public TextMeshProUGUI scoreText;
    public Color targetColor; 

    public int scoreCoin;
    public TextMeshProUGUI scoreCoinText;
    private Color originalTextColor;
    private float colorTransitionSpeed = 2f;
    private bool isGameOver = false; 

    void Start()
    { if (SceneManager.GetActiveScene().name == "MainMenu")
        {
            
            PlayerPrefs.SetInt("ScoreCoin", 0);
        }
        scoreCoin = PlayerPrefs.GetInt("ScoreCoin", 0);
        scoreCoinText.text = scoreCoin.ToString();

        originalTextColor = scoreText.color;
        audioSource = GetComponent<AudioSource>();
        audioSource.Play(); 
    }

    void Update()
    {
        if (!isGameOver)
        {
        score += Time.deltaTime * 10f;
        
        }
        scoreText.text = "Pontuação:" +Mathf.Round(score).ToString();

        if (Mathf.Round(score) % 100 == 0)
        {
           
            scoreText.color = Color.Lerp(scoreText.color, targetColor, Time.deltaTime * colorTransitionSpeed);
        }
        else
        {
            
            scoreText.color = Color.Lerp(scoreText.color, originalTextColor, Time.deltaTime * colorTransitionSpeed);
        }
          if (isGameOver && audioSource.isPlaying)
        {
        audioSource.Pause(); 
        }
    }
    
    public void ShowGameOver()
    {
        gameOver.SetActive(true);
        
        isGameOver = true;
      
    }

    public void AddCoin()
    {
        scoreCoin++;
        scoreCoinText.text = scoreCoin.ToString();

        if (scoreCoin >= 5)
        {
             PlayerPrefs.SetInt("ScoreCoin", scoreCoin);
          
            if (SceneManager.GetActiveScene().name != "SampleScene 1")
            {
                SceneManager.LoadScene("SampleScene 1");
            }
        }
    }
}