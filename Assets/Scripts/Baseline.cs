using UnityEngine;
using System.Collections;

// Creates the beat that the game is based on
public class Baseline : MonoBehaviour {
	int counter;

	public float beats_per_minute;
	private int frames_per_second = 50;
	// Use this for initialization
	void Start () {
		counter = 0;
	}
	
	// Update is called once per frame
	void Update () {
		if (counter % frames_per_second * Time.deltaTime / beats_per_minute == 0) {
			GameObject cube = GameObject.CreatePrimitive(PrimitiveType.Cube);
			cube.AddComponent<Rigidbody>().isKinematic = true;
			cube.renderer.material.color = new Color(Random.value,Random.value,Random.value);
			cube.transform.position = this.transform.position;
			Death die = cube.AddComponent<Death>();
			die.deathTime = 2000;
			die.initialized = true;
			cube.AddComponent<ScrollDown>();
		}
		counter += 1;
	}
}
