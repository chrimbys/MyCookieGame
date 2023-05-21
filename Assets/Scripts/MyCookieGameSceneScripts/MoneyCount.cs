using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using UnityEngine;
using UnityEngine.UI;

public class MoneyCount : MonoBehaviour
{
    public double money = 0;
    [SerializeField]
    private Text moneyCountText;
    //[SerializeField]
    //LavelUpButton lavelUpButton;
    [SerializeField]
    LavelUpButton[] lavelUpButtons = new LavelUpButton[20];
    //経過時間
    float time = 0.0f;
    //売上加算までのインターバル時間
    float dt = 1.0f;

    // Start is called before the first frame update
    void Start()
    {
        TotalAmountUpdate();
    }

    // Update is called once per frame
    void Update()
    {
        time += Time.deltaTime;
        if (time >= dt)
        {
            for(int i = 0; i < lavelUpButtons.Length; i++)
            {
                lavelUpButtons[i].PriceCalculation();
            }
            time = 0.0f;
        }

        //Debug用
        if (Input.GetKey(KeyCode.Space))
        {
            money = 1;
            TotalAmountUpdate();
        }
    }

    public void TotalAmount(double a)
    {
        money = money + a;
        TotalAmountUpdate();
    }
    //値を更新するためのメソッド　他スクリプトでも使用
    public void TotalAmountUpdate()
    {
        //N0で整数値が３桁のコンマ区切り文字列に変換される// 
        moneyCountText.text = money.ToString("N0") + "円";
    }
}
