using UnityEngine;
using System.Collections;

public class GuiReaction : MonoBehaviour {

	public Texture ReactBack;
	public Texture2D zKey, xKey, cKey;

	private Rect ReactOneBox 	= new Rect(0					,Screen.height / 2,Screen.width / 3,100);
	private Rect ReactTwoBox 	= new Rect(Screen.width / 3		,Screen.height / 2,Screen.width / 3,100);
	private Rect ReactThreeBox 	= new Rect(Screen.width / 3 * 2	,Screen.height / 2,Screen.width / 3,100);

	private Rect ReactOneTxt 	= new Rect(50						,Screen.height / 2 + 50,Screen.width / 3,100);
	private Rect ReactTwoTxt 	= new Rect(Screen.width / 3	+ 50	,Screen.height / 2 + 50,Screen.width / 3,100);
	private Rect ReactThreeTxt	= new Rect(Screen.width / 3 * 2	+ 50,Screen.height / 2 + 50,Screen.width / 3,100);

	private Rect ReactOneImg 	= new Rect(50						,Screen.height / 2 - 50,Screen.width / 3,100);
	private Rect ReactTwoImg 	= new Rect(Screen.width / 3	+ 50	,Screen.height / 2 - 50,Screen.width / 3,100);
	private Rect ReactThreeImg	= new Rect(Screen.width / 3 * 2	+ 50,Screen.height / 2 - 50,Screen.width / 3,100);

	public Conversations Reaction;

	private bool back;

	private int CanIReact;

	void Start(){
		Reaction 	= GetComponent<Conversations>();

	}
	void OnGUI(){
		CanIReact 	= GetComponent<GuiSocial>().ConvNumber; 
		bool ReactionRequest = Conversations.Conversation[CanIReact].Reaction;
		Debug.Log(ReactionRequest);


		if(ReactionRequest == true){
			if(ReactBack != null){
				GUI.DrawTexture(ReactOneBox		,ReactBack);
				GUI.DrawTexture(ReactTwoBox		,ReactBack);
				GUI.DrawTexture(ReactThreeBox	,ReactBack);
			}else{
				Debug.Log("Je hebt geen background geselecteerd");
			}

			GUI.skin.label.fontSize = 40;
			GUI.Label(ReactOneTxt	,Conversations.Reactions[CanIReact].FirstChoice	);
			GUI.Label(ReactTwoTxt	,Conversations.Reactions[CanIReact].SecChoice	);
			GUI.Label(ReactThreeTxt	,Conversations.Reactions[CanIReact].ThirdChoice	);

			GUI.Label(ReactOneImg	,zKey);
			GUI.Label(ReactTwoImg	,xKey);
			GUI.Label(ReactThreeImg	,cKey);
		}

	}
}
