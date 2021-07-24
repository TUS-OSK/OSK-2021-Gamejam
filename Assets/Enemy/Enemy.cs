using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : SuperEnemy
{
    public GameObject bullet;
    Vector3 createPosition;

    void Start()
    {
        
    }

    float c=0;

    void Update()
    {
        c++;
        if (c==20)
        {
            c=0;
            createPosition = transform.position;
            createPosition.z += 1.0f;

            Instantiate(bullet, createPosition, Quaternion.identity);
        }
    }

    void OnTriggerEnter(Collider collision)
    {
        GameObject obje = collision.gameObject;
        SuperItem item = obje.GetComponent<SuperItem>();
        if(item!=null)
        {
            this.Touch(item);
        }
        Debug.Log("test");
    }
}
