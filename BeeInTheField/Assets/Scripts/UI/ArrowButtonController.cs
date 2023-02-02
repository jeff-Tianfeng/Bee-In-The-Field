using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrowButtonController : MonoBehaviour
{

    private float _speed = 20f;
    public Camera mainCamera;

    private bool isClick = false;

    public void buttonRotate()
    {
        isClick = true;
    }


    void Update()
    {
        if(mainCamera.transform.rotation.y >= -0.7f && mainCamera.transform.rotation.y <= 0.7f ){
            if(isClick == true){
                mainCamera.transform.Rotate(0, Input.GetAxis("Horizontal") * _speed * Time.deltaTime, 0, Space.Self);
            }

            if(isClick == true){
                mainCamera.transform.Rotate(0, Input.GetAxis("Horizontal") * _speed * Time.deltaTime, 0, Space.Self);
            }

        }else if (mainCamera.transform.rotation.y < -0.7f){
            if(isClick == true){
                mainCamera.transform.Rotate(0, Input.GetAxis("Horizontal") * _speed * Time.deltaTime, 0, Space.Self);
            }
        }else if(mainCamera.transform.rotation.y > 0.7f){
            if(isClick == true){
                mainCamera.transform.Rotate(0, Input.GetAxis("Horizontal") * _speed * Time.deltaTime, 0, Space.Self);
            }
        }
    }
}
