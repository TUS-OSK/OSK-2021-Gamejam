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

        defPosition = transform.position;
    }

    public bool AntiClockwise = false;//チェックすると反時計回りになる

    public float speed;
    public float radius;
    private Vector3 defPosition;
    float x;                         
    float z;

    void Update()
    {
        x = radius * Mathf.Sin(Time.time * speed);
        z = radius * Mathf.Cos(Time.time * speed);

        transform.position = new Vector3(x+defPosition.x,defPosition.y, z+defPosition.z);
    }
}
