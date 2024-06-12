using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;

public class enemyTowardsPlayer : MonoBehaviour
{
    private Transform target;
    public float speed = 50f;
    public GameObject player;

    public Material mat1;
    public Material mat2;
    private Renderer playerRenderer;
    public float distance;
    GameManager GameManager;
    // Start is called before the first frame update
    void Start()
    {
        target = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();
        playerRenderer = player.GetComponent<Renderer>();
        GameManager = FindObjectOfType<GameManager>(); 
    }


    void Update(){
        
        transform.position = Vector3.MoveTowards(transform.position, target.position, speed * Time.deltaTime);
        distance = Vector3.Distance(transform.position, player.transform.position);
        
    }

    void OnCollisionEnter(Collision other) {
    if(other.gameObject.CompareTag("Player")){
        player.GetComponent<PlayerMovement>().enabled = false;
        StartCoroutine(EndGameAfterDelay(2f));
    }
}

IEnumerator EndGameAfterDelay(float delay){    
    yield return new WaitForSeconds(delay);
    GameManager.EndGame();
}
}
