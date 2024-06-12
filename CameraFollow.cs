using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{

    public GameObject player;
    public Vector3 offset = new(0,2,-9);
    
    // Update is called once per frame
    void Update()
    {
        transform.position = player.transform.position + offset;
        
    }
}
