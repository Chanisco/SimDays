using UnityEngine;
using System.Collections;

public class Walk : MonoBehaviour {

	void Update () {
		if(Input.GetKey(KeyCode.A)){
			transform.Translate(-0.1f,0,0);
		}
		if(Input.GetKey(KeyCode.D)){
			transform.Translate(0.1f,0,0);
		}
		if(Input.GetKey(KeyCode.W)){
			transform.Translate(0,0,0.1f);
		}
		if(Input.GetKey(KeyCode.S)){
			transform.Translate(0,0,-0.1f);
		}
	}
}
