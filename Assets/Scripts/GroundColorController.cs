using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundColorController : MonoBehaviour
{
    [SerializeField] private Material groundMat;
    [SerializeField] private Color[] groundColors;
    [SerializeField] private float lerp;
    [SerializeField] private float time;

    private float currentTime;
    private int colorint = 0;

    private void Update()
    {
        SetColorTime();
        SetColorChange();
    }


    private void SetColorTime() 
    {
        
        if (currentTime <= 0)
        {
            SetColorInt();
            currentTime = time;
        }
        else 
        {
            currentTime -= Time.deltaTime;
        }
            
        
       
       
    
    }

    private void SetColorInt() 
    {
        colorint++;
        
        if(colorint >= groundColors.Length) 
        {
            colorint = 0;
        }
    
    
    }

    private void SetColorChange() 
    {
        groundMat.color = Color.Lerp(groundMat.color, groundColors[colorint], lerp * Time.deltaTime);
    
    }

    private void OnDestroy()
    {
        groundMat.color = groundColors[0];
    }


}
