using UnityEngine;
using System.Collections;

public class Box : MonoBehaviour {

	void OnTriggerStay(Collider target){
		if (Input.GetKeyDown (KeyCode.Space)) {
			target.transform.localScale = new Vector3 (.5f,.5f,.5f);
			print(target.gameObject.name);
		}
	}
}
