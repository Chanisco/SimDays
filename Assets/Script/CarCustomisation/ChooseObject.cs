using UnityEngine;
using System.Collections;

public class ChooseObject : MonoBehaviour {
	public static string Chosen;
	void Update () {
		if (Input.GetMouseButtonDown(0)){
			Ray ray = camera.ScreenPointToRay(Input.mousePosition);
			RaycastHit hit;
			if (Physics.Raycast(ray, out hit)){
				Chosen = hit.transform.name;
			}
		}
	}
}
