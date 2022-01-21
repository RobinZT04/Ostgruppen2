using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonScriptMeny : MonoBehaviour
{
public void StartGame() //StartGame - Elanor och robin
    {
        SceneManager.LoadScene("Labyrint");
    }
    public void QuitGame() //Quit game - Elanor och Robin
    {
        Application.Quit();
        Debug.Log("Quit");
    }
    public void Fullscreenmode() //Fullscreen - Robin
    {
            Screen.fullScreen = Screen.fullScreen;
        Debug.Log("Fullscreen");
    }

}
