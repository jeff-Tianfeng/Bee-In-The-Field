using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ViewRotate : MonoBehaviour
{

    private float rotateIntensity = 0.2f;
    public Camera mainCamera;
    private bool onBorder = false;


    // Start is called before the first frame update
    void Start()
    {

    }

    private void LateUpdate()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if(mainCamera.transform.rotation.y > -0.75f && mainCamera.transform.rotation.y < 0.75f)
        {
            if (1 == Input.touchCount)
            {
                Touch touch = Input.GetTouch(0);
                Vector2 deltaPos = touch.deltaPosition;
                transform.Rotate(Vector3.down * deltaPos.x * rotateIntensity);//rotate around y axis.
            }
        }else if(mainCamera.transform.rotation.y < -0.75f)
        {
           mainCamera.transform.rotation = Quaternion.Euler(new Vector3(mainCamera.transform.rotation.x, -96f, mainCamera.transform.rotation.z));
        }else
        {
            mainCamera.transform.rotation = Quaternion.Euler(new Vector3(mainCamera.transform.rotation.x, 96f, mainCamera.transform.rotation.z));
        }
    }
}
