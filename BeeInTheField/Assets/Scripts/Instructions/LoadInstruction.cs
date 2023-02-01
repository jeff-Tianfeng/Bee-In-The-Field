using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoadInstruction : MonoBehaviour
{
    public GameObject obj;
    private GameObject instance;
    // Start is called before the first frame update
    void Start()
    {
        instance = (GameObject)Instantiate(obj);
    }
}
