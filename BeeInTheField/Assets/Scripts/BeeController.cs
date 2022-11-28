using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BeeController : MonoBehaviour
{

    public GameObject obj;
    private Vector3 pos;
    private Vector3 posOnScreen;
    private GameObject instance;
    private Vector3 pos1 = new Vector3 (0,0,2.5f);
    private Vector3 pos2 = new Vector3 (1.77f,0,1.77f);
    private Vector3 pos3 = new Vector3 (-1.77f,0,1.77f);

    private Vector3 pos4 = new Vector3 (-2.5f,0,0);
    private Vector3 pos5 = new Vector3 (-1.77f,0,-1.5f);

    private Vector3 pos6 = new Vector3 (2.5f,0,0);
    private Vector3 pos7 = new Vector3 (1.77f,0,-1.5f);

    void Start()
    {

        instance = (GameObject)Instantiate(obj, generatePosition(), transform.rotation);
    }

    void Update()
    {
        posOnScreen = Camera.main.WorldToScreenPoint(pos);
    }
    
    ///<summary>Generate a random position on the boundary of a circle, 
    ///the center of the circle is the camera position(0,0,0)<summary>
    private Vector3 generatePosition(){
        int a = Random.Range(1, 7);
        Vector3[] poslist = new Vector3[7];
        poslist[0] = pos1; poslist[1] = pos2; poslist[2] = pos3; poslist[3] = pos4;
        poslist[4] = pos5; poslist[5] = pos6; poslist[6] = pos7;
        pos = poslist[a];
        return pos;
    }

    public Vector3 returnScreenPosition(){

        return posOnScreen;
    }

    public void destroyObject(){
        GameObject.Destroy(instance);
    }

    public void generateNewObject(){
        instance = (GameObject)Instantiate(obj, generatePosition(), transform.rotation);
    }
}
