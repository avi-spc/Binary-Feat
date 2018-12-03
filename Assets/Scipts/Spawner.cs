using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour {

    public GameObject[] spawnPoints;

    public GameObject player;

	// Use this for initialization
	void Start () {
        Instantiate(player, spawnPoints[Random.Range(0, 10)].transform.position, Quaternion.identity);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
