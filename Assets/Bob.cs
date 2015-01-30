using UnityEngine;
using System.Collections;

public class Bob : MonoBehaviour {
	public int counter = 0;
	
	void Update () {
		if (counter % Time.deltaTime * 20 == 0) {
			print("ROTATE");
			this.rigidbody.angularVelocity = Random.insideUnitSphere;
		}
		counter += 1;
	}
}
