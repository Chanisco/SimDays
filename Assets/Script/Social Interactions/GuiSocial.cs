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

	public CharacterInvolvement CharComponent;

	void Awake(){
		ConvComponent = (Conversations)GetComponent<Conversations>();
		CharComponent = (CharacterInvolvement)GetComponent<CharacterInvolvement>();
		ConvNumber = 0;
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

		if(ReactionRequest && Resume){
			int firstInflu 	= Conversations.Influence[ConvNumber].FirstInfluence;
			int secInflu 	= Conversations.Influence[ConvNumber].SecInfluence;
			int thirdInflu 	= Conversations.Influence[ConvNumber].ThirdInfluence;

			int firstListTarget = Conversations.Influence[ConvNumber].FirstListTarget;
			int secListTarget	= Conversations.Influence[ConvNumber].SecListTarget;
			int thirdListTarget = Conversations.Influence[ConvNumber].ThirdListTarget;

			int CharacterTarget = Conversations.Influence[ConvNumber].ConversationTarget;

			Debug.Log(firstListTarget);
			if(Input.GetKey("z")){
				ConvNumber = firstListTarget;
				Resume = false;
				str = "";
				CharacterInvolvement.Characters[CharacterTarget].Happy += firstInflu;
				ReactionRequest = false;
				ConversationWatch();
				
			}
			if(Input.GetKey("x")){
				ConvNumber = secListTarget;
				Resume = false;
				str = "";
				ConversationWatch();
				CharacterInvolvement.Characters[CharacterTarget].Happy += secInflu;
				ReactionRequest = false;

			}
			if(Input.GetKey("c")){
				ConvNumber = thirdListTarget;
				Resume = false;
				str = "";
				ConversationWatch();
				CharacterInvolvement.Characters[CharacterTarget].Happy += thirdInflu;
				ReactionRequest = false;
				
			}
		}
	}

	void ConversationWatch(){
		GlobalPlayerStat.Emotion = Conversations.Conversation[ConvNumber].Action;
		StartCoroutine( AnimateText(Conversations.Conversation[ConvNumber].Speech) );
	}

	
	IEnumerator AnimateText(string strComplete){
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
