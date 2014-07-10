using UnityEngine;
using System.Collections;

public class ColorGui : MonoBehaviour {
	public Texture background , blueButton, greenButton , redButton, blackButton, endButton;
	private Rect backgroundRect = new Rect(500,0,Screen.width - 200, Screen.height);

	public Texture secondBackground,yesButton,noButton;
	private Rect secondBackgroundRect = new Rect(0,0,Screen.width, Screen.height / 4);
	public static Color ChosenColor;


	void OnGUI(){
		if(CarCostumisation.Finish == false){
			if (background != null){
				GUI.DrawTexture(backgroundRect,background);
			}
			if(GUI.Button(new Rect(500,0,100, 100),blueButton,GUIStyle.none)){
				ChosenColor = new Color(0,0,10);
			}
			if(GUI.Button(new Rect(600,100,100, 100),greenButton,GUIStyle.none)){
				ChosenColor = new Color(0,10,0);
			}
			if(GUI.Button(new Rect(700,0,100, 100),redButton,GUIStyle.none)){
				ChosenColor = new Color(10,0,0);
			}
			if(GUI.Button(new Rect(800,100,100, 100),blackButton,GUIStyle.none)){
				ChosenColor = new Color(0,0,0);
			}
			if(GUI.Button(new Rect(Screen.width - 100,Screen.height - 100,100, 100),endButton,GUIStyle.none)){
				CarCostumisation.Finish = true;
			}
		}else{
			if (secondBackground != null){
				GUI.DrawTexture(secondBackgroundRect,secondBackground);
				GUI.skin.label.fontSize = 50;
				GUI.Label(secondBackgroundRect,"Are you sure you're Done?");
			}
			if(GUI.Button(new Rect(500,100,100, 100),yesButton,GUIStyle.none)){
				Application.LoadLevel("World");
			}
			if(GUI.Button(new Rect(650,100,100, 100),noButton,GUIStyle.none)){
				CarCostumisation.Finish = false;
			}

		}
	}
}
