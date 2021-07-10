using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//全体の動き

public class Movement : MonoBehaviour
{
    void Start()
    {
        
    }

    void Update()
    {
        transform.position += new Vector3(0,0,-1f);
    }
}