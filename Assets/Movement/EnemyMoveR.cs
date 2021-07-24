using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMoveR : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    int c = 0;
    int C = 25;
    float speedX = 0.5f;

    void Update()
    {
        transform.position += new Vector3(speedX,0,0);
        c++;
        if(c==C)
        {
            c=0;
            speedX *= -1;
        }
    }
}
