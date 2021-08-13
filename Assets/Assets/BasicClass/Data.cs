using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[System.Serializable]
public class MobData
{
    //ここのプロパティは外部から触れない。メソッドを介して操作する
    private int UnTouchHp = 0;
    private bool UnTouchArive = true;

    //ここを皆参照する
    //{ get; }はプロパティという機能で、なんか入出力をどうこう出来る 詳しくはググろう
    public int hp { get { return UnTouchHp; } }
    public bool arive { get { return UnTouchArive; } }
    public void Damage(int damage)
    {
        if (damage < UnTouchHp)
        {
            UnTouchHp -= damage;
        }
        else
        {
            if (arive) UnTouchArive = false;
            UnTouchHp = 0;
        }
    }

    public void setHp(int setHp, bool setArive)
    {
        UnTouchHp = setHp;
        UnTouchArive = setArive;

    }
}
[System.Serializable]
public class PlayerData
{
    public int score;
}