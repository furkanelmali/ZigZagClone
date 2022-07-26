using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundExit : MonoBehaviour
{
    private Rigidbody rb;
    private GroundController controller;

    private void Start()
    {
        controller = FindObjectOfType<GroundController>();
        rb = GetComponent<Rigidbody>();
    }

   
    private void OnCollisionExit(Collision collision)
    {
        if (collision.gameObject.CompareTag("Ball"))
        {
            new WaitForSeconds(1f);
            rb.isKinematic = false;
            rb.useGravity = true;
            
            
        }
    }
    private void Update()
    {
        Destroyer();
    }

    private void Destroyer() 
    {
        if (this.gameObject.transform.position.y <= -10) 
        {
            controller.CreateGround();
            Destroy(this.gameObject);
        }
    }

   
    
}

    
