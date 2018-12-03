using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreBoard : MonoBehaviour {

    public static ScoreBoard scoreBoard;
    public Text time, scoreText, difLevel;
    public int t, timeLeft;

  //  public GameObject[] digits;
    public int score, multiplier;
	// Use this for initialization
	void Start () {
        t = 0; 
        scoreBoard = this;
        score = 0;
        difLevel.text = GameObject.Find("DDOL").GetComponent<Persistror>().difLevel;
	}
	
	// Update is called once per frame
	void Update () {
        t = (int)Time.timeSinceLevelLoad;
        if(!Movement.movement.dead && !Movement.movement.won)
            timeLeft = 65 - t;
        time.text = timeLeft.ToString();
        if (timeLeft <= 0) {
            Movement.movement.dead = true;
        }
	}



    public void IncreaseScore(int incremental) {
        if (timeLeft > 50)
        {
            multiplier = 100;
        }
        else if (timeLeft <= 50 && timeLeft > 35)
        {
            multiplier = 75;
        }
        else if (timeLeft <= 35 && timeLeft > 20)
        {
            multiplier = 50;
        }
        else if (timeLeft <= 20 && timeLeft > 0) {
            multiplier = 25;
        }

        score = score + (incremental * multiplier);
        scoreText.text = score.ToString();
    }
}
