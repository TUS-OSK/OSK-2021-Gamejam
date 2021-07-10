using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : SuperEnemy
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    [SerializeField] GameObject enemyBulletPrefab;
    [SerializeField] float shotInterval;
    float timecount;

    void Update()
    {
        timecount += Time.deltaTime;

        if(timecount>=1)
        {
            timecount = 0;
            Instantiable(enemyBulletPrefab, transform.position, Quaternion.identity);
        }
    }
}
