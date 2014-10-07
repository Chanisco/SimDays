using UnityEngine;
using System.Collections;

public class CarCostumisation : MonoBehaviour {
	public float halfScreen = Screen.width / 2;
	public static bool Finish = false;
	public float yielder = 2;
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
		if(transform.parent.position.x < 0){
			transform.parent.Translate(2 * Time.deltaTime,0,0);
		}
	}
	void ToStart(){
		if(transform.parent.position.x > -3){
			transform.parent.Translate(-1f * Time.deltaTime,0,0);
		}
	}

	void SavingCar(){
		Debug.Log(GlobalSaveScreen.Save);
		yielder = 2;
		if(GlobalSaveScreen.Save == true){
			CarInfo.carClr 			= GameObject.Find ("Car").renderer.material.color;
			GlobalSaveScreen.SaveBar += 1;
			CarInfo.lightLeftClr 	= GameObject.Find ("LightLeft").renderer.material.color;
			GlobalSaveScreen.SaveBar += 1;
			CarInfo.lightRightClr 	= GameObject.Find ("LightRight").renderer.material.color;
			GlobalSaveScreen.SaveBar += 1;
			CarInfo.SpecialLeftClr 	= GameObject.Find ("SpecialLeft").renderer.material.color;
			GlobalSaveScreen.SaveBar += 1;
			CarInfo.SpecialRightClr = GameObject.Find ("SpecialRight").renderer.material.color;
			GlobalSaveScreen.SaveBar += 1;

			yielder -= Time.deltaTime;
			if(yielder < 0){
				Application.LoadLevel("World");
				GlobalSaveScreen.Save = false;
			}
		}
	}

}
