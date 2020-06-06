using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sword : MonoBehaviour
{
    public deploySword deployS;
    



    private void OnTriggerEnter2D(Collider2D other)
    {
       
        Debug.Log("hit detected");
        deployS.enabled = false;
        Destroy(other.gameObject);
        this.gameObject.SetActive(false);

        FindObjectOfType<CanvasControl>().GameOver();


        //FindObjectOfType<UIElements>().GameEnd();


        //FindObjectOfType<GameManager>().EndGame();

    }


}
