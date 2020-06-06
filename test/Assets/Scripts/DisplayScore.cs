using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class DisplayScore : MonoBehaviour
{
    [SerializeField]
    private CanvasGroup Canvas2;

    [SerializeField]
    private CanvasGroup Canvas1;


    void Awake()
    {
        Canvas2.alpha = 0f;
        Canvas2.interactable = false;
        Canvas2.blocksRaycasts = false;



    }
    
    public void ScoreBoard()
    {
        Canvas1.alpha = 0f;
        Canvas1.interactable = false;
        Canvas1.blocksRaycasts = false;
        Canvas2.alpha = 1f;
        Canvas2.interactable = true;
        Canvas2.blocksRaycasts = true;

    }
}
