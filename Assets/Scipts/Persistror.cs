using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Persistror : MonoBehaviour {

    public static Persistror persistror;

    public int degree;
    public string difLevel;

    void Awake()
    {
        DontDestroyOnLoad(gameObject);     
    }
    // Use this for initialization
    void Start () {
        degree = 0;
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void Easy() {
        degree = 15;
        difLevel = "Easy";
        SceneManager.LoadScene("Main");
    }

    public void Moderate()
    {
        degree = 30;
        difLevel = "Moderate";
        SceneManager.LoadScene("Main");
    }

    public void Hard()
    {
        degree = 45;
        difLevel = "Hard";
        SceneManager.LoadScene("Main");
    }

    public void Exit() {
        Application.Quit();
    }
}
