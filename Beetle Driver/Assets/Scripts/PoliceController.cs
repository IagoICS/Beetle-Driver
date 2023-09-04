using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PoliceController : MonoBehaviour
{
       public Transform jogador; // Referência ao jogador
    public float velocidade = 5f; // Velocidade de perseguição

    private void Update()
    {
        // Verifique se o jogador existe
        if (jogador != null)
        {
            // Mova o objeto perseguidor em direção ao jogador
          Vector3 direcao = (new Vector3(jogador.position.x, transform.position.y, jogador.position.z) - transform.position).normalized;
transform.Translate(direcao * velocidade * Time.deltaTime);
        }
    }
}