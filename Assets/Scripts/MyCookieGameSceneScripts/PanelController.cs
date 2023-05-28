using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PanelController : MonoBehaviour
{
    //ShopのPanel配列
    [SerializeField]
    GameObject[] shopPanels = new GameObject[20];
    //StudioのPanel配列
    [SerializeField]
    GameObject[] studioPanels = new GameObject[20];
    [SerializeField]
    GameObject[] cookies = new GameObject[20];

    // Start is called before the first frame update
    public void Make(int num)
    {
        cookies[num].SetActive(true);
        if(num < 19)
        {
            num++;
            Debug.Log("num=" + num);
            shopPanels[num].SetActive(true);
            Debug.Log("shoppanel=" + shopPanels[num]);
            studioPanels[num].SetActive(true);
            Debug.Log("studiopanel=" + studioPanels[num]);
        }
        else
        {
            Debug.Log("終了");
        }
    }
}
