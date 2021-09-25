using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : SuperEnemy
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    void OnTriggerEnter(Collider collision)
    {
        SuperItem item = collision.gameObject.GetComponent<SuperItem>();
        if (item != null)
        {
            this.Touch(item);
        }

    }

}
