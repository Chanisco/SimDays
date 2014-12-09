using UnityEngine;
using System.Collections;

public class ClrAnimation : MonoBehaviour {

	private Color ObjectClr = Color.white;
	float pause = 0;
	int turns = 1;
	float r,g,b;

	
	// Update is called once per frame
	void Update () {
		ColorChanging(ObjectClr);
		roll (transform);

		foreach (Transform child in transform) {
			child.renderer.material.color = ObjectClr;
		}
	}

	void ColorChanging(Color color){
		r += 20;
		color = new Color(r,g,b);

	}

	void roll(Transform obj){
		if(obj.eulerAngles.y == 0){
			pause += 20 * Time.deltaTime;
			if(pause > 100){
				obj.Rotate(0,1,0);
			}
		}else if(obj.eulerAngles.y > 0){
			obj.Rotate(0,90 * Time.deltaTime,0,0);
			pause = 0;
		}
		if(obj.eulerAngles.y > 120){
			obj.localEulerAngles = new Vector3(0,0,0);
		}
	}
}
