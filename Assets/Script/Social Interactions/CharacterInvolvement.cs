using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System;

public class CharacterInvolvement : MonoBehaviour {
	
	public static List<WMUH> Characters = new List<WMUH>{
		new WMUH(0,50,50),
		new WMUH(1,50,50),

	};


	//What makes u human
	public class WMUH{
		private int iD;
		private int happy;
		private int care;

		public WMUH(int iD,int happy,int care){
			this.iD 	= iD;
			this.happy 	= happy;
			this.care 	= care;
		}

		public int ID{
			get{
				return iD;
			}
		}
		
		public int Happy{
			get{
				return happy;
			}
			set{
				if(happy < 100){
					happy = value;
				}
			}
		}
		public int Care{
			get{
				return care;
			}
			set{
				if(care < 100){
					care = value;
				}
			}
		}
	}
}
