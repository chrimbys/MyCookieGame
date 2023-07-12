using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MakeButton : MonoBehaviour
{
    //
    //top画面のクッキーパネルを格納する
    //[SerializeField]
    //GameObject cookie;
    //
    [SerializeField]
    ShopButton shopButton;
    //CookieData内、purchase bool を受け取る
    bool purchase;
    //クッキーを作るボタン
    [SerializeField]
    Button button;
    //クッキーを作ったことを判定する
    public bool make = false;

    SoundManager soundManager;
    void Start()
    {
        soundManager = GameObject.Find("SoundManager").GetComponent<SoundManager>();
    }
    void Update()
    {
        if(make == false)//クッキーを作っていない
        {
            purchase = shopButton.purchase;//shoppanelのボタン
            if (purchase == true)//材料購入した
            {
                button.interactable = true;//作るボタンを有効化
            }
            else
            {
                button.interactable = false;//材料を購入していない場合、無効化
            }
        }
        else
        {
            button.interactable = false;//クッキーを作った後は無効化
        }
    }

    //ボタンを押すと実行
    public void MakeBool()
    {
        soundManager.OnClickMakeButton();
        make = true;
        Debug.Log("make=" + make);
    }
}
