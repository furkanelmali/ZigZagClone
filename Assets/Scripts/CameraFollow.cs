using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    [SerializeField] private Transform ball;
    [SerializeField] private float lerpVal;

    private Vector3 offset;
    private Vector3 newPosition;
    // Start is called before the first frame update
    void Start()
    {
        offset = transform.position - ball.position;
    }

    // Update is called once per frame
    void LateUpdate()
    {
        SetCameraSmoothFollow();
    }

    private void SetCameraSmoothFollow() 
    {
        newPosition = Vector3.Lerp(transform.position, ball.position + offset, lerpVal * Time.deltaTime);
        transform.position = newPosition;   
    
    }
}
