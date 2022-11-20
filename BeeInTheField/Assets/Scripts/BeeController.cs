using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BeeController : MonoBehaviour
{

    public GameObject obj;
    private Vector3 pos;
    private Vector3 posOnScreen;
    private GameObject instance;

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
        pos = transform.position;
        pos.x = Random.Range(-2,2);
        pos.y = Random.Range(1,1);
        float z = (float) System.Math.Sqrt((4-(pos.x)*(pos.x)));
        pos.z = z;
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
