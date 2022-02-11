using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Audio;

public class ButtonScriptMeny : MonoBehaviour
{
    public bool active; //är den aktiv? - Robin
    public Animator optiontab; //refrens till animator optiontab - Robin
    public bool animating; //håller den på att animera? - Robin

    public AudioMixer Mastervolume; //refrens till audiomixer - Robin
    public void Start()
    {
        animating = false; //animating är false - Robin
        active = false; //active är false - Robin
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
        Screen.fullScreen = Screen.fullScreen; //sätter spelet till fullscreen - Robin
        Debug.Log("Fullscreen");
    }

    public void Options() //option funktion
    {
        if (!animating) //om den inte animeras
        {
            if (!active) //om den inte är aktiv
            {
                optiontab.SetBool("Up", true); //sätter animation boolen Up till true - Robin
                optiontab.SetBool("Down", false); //sätter animation boolen ned till false - Robin
                animating = true; //animating är true - Robin
                StartCoroutine(Animating()); //startar coroutinen animating - Robin
                active = true; //active är true - Robin
            }
            else //annars - Robin
            {
                optiontab.SetBool("Down", true); //sätter animation boolen Down till true - Robin
                optiontab.SetBool("Up", false); //sättter animation boolen till up
                animating = true; //animating är true - Robin
                StartCoroutine(Animating()); //startar coroutinen animating - Robin
                active = false; //sätter active till false - Robin
            }
        }
    }

    IEnumerator Animating() //coroutinen animating - Robin
    {
        yield return new WaitForSeconds(2); //vänta i 2 sekunder - Robin
        animating = false; //animating är false - Robin
    }

    public void SetFullscreen(bool isFullscreen) //sätter det till fullscreen - Robin
    {
        Screen.fullScreen = isFullscreen;
    }
    public void SetQuality(int qualityIndex) //Funktionen har en inbyggd int i sig som bestämmer vad kvaliteten är - Robin
    {
        QualitySettings.SetQualityLevel(qualityIndex); //sätter kvaliteten till qualityIndex nummret - Robin
    }
    public void SetVolume(float mastervolume) //funktionen har en inbyggd float i sig som bestämmer vad volymen är - Robin
    {
        Mastervolume.SetFloat("MasterSliderVolume", mastervolume); //ställer om volymen i audiomixern - Robin
    }


}
