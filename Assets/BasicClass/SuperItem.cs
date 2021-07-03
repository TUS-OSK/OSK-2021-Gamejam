using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//プレイヤー、敵に当たってなにか影響をもたらす物
public class SuperItem : MonoBehaviour
{
    public ItemData itemData;
    public virtual void checkHitObject(MobData data) { }
}

[System.Serializable]
public class ItemData
{
    public bool hitPlayers = false;
    public bool hitEnemys = false;
    public int damage = 0;
    public int score = 0;
}