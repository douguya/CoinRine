using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{

    public int Scorea;//スコア
    
    public int nowrank;//全体の桁数
    public int Iank;//自分のけた
    
    public int PNScore1;       //指定した桁のスコア
    public int PNScore10;       //指定した桁のスコア
    public int PNScore100;       //指定した桁のスコア
    public int PNScore1000;       //指定した桁のスコア

    public Sprite[] ScoreSene;//数字の画像
    public GameObject [] num;//それぞれのけたのオブジェクト



    Image ScoreImage1;　　　//それぞれのけたのイメージ用
    Image ScoreImage10;
    Image ScoreImage100;
    Image ScoreImage1000;


  


    // Start is called before the first frame update
    void Start()
    {
        ScoreImage1 = num[0].GetComponent<Image>();　　//それぞれのけたのイメージ用とオブジェクトのイメージの紐づけ
        ScoreImage10 = num[1].GetComponent<Image>();
        ScoreImage100 = num[2].GetComponent<Image>();
        ScoreImage1000= num[3].GetComponent<Image>();


    }

    // Update is called once per frame
    void Update()
    {
        nowrank = 0;　　　　　　　　　　　　　　//桁数リセット
        while(Mathf.Pow(10, nowrank)<=Scorea) {//桁数カウント
            nowrank++;
        };


        PNScore1 = Scorea % 10;　　　　　　　　//それぞれのけたの数値の抽出
        PNScore10 = (Scorea % 100)/10;
        PNScore100 = (Scorea % 1000)/100;
        PNScore1000 = Scorea / 1000;

        ChengNum(PNScore1);　　　　　　　　　//それぞれの桁の数値の反映
        ChengNum10(PNScore10);
        ChengNum100(PNScore100);
        ChengNum1000(PNScore1000);






    }

      public void ChengNum(int nuu)//一の桁　何もないのでシンプル
    {
        ScoreImage1.sprite = ScoreSene[nuu];
    }

    public void ChengNum10(int nuu)//十の桁
    {

        if (nowrank <=1) { num[1].SetActive(false); }//桁数が一以下の時　消失
        else
        {
            num[1].SetActive(true);　　　　　　　　　//桁数が一より大きいとき
            ScoreImage10.sprite = ScoreSene[nuu];　　//十の桁の画像を引数の画像に差し替え
        }


    }
    public void ChengNum100(int nuu)
    {

        if (nowrank <= 2) { num[2].SetActive(false); }
        else
        {
            num[2].SetActive(true);
            ScoreImage100.sprite = ScoreSene[nuu];
        }


    }
    public void ChengNum1000(int nuu)
    {

        if (nowrank <= 3) { num[3].SetActive(false); }
        else
        {
            num[3].SetActive(true);
            ScoreImage1000.sprite = ScoreSene[nuu];
        }


    }


}
