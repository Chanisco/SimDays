using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Inventory : MonoBehaviour {
//	private AllItems itemComponent;
/*

	private Rect invertoryRectWindow 	= new Rect(0,0,Screen.width,Screen.height);
	private Rect equipmentRect 			= new Rect(0,0,Screen.width,Screen.height);
	private Rect equipmentRectWindow 	= new Rect(0,0,Screen.width,Screen.height);

	private bool inventoryWindowShow = false;
	private bool clickable = true;

	public Texture2D background, backgroundSec;

	private Animator animator;

	/*public static Dictionary<int,AllItems.ItemCreate> inventoryNameDictionary = new Dictionary<int, AllItems.ItemCreate>(){
		{0,AllItems.Item[0]},
		{1,AllItems.Item[0]},
		{2,AllItems.Item[0]},
		{3,AllItems.Item[0]},
		{4,AllItems.Item[0]},
		{5,AllItems.Item[0]},
		{6,AllItems.Item[0]},
		{7,AllItems.Item[0]},
		{8,AllItems.Item[0]},
	};
	public static Dictionary<int,AllItems.ItemCreate> usingNameDictionary = new Dictionary<int,AllItems.ItemCreate>(){
		{0,AllItems.Item[0]},
		{1,AllItems.Item[0]},
		{2,AllItems.Item[0]},
	};*/
	
	/*void Start(){
		//itemComponent = GetComponent<AllItems>();
		animator = GetComponent<Animator>();
		animator.GetBool("Open");
		radius = transform.localScale.x;
	
	}
	void Update () {
		//transform.position = new Vector2(SwPos * 8, ShPos * 8);
		if(clickable){
		//if(Input.touchCount == 1){
			if(Input.GetMouseButton(0)){
				Vector3 MousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
				float dist = Mathf.Pow(MousePos.x - transform.position.x,2) + Mathf.Pow(MousePos.y - transform.position.y,2);
				dist = Mathf.Sqrt(dist);
				
				if(dist < radius){
					if(!inventoryWindowShow){
						GlobalValues.invOpen = true;
						inventoryWindowShow = true;
						clickable = false;

					}else{
						GlobalValues.invOpen = false;
						inventoryWindowShow = false;
						clickable = false;

					}
				}
			}

		}
		if(Input.GetMouseButtonUp(0)){
			clickable = true;
		}
		if(usingNameDictionary[0] != null){
			GlobalValues.Power = 2;
		}
		
	}
	
	void OnGUI(){
		if(inventoryWindowShow){
			animator.SetBool("Open" , true);
			invertoryRect = GUI.Window(0,invertoryRect,InventoryWindowFunc,"", GUIStyle.none);
			if (background != null){
				GUI.DrawTexture(invertoryRectWindow,background);
			}
			
		}else{
			animator.SetBool("Open" , false);
		}

	}


	void InventoryWindowFunc(int id){
		GUI.skin.label.fontSize = 20;
		GUILayout.BeginArea(new Rect(SwPos,ShPos,SwPos * 6,ShPos * 5));
			GUILayout.BeginHorizontal();
				
				if(GUILayout.Button(inventoryNameDictionary[0].icon,GUIStyle.none, GUILayout.Width(SwPos * 2))){

				}

			GUILayout.EndHorizontal();	
		GUILayout.EndArea();

	}*/
	private float radius;
	public Texture2D background;
	private bool inventoryWindowShow = false;
	
	
	private Rect fullScreen 			= new Rect(0,0,Screen.width,Screen.height);
	void Update(){
		if(Global.inventoryOn){
			fullScreen = GUI.Window(0,fullScreen,InventoryFunc,"", GUIStyle.none);
		}

	}

	void InventoryFunc(int id){
		GUI.skin.label.fontSize = 20;
	}
	
}
