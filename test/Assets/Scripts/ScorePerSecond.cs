using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class ScorePerSecond : MonoBehaviour
{
    //public bool startGame = false;
    public Text scoreText;
    public float scoreAmount;
    public float pointIncreasedPerSecond;

    public Text HighScore;
    public int HighScoreCount;


    // Start is called before the first frame update
    void Start()
    {
        //if (startGame == true)
        //{
            scoreAmount = 0f;
            pointIncreasedPerSecond = 1f;
        //}

        //PlayerPrefs.SetInt("Highscore", HighScoreCount);
        HighScore.text = "High Score: " + PlayerPrefs.GetInt("Highscore", 0).ToString();


    }

 

    // Update is called once per frame
    void Update()
    {
        scoreText.text = "Score: " + (int)scoreAmount;
        scoreAmount += pointIncreasedPerSecond * Time.deltaTime;

        if ((int)scoreAmount > PlayerPrefs.GetInt("Highscore", 0))
        {
            PlayerPrefs.SetInt("Highscore", (int)scoreAmount);
            HighScoreCount = (int)scoreAmount;
        }
        HighScore.text = "High Score: " + PlayerPrefs.GetInt("Highscore").ToString();

    }

    /*public void gameStart()
    {
        startGame = true;
        Start();
    }*/
}
