using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TutorialTextController : MonoBehaviour
{
    //[SerializeField]
    //GameObject panel; //テキスト表示パネル
    [SerializeField]
    string[] tutorialTexts;
    [SerializeField]
    Text textBox;
    [SerializeField]
    GameObject nextButton; //次ボタン
    [SerializeField]
    GameObject maskTop;
    [SerializeField]
    GameObject maskShop;
    [SerializeField]
    GameObject maskStudio;
    [SerializeField]
    GameObject TBPanel;//チュートリアル中不要なボタンを押せなくする
    [SerializeField]
    GameObject TBPanels;//上のパネルの小さいバージョン

    //tutorialTextsの配列番号、開始番号
    int i = 0;

    public bool flag;
    [SerializeField]
    TextController textController;

    void Start()
    {
        TBPanel.SetActive(true);
        StartCoroutine(DisplaySentence());
    }

    void Update()
    {
        if (textBox.text == tutorialTexts[i]) //文章が完成したら、ボタンを表示
        {
            nextButton.SetActive(true);
            //Debug.Log(i + "完了");
            /*if (i == (mainStories.Length - 1)) //さらに最後の文章ならボタン非表示
            {
                nextButton.SetActive(false);
            }*/

        }
        else
        {
            nextButton.SetActive(false);
            //Debug.Log(i + "完了してない");
        }
    }

    // テキストを更新する
    IEnumerator DisplaySentence()
    {
        if (i == 2 || i == 3 || i == 5)
        {
            yield return new WaitUntil(() => flag == true);
            //Debug.Log("続行");
            TBPanel.SetActive(true);
            TBPanels.SetActive(false);
            flag = false;
        }
        foreach (char x in tutorialTexts[i].ToCharArray()) //～.ToCharArray()はテキスト1文字ずつの配列
        {
            textBox.text += x; //1文字追加
            yield return new WaitForSeconds(0.1f); //0.1秒間隔
        }

    }
    //材料を買う、クッキーを作る、TOPボタンを押したタイミングで実行
    public void TutorialFlag()
    {
        flag = true;
        //Debug.Log(flag);
    }
    public void OnClickNext()
    {
        if (i < tutorialTexts.Length -1) //最後の文章でないなら
        {
            i++;
            textBox.text = ""; //現在の文章を白紙に
            if (i == 2)
            {
                maskShop.SetActive(true);
                TBPanel.SetActive(false);
            }
            if (i == 3)
            {
                maskStudio.SetActive(true);
                TBPanel.SetActive(false);
            }
            if (i == 5)
            {
                maskTop.SetActive(true);
                TBPanel.SetActive(false);
            }
            StartCoroutine(DisplaySentence()); //次の文字送り開始
        }
        else if(i == tutorialTexts.Length - 1)
        {
            textController.flag0 = 1;
            TBPanel.SetActive(false);
            Destroy(this.gameObject);//終了後は削除
        }
    }
    public void MaskTop()
    {
        Destroy(maskTop);
        TBPanels.SetActive(true);
    }
    public void MaskShop()
    {
        Destroy(maskShop);
        TBPanels.SetActive(true);
    }
    public void MaskStudio()
    {
        Destroy(maskStudio);
        TBPanels.SetActive(true);
    }
}