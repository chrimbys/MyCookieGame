using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    [SerializeField]
    GameObject toppanel;
    [SerializeField]
    GameObject shoppanel;
    [SerializeField]
    GameObject studiopanel;

    // Start is called before the first frame update
    void Start()
    {
        toppanel.SetActive(true);
        shoppanel.SetActive(false);
        studiopanel.SetActive(false);

    }

    public void OnclickTopButton()
    {
        Start();
    }

    public void OnclickShopButton()
    {
        shoppanel.SetActive(true);
        studiopanel.SetActive(false);

    }
    public void OnclickStudioButton()
    {
        shoppanel.SetActive(false);
        studiopanel.SetActive(true);

    }


}
