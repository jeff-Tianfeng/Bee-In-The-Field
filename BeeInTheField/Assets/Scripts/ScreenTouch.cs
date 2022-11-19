using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.EventSystems;

public class ScreenTouch : MonoBehaviour

{

    public BeeController beeController;

    Vector3 mousePositionOnScreen;//moust position
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        //get the moust position
        mousePositionOnScreen = Input.mousePosition;
        if (Input.GetMouseButtonDown(0))
        {
            print("Object Position: "+beeController.returnScreenPosition() + "Mouse Position: " + mousePositionOnScreen);
        }
    }


}
