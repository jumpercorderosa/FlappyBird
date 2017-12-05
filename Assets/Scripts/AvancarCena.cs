using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class AvancarCena : MonoBehaviour {

	//atributo para receber o nome da cena
	public string cena;
	
	// Update is called once per frame
	void Update () {

		//Fire1 ==> Touch, CTRL + LEFT, Click+Left
		if(Input.GetButtonDown("Fire1")) {

			//passo o nome da cena
			SceneManager.LoadScene(cena);
			//ou
			//SceneManager.LoadScene("GameScene");

		}
		
	}
}
