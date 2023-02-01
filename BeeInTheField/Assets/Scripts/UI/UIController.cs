using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIController : MonoBehaviour
{
    public GameObject obj;
    private GameObject instance;
    private float t1;
    private float t2;
    private float gameTime = 120;
    private float intervaletime=1;
    private Text text;
    private Text time;
    private Text score;
    // Start is called before the first frame update
    void Start()
    {
        instance = (GameObject)Instantiate(obj);
        text = GameObject.Find("Canvas/Text").GetComponent<Text>();
        time = GameObject.Find("Canvas/Time").GetComponent<Text>(); 
        score = GameObject.Find("Canvas/Score").GetComponent<Text>();
        time.text = string.Format("{0:00}:{1:00}", (int)gameTime / 60, (float)gameTime % 60);
        score.text = "0";
        t1 = Time.fixedTime;
    }
    void Update()
    {
        TimeCountDown();
        score.text = ScreenTouch.returnScore().ToString();
        t2 = Time.fixedTime;
          if(t2 - t1 >=4)
        {
            text.text = "";
        }


    }

    private void TimeCountDown(){

        int M = (int)(gameTime / 60);
        float S = gameTime % 60;
            if (gameTime > 0)
            {
                intervaletime -= Time.deltaTime;
                if (intervaletime <= 0)
                {
                    intervaletime += 1;
                    gameTime--;
                    time.text = string.Format("{0:00}:{1:00}", M, S);

                }
            }
            if (gameTime <= 0)
            {
                gameTime = 6;
            }
        
    }

}
