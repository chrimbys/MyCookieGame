using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class CookieData : ScriptableObject
{
    //クッキーの番号
    public int num;
    //クッキーの名前
    public string cookieName;
    //初期売上金額
    public double bacePrice;
    //売上金額の上昇率
    public double rateIncr;
    //上昇回数の上限
    public int maxCount;
    

}
