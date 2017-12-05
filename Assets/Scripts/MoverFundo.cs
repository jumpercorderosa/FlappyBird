using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoverFundo : MonoBehaviour {

	public float velocidade;
	public float posicaoInicial, posicaoFinal;

	// Update is called once per frame
	void Update () {

		//verifica se atingiu o limite da camera e reposiciona para um novo ciclo
		if (transform.position.x <= posicaoFinal) {
			
			//pegando a propria posicao dele! não estou alterando nada
			transform.position = new Vector2 (posicaoInicial, transform.position.y);
		}

		//move o fundo para o lado esquerdo da tela
		transform.Translate (Vector2.left * velocidade * Time.deltaTime);

	}


}
