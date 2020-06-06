using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class BackgroundControl : MonoBehaviour
{
	[SerializeField]
	private CanvasGroup Canvas1;
	[SerializeField]
	private CanvasGroup Canvas2;
	[SerializeField]
	private CanvasGroup Canvas3;
	[SerializeField]
	private CanvasGroup Canvas4;
	[SerializeField]
	private CanvasGroup Canvas5;
	[SerializeField]
	private CanvasGroup Canvas;



	void Awake()
	{
		Canvas.alpha = 0f;
		Canvas.interactable = false;
		Canvas.blocksRaycasts = false;
		Canvas1.alpha = 0f;
		Canvas1.interactable = false;
		Canvas1.blocksRaycasts = false;
		Canvas2.alpha = 0f;
		Canvas2.interactable = false;
		Canvas2.blocksRaycasts = false;
		Canvas3.alpha = 0f;
		Canvas3.interactable = false;
		Canvas3.blocksRaycasts = false;
		Canvas4.alpha = 0f;
		Canvas4.interactable = false;
		Canvas4.blocksRaycasts = false;
		Canvas5.alpha = 0f;
		Canvas5.interactable = false;
		Canvas5.blocksRaycasts = false;
		chooseBack();
	}


	public void chooseBack()
	{

		System.Random rnd = new System.Random();
		int num = rnd.Next(6);
		switch (num)
		{
			case 0:
				Canvas.alpha = 1f;
				break;

			case 1:
				Canvas1.alpha = 1f;
				break;

			case 2:
				Canvas2.alpha = 1f;
				break;

			case 3:
				Canvas3.alpha = 1f;
				break;

			case 4:
				Canvas4.alpha = 1f;
				break;

			case 5:
				Canvas5.alpha = 1f;
				break;

		}
	}
}


	/*switch (num)
	{
		case 0:
			Canvas.alpha = 1f;
			break;

		case 1:
			Canvas1.alpha = 1f;
			break;

		case 2:
			Canvas2.alpha = 1f;
			break;

		case 3:
			Canvas3.alpha = 1f;
			break;

		case 4:
			Canvas4.alpha = 1f;
			break;

		case 5:
			Canvas5.alpha = 1f;
			break;

	}*/

