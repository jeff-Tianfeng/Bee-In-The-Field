using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class ScreenTouch : MonoBehaviour

{

    public BeeController beeController;

    private Vector3 mousePositionOnScreen;//moust position

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //get the moust position
        mousePositionOnScreen = Input.mousePosition;
        if (Input.GetMouseButtonDown(0))//when left click the mouse.
        {
        
            beeController.destroyObject();
            beeController.generateNewObject();
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit rayhit;
            if (Physics.Raycast(ray, out rayhit))
            {   
                Debug.Log("Object Position: "+beeController.returnScreenPosition() + "Mouse Position: " + mousePositionOnScreen + rayhit.collider.gameObject.name);
            }else{
               Debug.Log("Object Position: "+beeController.returnScreenPosition() + "Mouse Position: " + mousePositionOnScreen + "Nothing");
            }
        }
    }


}
