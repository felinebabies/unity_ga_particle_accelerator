using UnityEngine;
using System.Collections;

public class GameController : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		//左のコイル
		if(Input.GetMouseButtonDown(0)){
			Coil leftcoil = (Coil)GameObject.Find ("LeftCoil").GetComponent<Coil>();
			leftcoil.SetWake(true);
		}
		if(Input.GetMouseButtonUp(0)){
			Coil leftcoil = (Coil)GameObject.Find ("LeftCoil").GetComponent<Coil>();
			leftcoil.SetWake(false);
		}
		//右のコイル
		if(Input.GetMouseButtonDown(1)){
			Coil leftcoil = (Coil)GameObject.Find ("RightCoil").GetComponent<Coil>();
			leftcoil.SetWake(true);
		}
		if(Input.GetMouseButtonUp(1)){
			Coil leftcoil = (Coil)GameObject.Find ("RightCoil").GetComponent<Coil>();
			leftcoil.SetWake(false);
		}
	}
}
