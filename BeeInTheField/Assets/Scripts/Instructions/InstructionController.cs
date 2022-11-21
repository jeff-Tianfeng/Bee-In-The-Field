using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class InstructionController : MonoBehaviour
{
    private string player = "";
    public InputField name;

    public void LoadGameScene(){
        player = name.text;
        print(player);
        SceneManager.LoadScene(1);
    }

}
