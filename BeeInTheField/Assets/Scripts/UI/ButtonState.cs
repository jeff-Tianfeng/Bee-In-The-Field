using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class ButtonState : MonoBehaviour, IPointerDownHandler, IPointerUpHandler
{

    private float _speed = 20f;
    public Camera mainCamera;
    private bool isClick = false;

    public void OnPointerDown(PointerEventData eventData)
    {
        isClick = true;
    }


    public void OnPointerUp(PointerEventData eventData)
    {
        isClick = false;
    }

    void Update()
    {
        if(mainCamera.transform.rotation.y >= -0.7f && mainCamera.transform.rotation.y <= 0.7f ){
            if(isClick == true){
                mainCamera.transform.Rotate(0, -0.99f * _speed * Time.deltaTime, 0, Space.Self);
            }
        }
    }

    
}
