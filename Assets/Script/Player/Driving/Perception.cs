using UnityEngine;
using System.Collections;

public class Perception : MonoBehaviour {
	private bool Haven = false;
	void OnTriggerEnter(Collider other){
		if(other.tag == "Ground"){
			transform.Translate(0,1,0);
		}
	}
	void OnTriggerStay(Collider other){
		if(other.tag == "Haven"){
			Haven = true;
		}
	}
	void OnTriggerExit(Collider other){
		if(other.tag == "Haven"){
			Haven = false;
		}
	}

	void OnGUI(){
		if(Haven){
			GUI.Label(new Rect(Screen.width - 300,0,300,100),"Haven");
		}
	}
}
