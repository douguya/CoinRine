using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{

    public int Scorea;//�X�R�A
    
    public int nowrank;//�S�̂̌���
    public int Iank;//�����̂���
    
    public int PNScore1;       //�w�肵�����̃X�R�A
    public int PNScore10;       //�w�肵�����̃X�R�A
    public int PNScore100;       //�w�肵�����̃X�R�A
    public int PNScore1000;       //�w�肵�����̃X�R�A

    public Sprite[] ScoreSene;//�����̉摜
    public GameObject [] num;//���ꂼ��̂����̃I�u�W�F�N�g



    Image ScoreImage1;�@�@�@//���ꂼ��̂����̃C���[�W�p
    Image ScoreImage10;
    Image ScoreImage100;
    Image ScoreImage1000;


  


    // Start is called before the first frame update
    void Start()
    {
        ScoreImage1 = num[0].GetComponent<Image>();�@�@//���ꂼ��̂����̃C���[�W�p�ƃI�u�W�F�N�g�̃C���[�W�̕R�Â�
        ScoreImage10 = num[1].GetComponent<Image>();
        ScoreImage100 = num[2].GetComponent<Image>();
        ScoreImage1000= num[3].GetComponent<Image>();


    }

    // Update is called once per frame
    void Update()
    {
        nowrank = 0;�@�@�@�@�@�@�@�@�@�@�@�@�@�@//�������Z�b�g
        while(Mathf.Pow(10, nowrank)<=Scorea) {//�����J�E���g
            nowrank++;
        };


        PNScore1 = Scorea % 10;�@�@�@�@�@�@�@�@//���ꂼ��̂����̐��l�̒��o
        PNScore10 = (Scorea % 100)/10;
        PNScore100 = (Scorea % 1000)/100;
        PNScore1000 = Scorea / 1000;

        ChengNum(PNScore1);�@�@�@�@�@�@�@�@�@//���ꂼ��̌��̐��l�̔��f
        ChengNum10(PNScore10);
        ChengNum100(PNScore100);
        ChengNum1000(PNScore1000);






    }

      public void ChengNum(int nuu)//��̌��@�����Ȃ��̂ŃV���v��
    {
        ScoreImage1.sprite = ScoreSene[nuu];
    }

    public void ChengNum10(int nuu)//�\�̌�
    {

        if (nowrank <=1) { num[1].SetActive(false); }//��������ȉ��̎��@����
        else
        {
            num[1].SetActive(true);�@�@�@�@�@�@�@�@�@//����������傫���Ƃ�
            ScoreImage10.sprite = ScoreSene[nuu];�@�@//�\�̌��̉摜�������̉摜�ɍ����ւ�
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
