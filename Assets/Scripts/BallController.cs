using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallController : MonoBehaviour
{
    public Vector3 ballDirection;
    [SerializeField] float ballMoveSpeed = 2;
    // Start is called before the first frame update
    void Start()
    {
        ballDirection = Vector3.left;
    }

    // Update is called once per frame
    void Update()
    {
        handeBallInputs();
        ballMovement();
    }

    private void handeBallInputs() 
    {
        if (Input.GetMouseButtonDown(0)) 
        {
            if(ballDirection.x == -1) 
            {
                ballDirection = Vector3.forward;
            }
            else 
            {
                ballDirection = Vector3.left;
            }
        
        }
    
    }

    private void ballMovement()
    {
        transform.position += ballDirection * ballMoveSpeed * Time.deltaTime;
    }
}
