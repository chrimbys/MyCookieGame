using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShopButton : MonoBehaviour
{
    //
    //現在の合計金額を取得する
    [SerializeField]
    MoneyCount moneyCount;
    //スクリプトをアタッチするボタン
    [SerializeField]
    Button button;
    //クッキーの材料価格を受け取るため
    [SerializeField]
    CookiesData cookiesData;
    //材料を購入する金額
    public double ingredient;
    //材料購入の判定
    public bool purchase = false;

    SoundManager soundManager;

    void Start()
    {
        soundManager = GameObject.Find("SoundManager").GetComponent<SoundManager>();
        ingredient = cookiesData.ingredient;
    }
    //売上金額が材料購入に必要な金額以上か判断
    void Update()
    {
        if (purchase == false)
        {
            if (moneyCount.money >= ingredient)
            {
                button.interactable = true;
            }
            else
            {
                button.interactable = false;
            }
        }
        else
        {
            button.interactable = false;
        }
    }
    //ボタンを押すと実行
    public void Purchase()
    {
        soundManager.OnClickPurchaseButton();
        moneyCount.money -= ingredient;
        moneyCount.TotalAmountUpdate();
        purchase = true;
    }
}
