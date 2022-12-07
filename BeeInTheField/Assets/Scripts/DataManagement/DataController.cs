using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using System.IO;

[Serializable]

public class PlayerPerformanceData
{
    public string NickName;
    public int Age;
    public float[] Deviation;
    public int Score;
}

public class DataController : MonoBehaviour
{
    string JsonPath; //json文件的路径
    PlayerPerformanceData playerPerformance;//要存起来的对象
    //PlayerPerformanceData dayrangeMessagetemp;//要读取出来的对象

    // Start is called before the first frame update
    void Start()
    {
        JsonPath = Application.streamingAssetsPath + "/JsonTest.json";
        InitJsonData();
        SaveJson();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

     void InitJsonData()
    {
        playerPerformance = new PlayerPerformanceData();
        playerPerformance.NickName = "Jeff";
        playerPerformance.Age = 20;
        playerPerformance.Score = 10;
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
