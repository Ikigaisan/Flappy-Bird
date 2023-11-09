using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using Unity.VisualScripting;
public class LogicScript : MonoBehaviour
{
    public int playerScore;
    public Text scoreText;
    public GameObject gameOverScreen;

    public GameObject startScreen;
    static bool isFirstTimeLoaded = true;

    public void Start()
    {
        if (isFirstTimeLoaded)
        {
            isFirstTimeLoaded = false;
            Time.timeScale = 0.0f;
            startScreen.SetActive(true);
            
        }
        
    }
    public void Update()
    {
        if(Input.GetKeyDown("escape"))	 
	    {        
		    if (Time.timeScale == 1.0)
            {         
		        Time.timeScale = 0.0f;
            }        
		    else
            {
		        Time.timeScale = 1.0f;
            }	            
	    }
    }


    [ContextMenu("Increase Score")]
    public void addScore(int scoreToAdd)
    {
        playerScore += scoreToAdd;
        scoreText.text = playerScore.ToString();
    }
    public void restartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
    
    public void gameOver()
    {
        gameOverScreen.SetActive(true);
    }

    public void startGame()
    {
        startScreen.SetActive(false);
        Time.timeScale = 1.0f;
    }
}
