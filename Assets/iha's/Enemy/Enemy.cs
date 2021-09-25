using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : SuperEnemy
{
    public ObjectFlyer<SuperItem> flyer;
    public Vector3 pos;

    public GameObject Bullet;
    float time = 0f;

    public Vector3 direction;

    void Start()
    {
        flyer = new ObjectFlyer<SuperItem>(Bullet.GetComponent<SuperItem>());
    }
    void Update()
    {
        time += Time.deltaTime;
        if (time >= 0.5f)
        {
            time = 0f;
            flyer.GetMob(this.transform.position + new Vector3(0, 0, 1.0f), x => { x.Shot(direction); });
        }
    }

    void OnTriggerEnter(Collider collision)
    {
        GameObject obje = collision.gameObject;
        SuperItem item = obje.GetComponent<SuperItem>();
        if (item != null)
        {
            this.Touch(item);
            if (this.mobData.hp <= 0)
            {
                this.gameObject.SetActive(false);
            }
        }
    }
}
