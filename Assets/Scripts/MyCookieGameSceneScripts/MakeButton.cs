using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MakeButton : MonoBehaviour
{
    //クッキーの材料購入から製作までのBoolをカバーする
    //top画面のクッキーパネルを格納する
    [SerializeField]
    GameObject cookie;
    //cookieDataを受け取る
    [SerializeField]
    ShopButton shopButton;
    //CookiesData cookiesData;
    //CookieData内、purchase bool を受け取る
    bool purchase;
    //クッキーを作るボタン
    [SerializeField]
    Button button;
    //クッキーを作ったことを判定する
    bool make = false;

    // Update is called once per frame
    void Update()
    {
        if(make == false)
        {
            purchase = shopButton.purchase;
            if (purchase == true)
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
    public void Make()
    {
        cookie.SetActive(true);
        make = true;
    }
}
