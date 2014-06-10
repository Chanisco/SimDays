using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System;

public class Conversations : MonoBehaviour {
	
	static public List <ConvContent> Conversation = new List <ConvContent>{
		new ConvContent(0,"Me", "Hi",							"Happy", "Jump", 	false),
		new ConvContent(1,"Me", "How are you",					"Happy", "" , 		true),
		new ConvContent(2,"Me", "HA, Now i got you!",			"Happy", "Jump" , 	true),
		new ConvContent(3,"Me", "Thought you could get away?",	"Happy", "Chase", 	false),

	};

	static public List<ConvReact> Reactions = new List<ConvReact>{
		new ConvReact(1,"1", "Man up!" , "Cry"),
		new ConvReact(2,"2", "Man up!" , "Cry"),
		new ConvReact(3,"3", "Man up!" , "Cry"),
		new ConvReact(4,"4", "Man up!" , "Cry"),

	};

	static public List<ConvInfluence> Influence = new List<ConvInfluence>{
		new ConvInfluence(0,0,0,0,0,0,0),
		new ConvInfluence(1,0,0,0,0,0,0),
		new ConvInfluence(2,0,0,0,0,0,0),
	};

	public class ConvInfluence{
		private int iD;
		private int firstInfluence;
		private int secInfluence;
		private int thirdInfluence;
		
		private int firstInfluenceTarget;
		private int secInfluenceTarget;
		private int thirdInfluenceTarget;

		public ConvInfluence(int iD,int firstInfluence,int secInfluence, int thirdInfluence , int firstInfluenceTarget , int secInfluenceTarget ,int thirdInfluenceTarget){
			this.iD = iD;
			this.firstInfluence = firstInfluence;
			this.secInfluence 	= secInfluence;
			this.thirdInfluence = thirdInfluence;

			this.firstInfluenceTarget 	= firstInfluenceTarget;
			this.secInfluenceTarget 	= secInfluenceTarget;
			this.thirdInfluenceTarget 	= thirdInfluenceTarget;
		}
		
		public int ID
		{
			
			get{
				return iD;
				
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

		public int FirstInfluenceTarget
		{

			get{
				return firstInfluenceTarget;
			}
		}
		
		public int SecInfluenceTarget
		{
			
			get{
				return secInfluenceTarget;
			}
		}

		public int ThirdInfluenceTarget
		{
			
			get{
				return thirdInfluenceTarget;
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
