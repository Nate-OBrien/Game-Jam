using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    public float horizontalInput;
    public float verticalInput;
    public float speed = 25f;
    float forwardBoost = 1f;
    public bool test = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float horizontalRotate = 0f;
        if (Input.GetKey(KeyCode.Q)){ 

            horizontalRotate = 1f;
        }
        if (Input.GetKey(KeyCode.E)){
            horizontalRotate = -1f;
        }if(Input.GetKey(KeyCode.Space)){
            test = true;   
        } if(Input.GetKeyUp(KeyCode.Space)){
            test = false;
        }
        
        if(test){
            forwardBoost=25f;
        } else {
            forwardBoost = 1f;
        }


        horizontalInput = Input.GetAxis("Horizontal");
        verticalInput = Input.GetAxis("Vertical");
        transform.Translate(speed * forwardBoost * Time.deltaTime * Vector3.forward);
        transform.Rotate(speed * horizontalInput * Time.deltaTime * Vector3.up);
        transform.Rotate(speed * verticalInput * Time.deltaTime * Vector3.right);
        transform.Rotate(speed * 2 * horizontalRotate * Time.deltaTime * Vector3.forward);
    }
}
