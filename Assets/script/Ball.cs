using UnityEngine;
using System.Collections;

public class Ball : MonoBehaviour {

	// Use this for initialization
	void Start () {
		rigidbody2D.AddForce(new Vector2(800f,0f));
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
