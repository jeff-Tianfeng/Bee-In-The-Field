using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BeeController : MonoBehaviour
{

    public GameObject obj;
    public GameObject audioSource;
    private Vector3 pos;
    private Vector3 posOnScreen;
    private GameObject instance;
    private GameObject audioInstance;
    private float Speed=0.5f;
    private bool isClicked = false;
    private bool isOnScreen = false;
    private Vector3 newPos = new Vector3(0,0,0);
    private Vector3 pos1 = new Vector3 (0,0,2.5f);
    private Vector3 pos2 = new Vector3 (1.77f,0,1.77f);
    private Vector3 pos3 = new Vector3 (-1.77f,0,1.77f);

    private Vector3 pos4 = new Vector3 (-2.5f,0,0);
    private Vector3 pos5 = new Vector3 (-1.77f,0,-1.5f);

    private Vector3 pos6 = new Vector3 (2.5f,0,0);
    private Vector3 pos7 = new Vector3 (1.77f,0,-1.5f);

    void Start()
    {   pos = generatePosition();
        audioInstance = (GameObject)Instantiate(audioSource, pos, transform.rotation); 
    }

    void Update()
    {
        posOnScreen = Camera.main.WorldToScreenPoint(pos);
        if(isClicked){
            if(isOnScreen == false){
                instance = (GameObject)Instantiate(obj, pos, transform.rotation);
                isOnScreen = true;
            } 
            instance.transform.localPosition = Vector3.MoveTowards(instance.transform.localPosition, newPos, Speed*Time.deltaTime);
            if(instance.transform.position == newPos){
                isClicked = false;
                destroyObject();
                generateNewObject();
            }
        }
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
        GameObject.Destroy(audioInstance);
        isOnScreen = false;
    }

    public void beePompUp(){
        newPos = new Vector3(pos.x, pos.y+2, pos.z);
        isClicked = true;

    }

    public void generateNewObject(){
        pos = generatePosition();
        audioInstance = (GameObject)Instantiate(audioSource, pos, transform.rotation);
    }
}
