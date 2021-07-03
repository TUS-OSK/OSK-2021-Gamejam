using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IShootable
{
    //これを実装してもらう
    //Player,Enemyは弾のプレハブを召喚して、その後これを行うこと
    void Shot(Vector3 direction);
}
