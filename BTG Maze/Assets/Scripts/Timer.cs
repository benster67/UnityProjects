using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Timer : MonoBehaviour {

	float timer;
	int min;
	int sec;
	public Text output;


	void Start () {
		timer = Time.deltaTime + 300;
		setTime ();
	}

	void Update () {
		timer -= Time.deltaTime;
		setTime ();
		if (timer < 0) {
			LifeHandler.livesLost++;
			timer = Time.deltaTime + 300;
		}
	}

	void setTime() {
			min = (int)timer / 60;
			sec = (int)timer % 60;
			if (sec < 10)
				output.text = "" + min + ":0" + sec;
			else
				output.text = "" + min + ":" + sec;

	}
}
