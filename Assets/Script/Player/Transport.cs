using UnityEngine;
using System.Collections;

public class Transport : MonoBehaviour {
	public float vehilceSpeed;
	public float walkSpeed;
	private bool vehilceBool = true;


	void Update () {
		int transport = Global.transportSpeed;
		int walk = Global.walkSpeed;
		vehilceSpeed = VehilceCheck(transport);
		walkSpeed = VehilceCheck(walk);

		if(Global.driving){
			if(Input.GetKey(KeyCode.A)){
				transform.Rotate(new Vector3(0,-5,0));

			}
			if(Input.GetKey(KeyCode.D)){
				transform.Rotate(new Vector3(0,5,0));

			}

			if(Input.GetKey(KeyCode.W)){
				transform.Translate(new Vector3(0,0,walkSpeed));
			}
		}

		if(!Global.driving){
			if(Input.GetKey(KeyCode.A)){
				transform.eulerAngles = new Vector3(0,270,0);
				transform.Translate(new Vector3(0,0,vehilceSpeed));
				
			}
			if(Input.GetKey(KeyCode.D)){
				transform.eulerAngles = new Vector3(0,90,0);
				transform.Translate(new Vector3(0,0,vehilceSpeed));
				
			}
			
			if(Input.GetKey(KeyCode.W)){
				transform.eulerAngles = new Vector3(0,0,0);
				transform.Translate(new Vector3(0,0,vehilceSpeed));
			}

			if(Input.GetKey(KeyCode.S)){
				transform.eulerAngles = new Vector3(0,180,0);
				transform.Translate(new Vector3(0,0,vehilceSpeed));
			}
		}

	}
	float VehilceCheck(float Number){
		if(Number > 10){
			Number = Number - 10;
			Number = Number / 10;
		}else if (Number < 10){
			Number = Number / 50;
		}
		return Number;
	}
}
