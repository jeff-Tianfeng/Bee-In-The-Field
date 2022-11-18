using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ViewRotate : MonoBehaviour
{
    private float _speed = 20f;
    public Camera mainCamera;
    public float sensitivetyKeyBoard = 0.1f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetAxis("Horizontal") != 0)
            {
                mainCamera.transform.Rotate(0, Input.GetAxis("Horizontal") * _speed * Time.deltaTime, 0, Space.Self);
            }
    }
}
