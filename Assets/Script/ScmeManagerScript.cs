using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ScmeManagerScript : MonoBehaviour
{

    private int NowStageNum;
    const int ALLStageNum=12;
    public int no;

    public GameObject Pupup;
    public GameObject CreaPup;
    public GameObject nextButton;




    public  int getNowStageNum()
    {
        return NowStageNum;
    }
    
    // Start is called before the first frame update
    void Start()
    {



        for (int loop=0;loop<=ALLStageNum;loop++) {
            if (SceneManager.GetActiveScene().name == "Stage" +loop)
            {
                NowStageNum = loop;
            }
        }


    }

    // Update is called once per frame
    void Update()
    {
        no = NowStageNum;
    }









    public void TransitionToTitle()
    {
        SceneManager.LoadScene("Title");
    }

    public void TransitionToMain()
    {
        SceneManager.LoadScene("Main");
    }

    public void TransitionToStageSelect()
    {
        SceneManager.LoadScene("StageSelect");
    }

    public void TransitionToStageNum(int a)
    {
        if (SentralManager.CreaStage[a-1] == true) { 
        SceneManager.LoadScene("Stage" + a);
          }

    }


    public void TransitionToRestert()
    {
      
            SceneManager.LoadScene("Stage" + NowStageNum);
        

    }







    public void TransitionToNextStage()
    {
        SceneManager.LoadScene("Stage" +( NowStageNum+1));
    }

    public void TransitionTobeforeStage()
    {

        SceneManager.LoadScene("Stage" + (NowStageNum - 1));
    }

    public void Exsit()
    {

        Application.Quit();
      //  UnityEditor.EditorApplication.isPlaying = false;

    }









    public void PopuUpApper()
    {
       Pupup.SetActive(true);
    }

    public void PopuUpGein()
    {
        Pupup.SetActive(false);
    }

   

    public void PopuNext()
    {
        CreaPup.SetActive(true);


        if (NowStageNum==ALLStageNum) {
           nextButton.SetActive(false);
        }
       




        }



   
   




}
