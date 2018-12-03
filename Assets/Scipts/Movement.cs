using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour {

    public static Movement movement;

    public bool won, dead;

    public int incScore;

    public AudioClip yay, sigh;

	// Use this for initialization
	void Start () {
        incScore = 0;
        movement = this;
        won = false;
        dead = false;
	}
	
	// Update is called once per frame
	void Update () {
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");

        if (!dead && !won)
            transform.Translate(new Vector3(horizontal, 0, vertical) * Time.deltaTime * 8);
        
	}

    void OnTriggerEnter(Collider other) {
        if (other.gameObject.name.Equals("target")) {
            won = true;
            gameObject.GetComponent<AudioSource>().PlayOneShot(yay);
            GameOver();
        }

        if (other.gameObject.CompareTag("E")) {
            dead = true;
            gameObject.GetComponent<AudioSource>().PlayOneShot(sigh);
            GameOver();
        }

        if (other.gameObject.CompareTag("A")) {
            if (other.gameObject.name.Equals("ring1")) {
                incScore = 10;
                IncreaseScore(incScore);
            }

            if (other.gameObject.name.Equals("ring2")) {
                incScore = 50;
                IncreaseScore(incScore);
            }

            if (other.gameObject.name.Equals("ring3")) {
                incScore = 100;
                IncreaseScore(incScore);
            }
        }
    }

    void IncreaseScore(int incremental) {
        ScoreBoard.scoreBoard.IncreaseScore(incremental);
    }

    void GameOver() {
        PostProcess.postProcess.Blur();
    }

}
