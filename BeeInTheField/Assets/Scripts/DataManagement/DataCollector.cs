using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DataCollector : MonoBehaviour
{ 
    [SerializeField]
    public InstructionController instructionController;
    [SerializeField]
    public MainMenuController mainMenuController;
    public ScreenTouch screenTouch;
    private string NickName;
    private string Age;
    private bool[] deviation;
    private int score;
    private int clickTime;
    // Start is called before the first frame update
    void Start()
    {
    
    }

    // Update is called once per frame
    void Update()
    { 
        if(screenTouch != null)
        {
            clickTime = screenTouch.returnClickTime();
            deviation = screenTouch.returnDeviation();
        }
        score = ScreenTouch.returnScore();
    }

    public void record(){
        PlayerPrefs.SetString("NickName", mainMenuController.returnName());
        PlayerPrefs.SetString("Age", mainMenuController.retrunAge());
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

    public int returnClickTime(){
        return clickTime;
    }

    public int returnScore(){
        return score;
    }
}
