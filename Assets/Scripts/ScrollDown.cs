using UnityEngine;
using System.Collections;

public class ScrollDown : MonoBehaviour {
	public float speed = 1f;
	void Update () {
		this.transform.Translate (this.transform.up * speed * Time.deltaTime * -1);
	}
}
