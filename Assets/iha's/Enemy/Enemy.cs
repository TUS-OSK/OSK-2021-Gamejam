using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : SuperEnemy
{

    void Start()
    {
        
    }

    public GameObject Bullet;
    float time = 0f;

    void Update()
    {
        time += Time.deltaTime;
        if(time>=0.5f)
        {
            time = 0f;
            Instantiate(Bullet, this.transform.position + new Vector3(0,0,1.0f), Quaternion.identity);
            
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
