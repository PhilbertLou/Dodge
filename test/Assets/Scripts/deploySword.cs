using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class deploySword : MonoBehaviour
{
    //public bool startGame = false;
    public GameObject swordPrefab;
    public float respawnTime = 1.0f;
    private Vector2 screenBounds;
    //public GameManager gameManager;

    // Start is called before the first frame update
    void Start()
    {
        //if (startGame == true)
        //{
        
        screenBounds = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width, Screen.height, Camera.main.transform.position.z));
            StartCoroutine(swordWave());
        //}
    }


    private void spawnEnemy()
    {
        GameObject a = Instantiate(swordPrefab) as GameObject;
        a.transform.position = new Vector2(screenBounds.x * 2, Random.Range(-screenBounds.y, screenBounds.y));

 
    }

    
   IEnumerator swordWave()
    {
        while (true) // can make a bool to replace true, make the game start with it as false and when it starts you make it true
        {
            yield return new WaitForSeconds(respawnTime); 
            spawnEnemy();
           

        }
    }

    private void Update()
    {
        if (respawnTime > 0.1)
        {
            respawnTime = (float)(respawnTime - (Time.deltaTime * 0.01));
        }


    }

    /*public void gameStart()
    {
        startGame = true;
        Start();
    }*/
}
