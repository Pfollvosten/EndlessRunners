using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementController : MonoBehaviour {

    private float speed; //range 0;1
    private Animator anim;
    private CharacterController charcon;
    public float speedmul;
	// Use this for initialization
	void Start () {
        anim = GetComponent<Animator>();
        charcon = GetComponent<CharacterController>();
	}
	
	// Update is called once per frame
	void Update () {

        speed = InputManager.speed;
        charcon.Move(new Vector3(0, 0,speed/speedmul));
        anim.SetFloat("speed", speed);

	}
}
