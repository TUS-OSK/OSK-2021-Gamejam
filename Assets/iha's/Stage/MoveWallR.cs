using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveWallR: MonoBehaviour
{
    void Start()
    {
        
    }

    float move = 0.25f;

    void Update()
    {
        transform.position += new Vector3(move,0,0);

        if(transform.position==new Vector3(8,0,0))
        {
            move *= -1;
        }
        if(transform.position==new Vector3(-8,0,0))
        {
            move *= -1;
        }
    }
}
