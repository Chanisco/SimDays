using UnityEngine;
using System.Collections;

public class LoadCarClr : MonoBehaviour {

	void Awake(){
		GameObject.Find ("Car").renderer.material.color 			= CarInfo.carClr;
		GameObject.Find ("LightLeft").renderer.material.color		= CarInfo.lightLeftClr;
		GameObject.Find ("LightRight").renderer.material.color		= CarInfo.lightRightClr;
		GameObject.Find ("SpecialLeft").renderer.material.color		= CarInfo.SpecialLeftClr;
		GameObject.Find ("SpecialRight").renderer.material.color	= CarInfo.SpecialRightClr;
	}
}
