using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScreenTouch : MonoBehaviour

{

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

        Debug.Log(mousePositionOnScreen);
    }
}
