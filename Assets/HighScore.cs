using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class HighScore : MonoBehaviour {

	static public int score = 1000;
	void Start() {
	// Assign the high score to ApplePickerHighScore
	PlayerPrefs.SetInt("ApplePickerHighScore", score); // 3
	}

	void Awake() {
		// If the ApplePickerHighScore already exists, read it
		if (PlayerPrefs.HasKey ("ApplePickerHighScore"))
			score = PlayerPrefs.GetInt ("ApplePickerHighScore");
	}
		
	void Update () {
		Text gt = this.GetComponent<Text>();
		gt.text = "High Score: "+score;
		// Update ApplePickerHighScore in PlayerPrefs if necessary
		if (score > PlayerPrefs.GetInt("ApplePickerHighScore"))
			PlayerPrefs.SetInt("ApplePickerHighScore", score);
		
	}

}
