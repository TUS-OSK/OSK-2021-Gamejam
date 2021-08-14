using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyClockwise : MonoBehaviour
{
    void Start()
    {
        if(AntiClockwise)
        {
            speed *= -1.0f;
        }
    }

    public bool AntiClockwise = false;//チェックすると反時計回りになる

    public float speed;
    public float radius;
    float x;                         
    float z;

    void Update()
    {
        x = radius * Mathf.Sin(Time.time * speed);
        z = radius * Mathf.Cos(Time.time * speed);

        this.transform.position += new Vector3(x,0,z);
    }
}
