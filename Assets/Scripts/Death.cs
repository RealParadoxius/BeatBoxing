using UnityEngine;
using System.Collections;

// Deletes the object it is attached to on a timer
public class Death : MonoBehaviour {
	public float deathTime;
	public bool initialized = false; // Must set to true to delete object


	void Update () {
		deathTime -= 1;
		if (deathTime < 0 && initialized) {
			Destroy(this.gameObject);
			Destroy(this);
		}
	}
}
