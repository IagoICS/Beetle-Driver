using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    
    private CharacterController controller;

    public float speed;
    public LayerMask layer;
    public LayerMask coinlayer;
    public float rayRadius;
    public AudioSource coinCollectSound;
    public float horizontalSpeed;
    public bool isMovingRight;
    public bool isMovingLeft;
    private bool isDead;

    private GameController gamecontrol;
    void Start()
    {
        controller = GetComponent<CharacterController>();
        gamecontrol = FindObjectOfType<GameController>();
    }

 

    // Update is called once per frame
    void Update()
    {
        Vector3 direction = Vector3.forward * speed;

 

        controller.Move(direction*Time.deltaTime);

 

        if (Input.GetKeyDown(KeyCode.RightArrow) &&transform.position.x < 3f && !isMovingRight) 
        {
            isMovingRight = true;
            StartCoroutine(RightMove());
        }

        if(Input.GetKeyDown(KeyCode.LeftArrow) && transform.position.x > -3f && !isMovingLeft)
        {
            isMovingLeft=true;
            StartCoroutine(LeftMove());
        }
        OnCollision();

    }

 

    IEnumerator LeftMove()
    {
    for(float i = 0; i < 10; i += 0.1f)
        {
        controller.Move(Vector3.left * Time.deltaTime * horizontalSpeed);
        yield return null;
            
        }
          isMovingLeft = false;
    }

 

    IEnumerator RightMove()
    {
        for (float i = 0; i < 10; i += 0.1f)
        {
            controller.Move(Vector3.right * Time.deltaTime * horizontalSpeed);
            yield return null;
           
        }
    isMovingRight = false;
 

    }
    void OnCollision()
    {
         RaycastHit coinHit;
        if(Physics.Raycast(transform.position,transform.TransformDirection(Vector3.forward), out coinHit,rayRadius,coinlayer))
        {
            gamecontrol.AddCoin();
            
          Destroy(coinHit.transform.gameObject);

          if (coinCollectSound != null)
    {
        coinCollectSound.Play();
    }
        }

        RaycastHit hit;
        if(Physics.Raycast(transform.position,transform.TransformDirection(Vector3.forward), out hit,rayRadius,layer)&& !isDead)
        {
            Debug.Log("Bateu dms");
            speed=0;
            isDead= true;
            horizontalSpeed=0;
            gamecontrol.ShowGameOver();
        }
       
    }
}