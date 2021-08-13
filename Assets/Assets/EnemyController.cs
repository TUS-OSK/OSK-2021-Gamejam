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
        SuperPlayer Player = collision.gameObject.GetComponent<SuperPlayer>();
        if (Player != null)
        {
            mobData.Touch();
        }

    }

}
