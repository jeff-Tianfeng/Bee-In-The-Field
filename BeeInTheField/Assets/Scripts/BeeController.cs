using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BeeController : MonoBehaviour
{

    public GameObject obj;

    // Start is called before the first frame update
    void Start()
    {

        GameObject instance = (GameObject)Instantiate(obj, generatePosition(), transform.rotation);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private Vector3 generatePosition(){
        Vector3 pos = transform.position;
        pos.z = Random.Range(4.27f, -1.3f);
        //pos.z指的是在z轴给的数值内生成位置
        //Range后的数值是生成的z轴数值的范围
        return pos;
    }
}
