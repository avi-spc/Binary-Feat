using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameO : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void Retry() {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    public void RTM() {
        SceneManager.LoadScene("Start");
        Destroy(GameObject.Find("DDOL"));
    }

    public void Exit() {
        Application.Quit();
    }
}
