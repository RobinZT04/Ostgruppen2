using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Paus : MonoBehaviour
{
    public GameObject options;
    public bool paused;
    // Update is called once per frame
    void Update()
    {
        //Pausar spelet när man klickar på escape. -William
        if (Input.GetKeyDown(KeyCode.Escape) && !paused)
        {
            options.SetActive(true);
            Time.timeScale = 0;
            paused = true;
        }
        //Ifall spelet redan är pausat så startas spelet igen när man klickar på escape. -William
        else if (Input.GetKeyDown(KeyCode.Escape) && paused)
        {
            options.SetActive(false);
            Time.timeScale = 1;
            paused = false;
        }
    }
    //Startar spelet igen. -William
    public void Unpause()
    {
        options.SetActive(false);
        Time.timeScale = 1;
    }
    //Ändrar scenen till menyscenen. -William
    public void Quit()
    {
        SceneManager.LoadScene("Menu");
    }
}
