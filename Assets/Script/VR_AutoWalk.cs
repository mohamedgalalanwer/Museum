using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[RequireComponent(typeof(CharacterController))]
public class VR_AutoWalk : MonoBehaviour {
    //how to fast move
    public float speed = 3f;
    //should i move or no
    public static bool moveForward;
    //Character
    private CharacterController controll;
    //GVR
    private GvrViewer gvrViewer;
    //vrHead
    private Transform vrHead;




	// Use this for initialization
	void Start () {

        controll = GetComponent<CharacterController>();
        gvrViewer = transform.GetChild(0).GetComponent<GvrViewer>();
        vrHead = Camera.main.transform;
		
	}
	
	// Update is called once per frame
	void Update () {

        if (Input.GetButtonDown("Fire1"))
        {
            moveForward = !moveForward;



        }
        if(moveForward)
        {


            Vector3 forward = vrHead.TransformDirection(Vector3.forward);
            controll.SimpleMove(forward * speed);

        }

		
	}
}
