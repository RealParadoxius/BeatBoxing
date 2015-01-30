using UnityEngine;
using System.Collections;

public class Box : MonoBehaviour {
	public GameObject player;
	public GameObject enemy;

	void OnTriggerStay(Collider target){
		if(target.gameObject.name != "cube"){
			return;
		}
		if (Input.GetKeyDown (KeyCode.Space)) {
			Destroy(target.gameObject);
			print(target.gameObject.name);
			enemy.GetComponent<HealthBar>().TakeDamage(20);
		}
	}
}
