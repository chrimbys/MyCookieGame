using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LavelUpButton : MonoBehaviour
{

    //現在の合計金額を取得する
    [SerializeField]
    MoneyCount moneyCount;
    //MoneyCountスクリプトの変数Money
    double money;
    //生産量上昇に必要な金額を取得する
    [SerializeField]
    Cookie cookie;
    //Cookieスクリプトの変数lavelUpPrice
    double lavelUpPrice;
    //スクリプトをアタッチするボタン
    [SerializeField]
    Button button;

    // Update is called once per frame
    void Update()
    {
        ButtonBool();
    }
    //売上金額がレベルアップに必要な金額以上か判断
    public void ButtonBool()
    {
        money = moneyCount.Money;
        lavelUpPrice = cookie.lavelUpPrice;
        //Debug.Log("Money=" + money);
        //Debug.Log("lavelupprice=" + lavelUpPrice);

        if (money >= lavelUpPrice)
        {
            button.interactable = true;
        }
        else
        {
            button.interactable = false;
        }
    }
}
