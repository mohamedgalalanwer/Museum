using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VRLookWalk : MonoBehaviour {
    //VR MainCamera
    public Transform vrCamera;

    public float togglengle = 25.0f;
    public float speed = 3f;
    public  bool movForawerd;
    private CharacterController cc;

	// Use this for initialization
	void Start () {
        cc = GetComponent<CharacterController>();
	
	}
	
	// Update is called once per frame
	void Update () {
        if (vrCamera.eulerAngles.x >= togglengle && vrCamera.eulerAngles.x < 90f&& VR_AutoWalk.moveForward)
        {

            movForawerd = true;


        }
        else
        {
            movForawerd = false;
        }

        if (movForawerd)
        {

            Vector3 f = vrCamera.TransformDirection(Vector3.forward);
            cc.SimpleMove(f * speed);


        }
	}
}
