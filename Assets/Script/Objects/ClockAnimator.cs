using UnityEngine;
using System;

public class ClockAnimator : MonoBehaviour {

	public Transform hours,minutes,seconds;
	private const float 
		hoursToDegrees 		= 	360/12,
		minutesToDegrees 	= 	360/60,
		secondsToDegrees 	= 	360/60;

	void Update(){
		DateTime time = DateTime.Now;
		hours.localRotation 	= Quaternion.Euler(0,0,time.Hour * -hoursToDegrees);
		minutes.localRotation 	= Quaternion.Euler(0,0,time.Minute * -minutesToDegrees);
		seconds.localRotation 	= Quaternion.Euler(0,0,time.Second * -secondsToDegrees);
	}
}
