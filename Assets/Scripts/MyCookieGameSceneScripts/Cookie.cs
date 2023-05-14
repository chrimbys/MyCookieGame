using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Cookie : MonoBehaviour
{
    //CookieDataの受け取り場所
    public CookieData cookieData;
    //生産量上昇した回数
    private int incrCount = 0;
    //初期売上金額
    public double bacePrice;
    //売上金額
    public double price;
    //生産量上昇に必要な金額
    public double lavelUpPrice;
    //生産量上昇に必要な金額の上昇率
    public double rateIncr;
    //生産量上昇回数の上限
    public int maxCount;
    //生産量上昇用ボタン
    [SerializeField]
    Button button;
    //生産量上昇回数を表示
    [SerializeField]
    Text countText;
    //クッキーの売上金額を表示
    [SerializeField]
    Text priceText;
    //合計売上金額の表示
    [SerializeField]
    MoneyCount moneyCount;
    //経過時間
    float time = 0.0f;
    //売上加算までのインターバル時間
    float dt = 1.0f;
    //合計売上金額
    double money;


    //初期化
    void Start()
    {
        bacePrice = cookieData.bacePrice;
        rateIncr = cookieData.rateIncr;
        maxCount = cookieData.maxCount;
        lavelUpPrice = cookieData.lavelUpPrice;
        countText.text = "生産量UP\n" + incrCount + "回\n" + lavelUpPrice.ToString("f2")+ "円";
        priceText.text = price + "円/秒";
    }

    //経過時間の計算と売上金額の加算処理
    void Update()
    {
        time += Time.deltaTime;
        if(time >= dt)
        {
            PriceCalculation();
            time = 0.0f;
        }
    }

    //売上金額の計算、合計金額に渡す
    public void PriceCalculation()
    {
        price = bacePrice + bacePrice * incrCount;
        priceText.text = price + "円/秒";
        moneyCount.TotalAmount(price);

    }

    public void LavelUp()
    {
        money = moneyCount.Money;
        incrCount += 1;
        money -= lavelUpPrice;
        lavelUpPrice *= rateIncr;
        countText.text = "生産量UP\n" + incrCount + "回\n" + lavelUpPrice.ToString("f2") + "円";
        if (incrCount == 99)
        {
            button.interactable = false;
        }

    }
}
