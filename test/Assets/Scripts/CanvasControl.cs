using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CanvasControl : MonoBehaviour
{
    [SerializeField]
    private CanvasGroup Canvas1;

    void Awake()
    {
        Canvas1.alpha = 0f;
        Canvas1.interactable = false;
        Canvas1.blocksRaycasts = false;


    }

    public void GameOver()
    {
        Canvas1.alpha = 1f;
        Canvas1.interactable = true;
        Canvas1.blocksRaycasts = true;
    }

}