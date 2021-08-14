using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item : SuperItem
{
    private Vector3 ukeVec3;

    void Update()
    {
        transform.position += ukeVec3*Time.deltaTime;
    }

    public override void Shot(Vector3 direction)
    {
        ukeVec3 = direction;
    }
}

