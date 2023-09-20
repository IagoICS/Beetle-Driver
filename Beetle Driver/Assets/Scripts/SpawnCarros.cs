using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnCarros : MonoBehaviour
{
    public GameObject carroPrefab;
    public float intervaloSpawn = 3.0f;
    public float tempoDeVidaCarro = 5.0f;
  public float distanciaAntesDoJogador = 10.0f; 
    public float variacaoPosicaoX = 5.0f; 
    public float variacaoPosicaoZ = 3.0f; 

    private Transform jogador; 
    private float proximaPosicaoSpawnX;

    private void Start()
    {
        jogador = GameObject.FindWithTag("Player").transform;

        
        InvokeRepeating("SpawnCarro", 2.0f, intervaloSpawn);
    }

    private void SpawnCarro()
    {

        float spawnX = Random.Range(jogador.position.x - variacaoPosicaoX, jogador.position.x + variacaoPosicaoX);
        float spawnZ = Random.Range(jogador.position.z, jogador.position.z + distanciaAntesDoJogador);

        Vector3 spawnPosition = new Vector3(spawnX, transform.position.y, spawnZ);


        GameObject novoCarro = Instantiate(carroPrefab, spawnPosition, Quaternion.identity);

  
        Destroy(novoCarro, tempoDeVidaCarro);
    }
}