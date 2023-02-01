using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlowerController : MonoBehaviour
{
    public GameObject obj;
    private GameObject FlowerFront1;
    private GameObject FlowerFront2;
    private GameObject FlowerFront3;
    private GameObject FlowerLeft1;
    private GameObject FlowerLeft2;
    private GameObject FlowerRight1;
    private GameObject FlowerRight2;
    private Vector3 pos1 = new Vector3 (0,0,2.5f);
    private Vector3 pos2 = new Vector3 (1.77f,0,1.77f);
    private Vector3 pos3 = new Vector3 (-1.77f,0,1.77f);

    private Vector3 pos4 = new Vector3 (-2.5f,0,0);
    private Vector3 pos5 = new Vector3 (-1.77f,0,-1.5f);

    private Vector3 pos6 = new Vector3 (2.5f,0,0);
    private Vector3 pos7 = new Vector3 (1.77f,0,-1.5f);

    // Start is called before the first frame update
    void Start()
    {
        FlowerFront1 = (GameObject)Instantiate(obj, pos1, transform.rotation);
        FlowerFront2 = (GameObject)Instantiate(obj, pos2, transform.rotation);
        FlowerFront3 = (GameObject)Instantiate(obj, pos3, transform.rotation);
        FlowerLeft1 = (GameObject)Instantiate(obj, pos4, transform.rotation);
        FlowerLeft2 = (GameObject)Instantiate(obj, pos5, transform.rotation);
        FlowerRight1 = (GameObject)Instantiate(obj, pos6, transform.rotation);
        FlowerRight2 = (GameObject)Instantiate(obj, pos7, transform.rotation);
    }
}
