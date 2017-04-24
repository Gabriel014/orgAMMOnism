using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour {

    public Text scoreValue, highScoreValue;

	// Use this for initialization
	void Start () {
        highScoreValue = GameObject.Find("High Score Value").GetComponent<Text>();
        scoreValue = GameObject.Find("Score Value").GetComponent<Text>();
        highScoreValue.text = "" + PlayerPrefs.GetInt("HighScore");
	}
	
	// Update is called once per frame
	void Update () {
        scoreValue.text = "" + PlayerPrefs.GetInt("Score");
        highScoreValue.text = "" + PlayerPrefs.GetInt("HighScore");
    }
}
