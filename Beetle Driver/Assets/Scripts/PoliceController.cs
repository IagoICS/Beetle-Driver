using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PoliceController : MonoBehaviour
{
       public Transform jogador; 
    public float velocidade = 5f; 

    private void Update()
    {
       
        if (jogador != null)
        {
           
          Vector3 direcao = (new Vector3(jogador.position.x, transform.position.y, jogador.position.z) - transform.position).normalized;
transform.Translate(direcao * velocidade * Time.deltaTime);
        }
    }
}