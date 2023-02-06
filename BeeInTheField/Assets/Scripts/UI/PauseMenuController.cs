using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenuController : MonoBehaviour
{
    private bool isPause = false;
    private Canvas canvas;
    // Start is called before the first frame update
    /// <summary>
    /// When pausing the game we expect the cursor to change to a confined state.
    /// And when unpausing we expect it to return to the previous state.
    /// </summary>
    private static CursorLockMode cachedLockState;
    void Start()
    {

        canvas = GetComponent<Canvas>();
        Unpause();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Escape)){
            if(isPause == false){
                Pause();
            }else{
                Unpause();
            }

        }
    }

    private void Pause()
    {
        isPause = true;

        Time.timeScale = 0;
        cachedLockState = Cursor.lockState;
        Cursor.lockState = CursorLockMode.Confined;
        canvas.enabled = true;
        AudioListener.pause = true;
    }

    private void Unpause()
    {
        isPause = false;

        Time.timeScale = 1;
        Cursor.lockState = cachedLockState;
        canvas.enabled = false;
        AudioListener.pause = false;
    }

    public void continueGame()
    {
        Unpause();
    }

    public void exit()
    {
        UnityEditor.EditorApplication.isPlaying = false;
        Application.Quit();
    }

    public void restart()
    {
        SceneManager.LoadScene (0);
    }
}
