using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIController : MonoBehaviour
{
    public GameObject obj;
    private GameObject instance;
    private float t1;
    private float t2;
    // Start is called before the first frame update
    void Start()
    {
        instance = (GameObject)Instantiate(obj);
        t1 = Time.fixedTime;
    }
    void Update()
    {
        t2 = Time.fixedTime;//一直在变化的时间，2s,3s.....
          if(t2 -t1 >=2)
        {
           Destroy(this.instance);
        }
    }
}
