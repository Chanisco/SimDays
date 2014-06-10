using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System;

public class GuiSocial : MonoBehaviour {
	public bool Resume;

	public Texture SpeechBack ;

	public GUISkin Guiskin;

	private Rect Chatbox = new Rect(0,Screen.height / 1.5f,Screen.width , Screen.height);

	private string str;

	public float TextSpeed;
	public int ConvNumber;

	public Conversations ConvComponent;

	void Awake(){
		ConvComponent = GetComponent<Conversations>();
		ConvNumber = 2;
		TextSpeed = 0.15f;
		ConversationWatch();
		Resume = false;
	
	}
	void OnGUI(){
		if (SpeechBack != null){
			GUI.DrawTexture(Chatbox,SpeechBack);
		}
		GUI.skin.label.fontSize = 75;
		GUI.Label(Chatbox,str);
	}

	void Update(){
		bool ReactionRequest = Conversations.Conversation[ConvNumber].Reaction;

		if(Resume && Input.GetKey("space") && TextSpeed != 0.001f && !ReactionRequest){
			Resume = false;
			str = "";
			ConvNumber += 1;
			ConversationWatch();
		}
		if(!Resume && Input.GetKeyDown("space")){
			TextSpeed = 0.001f;
		}else if(Input.GetKeyUp("space")){
			TextSpeed = 0.15f;
		}
		if(ReactionRequest){
			int firstInflu 	= Conversations.Influence[ConvNumber].FirstInfluence;
			int secInflu 	= Conversations.Influence[ConvNumber].SecInfluence;
			int thirdInflu 	= Conversations.Influence[ConvNumber].ThirdInfluence;
			if(Input.GetKey("Z")){
				
				
			}if(Input.GetKey("X")){
				
				
			}if(Input.GetKey("C")){
				
				
			}
		}
	}
	void ConversationWatch(){
		Global.Emotion = Conversations.Conversation[ConvNumber].Action;
		StartCoroutine( AnimateText(Conversations.Conversation[ConvNumber].Speech) );
	}

	
	IEnumerator AnimateText(string strComplete){
//		Debug.Log(strComplete);
		int i = 0;
		str = "";
		while( i < strComplete.Length ){
			str += strComplete[i++];
			if(i != strComplete.Length){
				yield return new WaitForSeconds(TextSpeed);
			}else{
				Resume = true;
			}
		}
	}
}
