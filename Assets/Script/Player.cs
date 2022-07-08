using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Player : MonoBehaviour
{


    public float jump;

    // Update is called once per frame

    Rigidbody2D rb;
    public float speed;

    public int nowJump = 1;
    public int Cost;

    public GameObject Coin;
    public GameObject SeneManager;
    GameObject AScore;
    Score ScoreaA;
    ScmeManagerScript ScmeManagerSt;
    public static bool StageCrea;

    
    float x;
    float y;
    




// Use this for initialization
void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        AScore = GameObject.Find("Score.en");
        SeneManager = GameObject.Find("SceneManager");
         ScmeManagerSt= SeneManager.GetComponent<ScmeManagerScript>();
        ScoreaA = AScore.GetComponent<Score>();
        StageCrea = false;

    }









    void Update()
    {


        x = this.transform.position.x;
        y = this.transform.position.y;

       if (ScoreaA.Scorea>=Cost)
       {
            if (nowJump == 0)
            {
                if (Input.GetKeyDown(KeyCode.Space))
                {
                    StageCrea = false;
                    rb.velocity = new Vector2(rb.velocity.x, jump * 0.75f);
                    Invoke("PutCoin", 0.18f);
                    ScoreaA.Scorea -= Cost;

                    nowJump++;

                }

            }

    }




        if (nowJump <= 0) {
            if (Input.GetKeyDown(KeyCode.W))
            {

                rb.velocity = new Vector2(rb.velocity.x, jump);

                nowJump++;
            }
        }
        if (Input.GetKey(KeyCode.D))
        {
            rb.velocity = new Vector2(speed, rb.velocity.y);
        }
        else if (Input.GetKey(KeyCode.A))
        {
            rb.velocity = new Vector2(-speed, rb.velocity.y);
        }
        else { rb.velocity = new Vector2(0, rb.velocity.y); }





    }

    void OnCollisionEnter2D(Collision2D other)//  地面に触れた時の処理
    {
        Debug.Log("aaa");
        if (other.gameObject.tag == "Ground")//  もしGroundというタグがついたオブジェクトに触れたら、
        {
            nowJump = 0;//  Groundedをtrueにする
        }
    }
    void OnTriggerEnter2D(Collider2D other)//  地面に触れた時の処理
    {
        Debug.Log("BBBB");
        if (other.gameObject.tag == "Ground")//  もしGroundというタグがついたオブジェクトに触れたら、
        {
            nowJump = 0;//  Groundedをtrueにする
        }
        if (other.gameObject.tag == "Goal")//  もしGroundというタグがついたオブジェクトに触れたら、
        {
            this.gameObject.SetActive(false);
            StageCrea = true;
            SentralManager.CreaStage[ScmeManagerSt.getNowStageNum()]=true;
            ScmeManagerSt.PopuNext();






        }



    }


    private void PutCoin(){


        Instantiate(Coin, new Vector2(x, y - 0.5f), Quaternion.identity);

    }










    // Update is called once per frame
    void FixedUpdate()
    {







    }









}
