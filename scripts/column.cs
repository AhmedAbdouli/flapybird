using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class column : MonoBehaviour
{
    void Start()
    {
        
    }

    void Update()
    {
       transform.position = transform.position - new Vector3(5*Time.deltaTime,0,0); 
    }
}
