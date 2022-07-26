using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundController : MonoBehaviour
{
    public GameObject lastGroundObj;

    [SerializeField] private GameObject groundPrefab;

    private GameObject newGroundObj;
    private int GroundDir;

    // Start is called before the first frame update
    void Start()
    {
        RandomNewGrounds();
    }

    public void RandomNewGrounds() 
    {
        for(int i = 0; i < 75; i++) 
        {
            CreateGround();
        }
    
    }

    public void CreateGround() 
    {
        GroundDir = Random.Range(0, 2);
        if (GroundDir == 0)
        {
            newGroundObj = Instantiate(groundPrefab, new Vector3(lastGroundObj.transform.position.x - 1f,
                                                                 lastGroundObj.transform.position.y,
                                                                 lastGroundObj.transform.position.z), Quaternion.identity);
            lastGroundObj = newGroundObj;
        }
        else 
        {
            newGroundObj = Instantiate(groundPrefab, new Vector3(lastGroundObj.transform.position.x,
                                                                 lastGroundObj.transform.position.y,
                                                                 lastGroundObj.transform.position.z+1f), Quaternion.identity);
            lastGroundObj = newGroundObj;
        }
    
    }
}
