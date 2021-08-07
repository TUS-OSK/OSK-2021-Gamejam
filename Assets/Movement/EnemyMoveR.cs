using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMoveR : MonoBehaviour
{
    void Start()
    {
        if(Left)
        {
            speedX *= -1.0f;
        }
    }

    public bool Left = false;//チェックすると初動が左向きになる

    float time = 0f;
    public float speedX;
    float c = 0;
    public float Count;

    void Update()
    {
        time = Time.deltaTime;
        this.transform.position += new Vector3(speedX,0,0);
        c++;
        if(c>=Count)
        {
            c=0;
            speedX *= -1;
        }
    }
}
