using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextController : MonoBehaviour
{
    [SerializeField]
    GameObject panel; //テキスト表示パネル
    [SerializeField]
    GameObject tutorialPanel; //チュートリアル表示パネル
    [SerializeField]
    string[] mainStories;
    [SerializeField]
    Text textBox;
    [SerializeField]
    GameObject nextButton; //次ボタン
    [SerializeField]
    GameObject TBPanel; //ストーリー＆チュートリアル実行時不要なボタンを押せなくする
    //テキスト表示するフラグ
    public bool flag1, flag2, flag3, flag4;
    //1=クッキー制作5個, 2=クッキー制作10個, 3=クッキー制作15個, 4=クッキー制作20個
    //mainStoriesの配列番号、開始番号
    int i = 0;
    //mainStoriesの配列番号、終了番号
    int j = 5;
    //チュートリアル完了のフラグ、保存用にint型、0=false,1=true;
    public int flag0 = 0;

    void Start()
    {
        //Debug.Log("TxtCntrStart");
        if(flag0 == 1)
        {
            panel.SetActive(false);
            //Debug.Log("flag0=1");
        }
        else if(flag0 == 0)
        {
            TBPanel.SetActive(true);
            panel.SetActive(true);
            StartCoroutine(DisplaySentence());
            //Debug.Log("flag0=0");
        }
        //Debug.Log("TxtCntrend");
    }

    void Update()
    {
            if (textBox.text == mainStories[i]) //文章が完成したら、ボタンを表示
            {
                nextButton.SetActive(true);
                /*if (i == (mainStories.Length - 1)) //さらに最後の文章ならボタン非表示
                {
                    nextButton.SetActive(false);
                }*/

            }
            else
            {
                nextButton.SetActive(false);
            }
    }

    // テキストを更新する
    IEnumerator DisplaySentence()
    {
        //Debug.Log("coroutineStart");
        foreach (char x in mainStories[i].ToCharArray()) //～.ToCharArray()はテキスト1文字ずつの配列
        {
            textBox.text += x; //1文字追加
            yield return new WaitForSeconds(0.1f); //0.1秒間隔
        }
    }
    //クッキーを作るボタンを押したタイミングでそれぞれ実行
    public void Stories1()
    {
        textBox.text = "";
        panel.SetActive(true);
        i = 6;
        j = 9;
        TBPanel.SetActive(true);
        StartCoroutine(DisplaySentence());
    }
    public void Stories2()
    {
        textBox.text = "";
        panel.SetActive(true);
        i = 10;
        j = 14;
        TBPanel.SetActive(true);
        StartCoroutine(DisplaySentence());
    }
    public void Stories3()
    {
        textBox.text = "";
        panel.SetActive(true);
        i = 15;
        j = 18;
        TBPanel.SetActive(true);
        StartCoroutine(DisplaySentence());
    }
    public void Stories4()
    {
        textBox.text = "";
        panel.SetActive(true);
        i = 19;
        j = 24;
        TBPanel.SetActive(true);
        StartCoroutine(DisplaySentence());
    }
    public void OnClickNext()
    {
        if (i < j) //最後の文章でないなら
        {
            i++;
            textBox.text = ""; //現在の文章を白紙に
            StartCoroutine(DisplaySentence()); //次の文字送り開始
        }
        else if (i == 5)
        {
            Invoke("StartTutorial", 2.0f);
            panel.SetActive(false);//終了後は非表示
            TBPanel.SetActive(false);
        }
        else if (i == j)
        {
            panel.SetActive(false);//終了後は非表示
            TBPanel.SetActive(false);
        }
    }
    public void StartTutorial()
    {
        tutorialPanel.SetActive(true);//チュートリアル開始
    }
}