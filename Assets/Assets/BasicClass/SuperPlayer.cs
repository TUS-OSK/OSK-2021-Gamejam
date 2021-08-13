using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SuperPlayer : MonoBehaviour
{
    public PlayerData playerData;
    public MobData mobData;

    //このTouchをOnColitionEnterとかで上手いこと呼び出しておくんだ
    public virtual MobData Touch(SuperItem item)
    {
        if (item.itemData.hitPlayers)
        {
            mobData.Damage(item.itemData.damage);
            playerData.score += item.itemData.score;
        }

        item.checkHitObject(mobData);
        return mobData;
    }

}
