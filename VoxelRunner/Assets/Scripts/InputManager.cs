using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputManager : MonoBehaviour {

    public static bool jump = false;
    public static float speed = 0f;

	void Update () {
        if (Input.GetButtonUp("Jump"))
        {
            GetComponent<Animator>().SetTrigger("jump");
        }
        speed = Mathf.Abs(Input.GetAxis("Vertical"));
	}
}
