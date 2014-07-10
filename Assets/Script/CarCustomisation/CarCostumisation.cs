using UnityEngine;
using System.Collections;

public class CarCostumisation : MonoBehaviour {
	public float halfScreen = Screen.width / 2;
	public static bool Finish = false;
	private bool startSave = false;
	void Update(){
		Rotate();
		if(Finish == false){
			ToStart();
			if(Input.GetMouseButtonUp(0)){
				if(Input.mousePosition.x < halfScreen){
				GameObject.Find (ChooseObject.Chosen).renderer.material.color = ColorGui.ChosenColor;
				}
			}
		}else{
			startSave = true;
			SavingCar();
			ToMiddle();

		}


	}
	void Rotate(){
		if(Input.GetKey(KeyCode.A)){
			transform.Rotate(0,0.5F,0);
		}
		if(Input.GetKey(KeyCode.D)){
			transform.Rotate(0,-0.5F,0);
		}
	}
	void ToMiddle(){
		if(transform.position.x < 0){
			transform.Translate(2 * Time.deltaTime,0,0);
		}
	}
	void ToStart(){
		if(transform.position.x > -3){
			transform.Translate(-1f * Time.deltaTime,0,0);
		}
	}

	void SavingCar(){
		if(startSave == true){
			CarInfo.carClr 			= GameObject.Find ("Car").renderer.material.color;
			CarInfo.lightLeftClr 	= GameObject.Find ("LightLeft").renderer.material.color;
			CarInfo.lightRightClr 	= GameObject.Find ("LightRight").renderer.material.color;
			CarInfo.SpecialLeftClr 	= GameObject.Find ("SpecialLeft").renderer.material.color;
			CarInfo.SpecialRightClr = GameObject.Find ("SpecialRight").renderer.material.color;

			startSave = false;
		}
	}

}
