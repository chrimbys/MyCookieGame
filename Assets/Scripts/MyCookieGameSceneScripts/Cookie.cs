using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Cookie : MonoBehaviour
{
    //CookieDataの受け取り場所
    //public CookiesData cookiesData;
    //初期売上金額
    //public double bacePrice;
    //売上金額
    //public double price;
    //生産量上昇した回数
    //private int incrCount;
    //生産量上昇回数の上限
    //public int maxCount;
    //生産量上昇用ボタン
    //[SerializeField]
    //Button button;
    //クッキーの売上金額を表示
    //[SerializeField]
    //Text priceText;
    //合計売上金額の表示
    //[SerializeField]
    //MoneyCount moneyCount;
    //[SerializeField]
    //LavelUpButton lavelUpButton;
    //経過時間
    //float time = 0.0f;
    //売上加算までのインターバル時間
    //float dt = 1.0f;

    //初期化
    void Start()
    {
        //bacePrice = cookiesData.bacePrice;
        //maxCount = cookiesData.maxCount;
        //priceText.text = price + "円/秒";
    }

    //経過時間の計算と売上金額の加算処理
    void Update()
    {
        /*time += Time.deltaTime;
        if(time >= dt)
        {
            PriceCalculation();
            time = 0.0f;
        }*/
    }

    //売上金額の計算、合計金額に渡す
    public void PriceCalculation()
    {
        //price = bacePrice + bacePrice * lavelUpButton.incrCount;
        //priceText.text = price + "円/秒";
        //moneyCount.TotalAmount(price);

    }

}
