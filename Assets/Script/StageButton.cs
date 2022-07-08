using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StageButton : MonoBehaviour
{
    // Start is called before the first frame update

    
    
    public int stagenum;


    void Start()
    {
    
        if (SentralManager.CreaStage[stagenum-1]==true)
        {
            this.gameObject.SetActive(true);
        }
        else { this.gameObject.SetActive(false); }






    }

    // Update is called once per frame
    void Update()
    {
        













    }
}
