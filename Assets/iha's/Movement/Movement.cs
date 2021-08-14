using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//全体の動き

public class Movement : MonoBehaviour
{
    float time = 0f;
    public float zspeed;

    void Update()
    {
        time = Time.deltaTime;
        this.transform.position += new Vector3(0,0,zspeed*time);
    }
}