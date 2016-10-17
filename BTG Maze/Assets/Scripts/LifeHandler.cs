using UnityEngine;
using UnityEngine.UI;
using System.Collections;


public class LifeHandler : MonoBehaviour {

	public Image playerLife;
	public Canvas canvas;
	public static int livesLost = 0;
	Image[] lives = new Image[5];
	int numOfLives;
	Vector3 pos;
	int currentLives;

	void Start () {
		numOfLives = 5;
		LifeSpawn();
		currentLives = numOfLives - livesLost;
	}

	void Update () {
		if (currentLives != numOfLives - livesLost)
			currentLives = numOfLives - livesLost;

		LifeManagment(livesLost);
	
	}

	void LifeSpawn()
	{
		for(int i = 0; i < lives.Length; i++) {
			pos = new Vector3(225f + 25f * i, 160f, 0f);
			lives[i] = Instantiate(playerLife) as Image;
			lives[i].transform.SetParent(canvas.transform, false);
			lives[i].transform.localPosition = pos;
		}
	}

	void LifeManagment(int livesLost) {

		for (int i = 0; i < lives.Length; i++) {

			if (i < livesLost) {
				lives [i].enabled = false;
			} 
			else {
				lives [i].enabled = true;

			}
		}	
 	}
}
