using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class miniMapCamera : MonoBehaviour {

    [HideInInspector]
    public GameObject followTarget;
    private Vector3 CameraFollowPos;

    private SurvivorController controller;

	// Use this for initialization
	void Awake () {
        controller = GameObject.Find("GameController").GetComponent<SurvivorController>();
        
	}
	
	// Update is called once per frame
	void Update ()
    {


      
        if (followTarget != null)
        {
            CameraFollowPos = new Vector3(followTarget.transform.position.x, gameObject.transform.position.y, followTarget.transform.position.z);
        }

        gameObject.transform.position = CameraFollowPos;
        

	}

    private void FixedUpdate()
    {
        if (followTarget != controller.selectedSurvivor)
        {
            followTarget = controller.selectedSurvivor;
        }
    }
}
