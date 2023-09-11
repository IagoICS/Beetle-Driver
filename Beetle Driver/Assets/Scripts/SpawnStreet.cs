using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnStreet : MonoBehaviour
{
    public List<GameObject> ground = new List<GameObject>();
    public List<Transform> currentGrounds = new List<Transform>();
    public int offset;

    private Transform player;

    private Transform currentGroundPoint;
    private int groundIndex;

        public float positionErrorMargin = 0.1f;
    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player").transform;
        for (int i=0; i< ground.Count;i++)
        {
            Transform g=Instantiate(ground[i],new Vector3(0,0,i*32),transform.rotation).transform;
            currentGrounds.Add(g);
            offset+= 32;
        }
        
        currentGroundPoint = currentGrounds[groundIndex].GetComponent<Ground>().ponto;
    }

    // Update is called once per frame
    void Update()
    {
      float distance = player.position.z - currentGroundPoint.position.z;

        // Verificar direção do movimento do jogador
        Vector3 playerDirection = player.forward;

        // Verificar direção da rua
        Vector3 streetDirection = currentGroundPoint.forward;

        // Calcular produto escalar entre as direções
        float dotProduct = Vector3.Dot(playerDirection, streetDirection);

        if (distance >= 1 && dotProduct >= 0 && player.position.z >= currentGrounds[(groundIndex + 1) % currentGrounds.Count].GetComponent<Ground>().ponto.position.z - positionErrorMargin)
        {
            Recycle(currentGrounds[groundIndex].gameObject);
            groundIndex = (groundIndex + 1) % currentGrounds.Count;

            currentGroundPoint = currentGrounds[groundIndex].GetComponent<Ground>().ponto;
        }
    }
    public void Recycle(GameObject grounds)
    {
        grounds.transform.position = new Vector3(0,0,offset);
        offset+=32;
    }

}
