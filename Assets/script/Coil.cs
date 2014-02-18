using UnityEngine;
using System.Collections;

public class Coil : MonoBehaviour {
	public Material[] m_materials;
	private bool m_wake;

	// Use this for initialization
	void Start () {
		m_wake = false;
	}
	
	// Update is called once per frame
	void Update () {
		if(m_wake){
			//マテリアル変更
			renderer.material = m_materials[1];
		}
		else {
			//マテリアル変更
			renderer.material = m_materials[0];
		}
	}

	void FixedUpdate () {
		const float maxforce = 1.5f; //磁力係数
		const float coilradius = 0.1f;
		GameObject ball;
		Vector2 balltocoil;
		Vector2 direction;
		float force;

		if(m_wake){
			//ボールに対する引力の処理
			ball = GameObject.Find ("Ball");

			//コイルとボールの位置関係を求める
			balltocoil = this.transform.position - ball.transform.position;
			direction = balltocoil.normalized;

			force = maxforce / Mathf.Pow (balltocoil.magnitude + coilradius, 2f);
			if(force < 0f){
				force = 0f;
			}

			//力を加える
			ball.rigidbody2D.AddForce(direction * force);
		}
	}

	//起動状態の切り替え
	public void SetWake(bool wakests){
		m_wake = wakests;
	}
}
