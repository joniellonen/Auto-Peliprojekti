using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarControl : MonoBehaviour
{
    public Rigidbody car;
    public float forwardAcceleration= 8f, reverseAcceleration = 3f, maxSpeed = 50f, turnForce = 180;
    public float speedInput, turnInput;
    public float horizontalInput = Input.GetAxis("Horizontal");
    

    // Start is called before the first frame update
    void Start()
    {
        car.transform.parent = null;
    }

    // Update is called once per frame
    void Update()
    {
       
        
        
       
       
        
        
        speedInput = 0f;
        if (Input.GetAxis("Vertical") > 0)
        {
            speedInput = Input.GetAxis("Vertical") * forwardAcceleration * 1000f;
        } else if (Input.GetAxis("Vertical") < 0)
        {
            speedInput = Input.GetAxis("Vertical") * reverseAcceleration * 1000f;
        }


 
        
        
        
        
        transform.position = car.transform.position;
    }

    private void FixedUpdate()
    {
        if(Mathf.Abs(speedInput) > 0)
         {
            car.AddForce(transform.forward * speedInput);
         }

    }








}



