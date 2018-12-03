using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering.PostProcessing;

public class PostProcess : MonoBehaviour {

    public static PostProcess postProcess;

    public float focDis;

    public GameObject deadText, wonText, retry, ret, exit;

    DepthOfField dof;
	// Use this for initialization
	void Start () {
        postProcess = this;
        focDis = 10f;
        PostProcessVolume ppv = gameObject.GetComponent<PostProcessVolume>();
        ppv.profile.TryGetSettings(out dof);
	}
	
	// Update is called once per frame
	void Update () {
        
	}

    public void Blur() {
        if (focDis > 0)
        {
            InvokeRepeating("ChangeDof", 0f, 0.01f);
        }
        
    }

    void ChangeDof() {
        focDis = focDis - 0.1f;
        dof.focusDistance.value = focDis;
        if (focDis < 0) {
            if (Movement.movement.dead)
            {
                deadText.SetActive(true);
                retry.SetActive(true);
                ret.SetActive(true);
                exit.SetActive(true);
            }

            else if (Movement.movement.won) {
                wonText.SetActive(true);
                retry.SetActive(true);
                ret.SetActive(true);
                exit.SetActive(true);
            }
                
        }
    }
}
