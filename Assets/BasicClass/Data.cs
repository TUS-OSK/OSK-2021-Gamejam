using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[System.Serializable]
public class MobData
{
    //昔ここはプロパティを使っていたがあまり意味がなさそうなので普通のクラスにしてやりました
    [SerializeField] public int hp;
    [SerializeField] public bool arive = true;
    public void Damage(int damage)
    {
        if (damage < hp)
        {
            hp -= damage;
        }
        else
        {
            if (arive) arive = false;
            hp = 0;
        }
    }
}
[System.Serializable]
public class PlayerData
{
    public int score;
}