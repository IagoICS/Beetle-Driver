using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnCarros : MonoBehaviour
{
    public GameObject carroPrefab;
    public float intervaloSpawn = 3.0f;
    public float tempoDeVidaCarro = 5.0f;
  public float distanciaAntesDoJogador = 10.0f; // Distância antes do jogador onde os carros serão gerados
    public float variacaoPosicaoX = 5.0f; // Variação máxima ao longo do eixo X
    public float variacaoPosicaoZ = 3.0f; // Variação máxima ao longo do eixo Z
    

    private Transform jogador; // Referência ao jogador
    private float proximaPosicaoSpawnX;

    private void Start()
    {
        jogador = GameObject.FindWithTag("Player").transform; // Encontre o jogador com base em uma tag (ajuste a tag conforme necessário)

        // Inicie o processo de spawn de carros em intervalos regulares
        InvokeRepeating("SpawnCarro", 2.0f, intervaloSpawn);
    }

    private void SpawnCarro()
    {
        // Calcule uma posição aleatória ao longo do eixo X e Z dentro das variações especificadas
        float spawnX = Random.Range(jogador.position.x - variacaoPosicaoX, jogador.position.x + variacaoPosicaoX);
        float spawnZ = Random.Range(jogador.position.z, jogador.position.z + distanciaAntesDoJogador);

        Vector3 spawnPosition = new Vector3(spawnX, transform.position.y, spawnZ);

        // Faça o spawn do carro na posição
        GameObject novoCarro = Instantiate(carroPrefab, spawnPosition, Quaternion.identity);

        // Configure o tempo de vida do carro
        Destroy(novoCarro, tempoDeVidaCarro);
    }
}