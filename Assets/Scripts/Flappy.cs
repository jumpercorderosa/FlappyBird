using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Flappy : MonoBehaviour {

	Rigidbody2D rb;
	public float impulso;

	// Use this for initialization
	void Start () {

		//Instancia o componente Rigibody
		rb = GetComponent<Rigidbody2D> ();	
	}
	
	// Update is called once per frame
	void Update () {
		
		//Aplica uma força exponencial
		//rb.AddForce(Vector2.up * 500.0f) add force concatena a força

		//Aplica uma forca linear no eixo
		if (Input.GetButtonDown("Jump")) {
			rb.velocity = new Vector2 (0.0f, impulso);
		}
	}
}
