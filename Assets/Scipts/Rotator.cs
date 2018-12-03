using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotator : MonoBehaviour {

    int rotDegree;

	// Use this for initialization
	void Start () {
        rotDegree = GameObject.Find("DDOL").GetComponent<Persistror>().degree;

    }
	
	// Update is called once per frame
	void Update () {
        if (!Movement.movement.dead && !Movement.movement.won) {
            if ((gameObject.transform.parent.name.Split('_')[1]).Equals("1") || (gameObject.transform.parent.name.Split('_')[1]).Equals("3") || (gameObject.transform.parent.name.Split('_')[1]).Equals("5"))
                transform.Rotate(new Vector3(0, rotDegree, 0) * Time.deltaTime * 1.05f);
            else
                transform.Rotate(new Vector3(0, -rotDegree, 0) * Time.deltaTime * 1.05f);
        }
        

    }
}
