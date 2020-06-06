using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UIElements : MonoBehaviour
{

    public void play()
    {
        SceneManager.LoadScene("Game Scene");
    }

    public void rules()
    {
        SceneManager.LoadScene("Rules");
    }

    /*void leaderboard()
    {
        SceneManager.LoadScene("Leaderboard");

    }*/

    public void mainMenu()
    {
        SceneManager.LoadScene("Main Menu");
    }

    /*public void GameEnd()
    {
        SceneManager.LoadScene("GameEnd");

    }*/
    /* Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }*/
}
