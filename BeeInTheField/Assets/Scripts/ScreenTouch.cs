using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class ScreenTouch : MonoBehaviour

{

    public BeeController beeController;

    private int collectTime1 = 0;

    private Vector3 mousePositionOnScreen;//mouse position

    private static int score = 0;

    private int countInterval = 50;

    private bool[] DeviationSet = new bool[50];

    private int clickTime = 0;

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
            clickTime += 1;
            beeController.beePompUp();
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit rayhit;
            //check if game is pause, if pause then won't handle the click event.
            if(Time.timeScale == 1){
                if (Physics.Raycast(ray, out rayhit))
                {   
                    Debug.Log("Object Position: "+beeController.returnScreenPosition() + "Mouse Position: " + mousePositionOnScreen + rayhit.collider.gameObject.name);
                    DeviationSet[collectTime1] = true;
                    collectTime1 = collectTime1 + 1;
                    score = score + 1;
                }else{
                    Debug.Log("Object Position: "+beeController.returnScreenPosition() + "Mouse Position: " + mousePositionOnScreen + "Nothing");
                    DeviationSet[collectTime1] = false;
                    collectTime1 = collectTime1 + 1;
                }
            }
        }
    }

    public static int returnScore(){
        return score;
    }

    public bool[] returnDeviation(){
        return DeviationSet;
    }

    public int returnClickTime(){
        return clickTime;
    }
}
