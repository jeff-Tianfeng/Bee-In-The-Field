using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BeeController : MonoBehaviour
{

    public GameObject obj;
    private Vector3 pos;
    public Vector3 posOnScreen;

    // Start is called before the first frame update
    void Start()
    {

        GameObject instance = (GameObject)Instantiate(obj, generatePosition(), transform.rotation);
    }

    // Update is called once per frame
    void Update()
    {
        posOnScreen = Camera.main.WorldToScreenPoint(pos);
    }

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
}
