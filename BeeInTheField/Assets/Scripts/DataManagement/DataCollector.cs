using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DataCollector : MonoBehaviour
{
    public InstructionController instructionController;
    public ScreenTouch screenTouch;
    private string NickName;
    private string Age;
    private bool[] deviation;
    // Start is called before the first frame update
    void Start()
    {
    
    }

    // Update is called once per frame
    void Update()
    {
        deviation = screenTouch.returnDeviation();
    }

    public void record(){
        PlayerPrefs.SetString("NickName", instructionController.returnName());
        PlayerPrefs.SetString("Age", instructionController.retrunAge());
        //print(NickName + Age);
    }

    public string returnName(){
        return PlayerPrefs.GetString("NickName");
    }

    public string returnAge(){
        return PlayerPrefs.GetString("Age");
    }

    public bool[] returnDeviation(){
        return deviation;
    }
}
