using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System;

public class Conversations : MonoBehaviour {
	
	static public List <ConvContent> Conversation = new List <ConvContent>{
		new ConvContent(0,"???", "HA, Now i got you!",				"Happy", 		"Jump", 	false),
		new ConvContent(1,"???", "Thinking you could outrun me!?",		"Happy", 		"" , 	false),
		new ConvContent(2,"???", "Not today!",					"Happy", 		"" , 	true),
		new ConvContent(3,"???", "Thought you could get away?",			"Happy", 		"" , 	true),
		new ConvContent(4,"???", "Can't believe you went without me",		"Happy", 		"" , 	false),
		new ConvContent(5,"???", "Is something wrong?",				"Questioned", 		"" , 	true),
		new ConvContent(6,"???", "Well fuck...",				"Shocked", 		"" , 	true),
		new ConvContent(7,"???", "",						"Shocked", 		"" , 	true),
		new ConvContent(8,"???", "",						"Shocked", 		"" , 	true),

	};

	static public List<ConvReact> Reactions = new List<ConvReact>{
		new ConvReact(0,"", "" , ""),
		new ConvReact(1,"", "" , ""),
		new ConvReact(2,"RUN", "Man Up" , "CRY"),
		new ConvReact(3,"RUN FASTER", "Run back" , "Stop"),
		new ConvReact(4,"", "" , ""),
		new ConvReact(5,"Duck!", "Uhm no" , "...."),
		new ConvReact(6,"", "" , ""),
	};

	static public List<ConvInfluence> Influence = new List<ConvInfluence>{
		new ConvInfluence(0,0,0,0, 0,0,0, 0),
		new ConvInfluence(1,0,0,0, 0,0,0, 0),
		new ConvInfluence(2,1,2,0, 3,4,6, 1),
		new ConvInfluence(3,0,1,0, 0,0,0, 0),
		new ConvInfluence(4,0,0,0, 0,0,0, 0),
		new ConvInfluence(5,1,1,0, 0,0,0, 0),
	};

	public class ConvInfluence{
		private int iD;

		private int firstInfluence;
		private int secInfluence;
		private int thirdInfluence;
		
		private int firstListTarget;
		private int secListTarget;
		private int thirdListTarget;

		private int conversationTarget;

		public ConvInfluence(int iD,int firstInfluence,int secInfluence, int thirdInfluence , int firstListTarget , int secListTarget ,int thirdListTarget, int conversationTarget){
			this.iD = iD;
			this.firstInfluence = firstInfluence;
			this.secInfluence 	= secInfluence;
			this.thirdInfluence = thirdInfluence;

			this.firstListTarget 	= firstListTarget;
			this.secListTarget 		= secListTarget;
			this.thirdListTarget 	= thirdListTarget;

			this.conversationTarget = conversationTarget;
		}
		
		public int ID
		{
			
			get{
				return iD;
				
			}
		}

		public int ConversationTarget
		{
			get{
				return conversationTarget;
			}
		}
		public int FirstInfluence
		{
			
			get{
				return firstInfluence;
				
			}
		}

		public int SecInfluence
		{
			get{
				return secInfluence;
			}
		}

		public int ThirdInfluence
		{
			get{
				return thirdInfluence;
			}
		}

		public int FirstListTarget
		{

			get{
				return firstListTarget;
			}
		}
		
		public int SecListTarget
		{
			
			get{
				return secListTarget;
			}
		}

		public int ThirdListTarget
		{
			
			get{
				return thirdListTarget;
			}
		}

	}

	public class ConvReact{
		private int iD;
		private string	firstChoice;
		private string	secChoice;
		private string	thirdChoice;

		public ConvReact(int iD , string firstChoice,string secChoice,string thirdChoice){
			this.iD 			= iD;
			this.firstChoice 	= firstChoice;
			this.secChoice 		= secChoice;
			this.thirdChoice 	= thirdChoice;


		}

		public string FirstChoice
		{
			get
			{
				return firstChoice;
			}
		}
		
		public string SecChoice
		{
			get
			{
				return secChoice;
			}
		}
		public string ThirdChoice
		{
			get
			{
				return thirdChoice;
			}
		}

	}


	public class ConvContent{
		private int iD;
		private string 	charID;
		private string 	speech;
		private string  emotion;
		private string 	action;
		private bool reaction;

		private Conversations ConverComponent;

		public ConvContent(int iD,string charID, string speech,string emotion,string action,bool reaction){
			this.iD 		= iD;
			this.charID 	= charID;
			this.speech 	= speech;
			this.emotion	= emotion;
			this.action 	= action;
			this.reaction 	= reaction;

		}

		public int ID
		{
			get
			{
				return iD;
			}
		}
		public string CharID
		{
			get
			{
				return charID;
			}
		}
		public string Speech
		{
			get
			{
				return speech;
			}
		}
		public string Emotion
		{
			get
			{
				return emotion;
			}
		}

		public string Action
		{
			get
			{
				return action;
			}

		}

		public bool Reaction
		{
			get{
				return reaction;
			}
		}

	}
}
