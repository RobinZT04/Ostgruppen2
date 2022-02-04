using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Audio;

public class ButtonScriptMeny : MonoBehaviour
{
    public bool active;
    public Animator optiontab;
    public bool animating;

    public AudioMixer Mastervolume;
    public void Start()
    {
        animating = false;
        active = false;
    }
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

    public void Options()
    {
        if (!animating)
        {
            if (!active)
            {
                optiontab.SetBool("Up", true);
                optiontab.SetBool("Down", false);
                animating = true;
                StartCoroutine(Animating());
                active = true;
            }
            else
            {
                optiontab.SetBool("Down", true);
                optiontab.SetBool("Up", false);
                animating = true;
                StartCoroutine(Animating());
                active = false;
            }
        }
    }

    IEnumerator Animating()
    {
        yield return new WaitForSeconds(2);
        animating = false;
    }

    public void SetFullscreen(bool isFullscreen)
    {
        Screen.fullScreen = isFullscreen;
    }
    public void SetQuality(int qualityIndex)
    {
        QualitySettings.SetQualityLevel(qualityIndex);
    }
    public void SetVolume(float mastervolume)
    {
        Mastervolume.SetFloat("MasterSliderVolume", mastervolume);
    }


}
