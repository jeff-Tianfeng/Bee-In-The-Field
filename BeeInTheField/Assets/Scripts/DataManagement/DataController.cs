using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using System.IO;

[Serializable]

public class PlayerPerformanceData
{
    public string NickName;
    public string Age;
    public bool[] Deviation;
    public int Score;
}

public class DataController : MonoBehaviour
{
    public DataCollector dataCollertor;
    private float t1;
    private float t2;
    string JsonPath; //json文件的路径
    PlayerPerformanceData playerPerformance;//要存起来的对象
    //PlayerPerformanceData dayrangeMessagetemp;//要读取出来的对象

    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
         t2 = Time.fixedTime;
          if(t2 - t1 >=4)
        {
            JsonPath = Application.streamingAssetsPath + "/JsonTest.json";
            InitJsonData();
            SaveJson();
        }
    }

     void InitJsonData()
    {
        playerPerformance = new PlayerPerformanceData();
        playerPerformance.NickName = dataCollertor.returnName();
        playerPerformance.Age = dataCollertor.returnAge();
        playerPerformance.Deviation = dataCollertor.returnDeviation();
    }

    public void SaveJson()
    {
        //如果本地没有对应的json 文件，重新创建
        string json = JsonUtility.ToJson(playerPerformance, true);
        using (StreamWriter sw = new StreamWriter(JsonPath)){
            sw.WriteLine(json);
            sw.Close();
            sw.Dispose();
        }
    }
}
