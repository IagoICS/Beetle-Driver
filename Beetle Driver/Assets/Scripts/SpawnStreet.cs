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
      Debug.Log(distance);
       if (distance >=1)
       {
        Recycle(currentGrounds[groundIndex].gameObject);
        groundIndex++;
        

        currentGroundPoint = currentGrounds[groundIndex].GetComponent<Ground>().ponto;
       }
        if(groundIndex>currentGrounds.Count -1)
        {
            groundIndex=0;
        }
           
        
    }
    public void Recycle(GameObject grounds)
    {
        grounds.transform.position = new Vector3(0,0,offset);
        offset+=32;
    }

}
