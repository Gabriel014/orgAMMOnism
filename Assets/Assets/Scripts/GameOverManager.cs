using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class GameOverManager : MonoBehaviour {

	// Use this for initialization
	public void GameOver()
    {
        PlayerPrefs.SetInt("Score", 0);
        SceneManager.LoadScene(0);
    }
}
