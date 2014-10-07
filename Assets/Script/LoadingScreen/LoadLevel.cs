using UnityEngine;
using System.Collections;

public class LoadLevel : MonoBehaviour {
	private Rect fullScreen = new Rect(0,0,Screen.width,Screen.height);
	private Rect loadBar 	= new Rect(0,0,Screen.width,10);
	private float screenHeight = Screen.height;
	private float screenWidth = Screen.width;
	public Texture2D image;


	void OnGUI(){
		if(GlobalSaveScreen.Save == true){
			float loadProcent = screenWidth / 100;
			Rect loadBar 	= new Rect(loadProcent * GlobalSaveScreen.SaveBar ,screenHeight - 10,screenWidth,10);
			GUI.Label(fullScreen,image);
			GUI.Label(loadBar,image);
	
		}

	}
}
