using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class SaveLoadManager : MonoBehaviour
{
    /*保存するもの
     * 売上Money
     * 各クッキーのレベル
     * 各材料のフラグ
     * 各クッキーを作ったかどうかのフラグ
     * チュートリアル完了のフラグ
     */
    [SerializeField]
    TextController TxtCntr;//チュートリアル完了フラグ
    [SerializeField]
    MoneyCount money;//売上金額
    [SerializeField]
    LavelUpButton[] lUBs;//レベルアップした回数
    [SerializeField]
    ShopButton[] prchs;//材料購入判定
    [SerializeField]
    MakeButton[] makes;//クッキーを作ったかどうか
    [SerializeField]
    PanelController pnlCntr;//TOP,SHOP,STUDIOのパネル配列取得

    private void OnApplicationQuit()
    {
        Debug.Log("savestart");
        PlayerPrefs.SetInt("flag0", TxtCntr.flag0);
        PlayerPrefs.SetString("Money", money.money.ToString());
        for (int i = 0; i < lUBs.Length; i++)
        {
            PlayerPrefs.SetInt($"LUBs{i}", lUBs[i].incrCount);
        }
        for(int j = 0; j < prchs.Length; j++)
        {
            PlayerPrefs.SetInt($"PRCHSs{j}", (prchs[j].purchase ? 1 : 0));
        }
        for (int k = 0; k < makes.Length; k++)
        {
            PlayerPrefs.SetInt($"MAKEs{k}", makes[k].make ? 1 : 0);
        }
        Debug.Log("saveend");
    }
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("loadstart");
        TxtCntr.flag0 = PlayerPrefs.GetInt("flag0");
        money.money = double.Parse(PlayerPrefs.GetString("Money", "1"));
        for (int i = 0; i < lUBs.Length; i++)
        {
            lUBs[i].incrCount = PlayerPrefs.GetInt($"LUBs{i}");
        }
        for (int j = 0; j < prchs.Length; j++)
        {
            prchs[j].purchase = (PlayerPrefs.GetInt($"PRCHSs{j}") != 0);
            /*if (prchs[j].purchase == true)
            {
                pnlCntr.shopPanels[j].SetActive(true);
            }*/
        }
        for (int k = 0; k < makes.Length; k++)
        {
            makes[k].make = (PlayerPrefs.GetInt($"MAKEs{k}") != 0);
            if (prchs[k].purchase == true)
            {
                pnlCntr.Make(k);
                //pnlCntr.cookies[k].SetActive(true);
                //pnlCntr.studioPanels[k + 1].SetActive(true);
            }
        }
        Debug.Log("loadend");
    }
}
