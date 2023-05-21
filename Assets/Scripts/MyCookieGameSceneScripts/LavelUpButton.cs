using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LavelUpButton : MonoBehaviour
{

    //現在の合計金額を取得する
    [SerializeField]
    MoneyCount moneyCount;
    //生産量上昇に必要な金額を取得する
    //[SerializeField]
    //Cookie cookie;
    //生産量上昇回数を表示
    [SerializeField]
    Text buttonText;
    [SerializeField]
    CookiesData cookiesData;
    [SerializeField]
    Text priceText;
    //CookieDataのlavelUpPrice
    public double lavelUpPrice;
    //レベルアップした回数
    public int incrCount = 0;
    //以下の2変数は試行が必要のためinspectorから設定可能にする
    //レベルアップに必要な金額の上昇率
    [SerializeField]
    double rateIncr;
    //レベルアップ回数の上限
    [SerializeField]
    int maxCount;

    //初期売上金額
    public double bacePrice;
    //売上金額
    public double price;


    //有効・無効にしたいボタン
    [SerializeField]
    Button button;

    void Start()
    {
        bacePrice = cookiesData.bacePrice;
        lavelUpPrice = cookiesData.lavelUpPrice;
        //rateIncr = this.rateIncr;
        priceText.text = bacePrice + "円/秒";
        buttonText.text = "生産量UP\n" + incrCount + "回\n" + lavelUpPrice.ToString("f2") + "円";
    }
    // Update is called once per frame
    void Update()
    {
        if (moneyCount.money >= lavelUpPrice)
        {
            button.interactable = true;
        }
        else
        {
            button.interactable = false;
        }
    }
    public void LavelUp()
    {
        moneyCount.money -= lavelUpPrice;//合計売上金額の減額・変更
        moneyCount.TotalAmountUpdate();
        incrCount++;//レベルアップ回数の加算
        lavelUpPrice *= rateIncr;//レベルアップに必要な金額を増額
        price = bacePrice + bacePrice * incrCount;//毎秒の売上金額を更新
        priceText.text = price + "円/秒";
        buttonText.text = "生産量UP\n" + incrCount + "回\n" + lavelUpPrice.ToString("f2") + "円";//レベルアップ回数・金額を更新
        if (incrCount == maxCount)//上限に達した場合ボタンを無効にする
        {
            button.interactable = false;
        }

    }
    //1秒に1回実行される。Activeになっているクッキーのpriceが合計金額moneyに加算される
    public void PriceCalculation()
    {
        price = bacePrice + bacePrice * incrCount;
        moneyCount.TotalAmount(price);
    }


}
