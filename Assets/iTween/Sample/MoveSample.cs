using UnityEngine;
using System.Collections;

public class MoveSample : MonoBehaviour
{	
	void Update(){
		if(Global.Emotion == "Jump"){
			JumpIn();
		}if(Global.Emotion == "Chase"){
			Chase ();
		}
	}
	void JumpIn(){
		iTween.MoveBy(gameObject, iTween.Hash("x", 5, "easeType", "easeInOutExpo", "loopType","none", "delay", .1));
		Global.Emotion = "";
	}

	void Chase(){
		iTween.MoveBy(gameObject, iTween.Hash("x", 16, "easeType", "easeInOutExpo", "loopType","none", "delay", .1));
		Global.Emotion = "";
	}


}

