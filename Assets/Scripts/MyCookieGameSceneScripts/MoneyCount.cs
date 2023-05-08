using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using UnityEngine;
using UnityEngine.UI;

public class MoneyCount : MonoBehaviour
{
    public BigInteger Money;
    [SerializeField]
    private Text moneyCountText;


    // Start is called before the first frame update
    void Start()
    {
        Money = 1;

        //N0で整数値が３桁のコンマ区切り文字列に変換される// 
        moneyCountText.text = Money.ToString("N0") + "円";


    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
