using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using System.IO;

public class Dörrar : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        //Laddar in scenen som tillhör dörren -William
        for (int i = 0; i < SceneManager.sceneCountInBuildSettings; i++)
        {
            string path = SceneUtility.GetScenePathByBuildIndex(i);
            string scene = Path.GetFileNameWithoutExtension(path);
            if (scene + "Dörr" == collision.name)
            {
                SceneManager.LoadScene(i);
            }
        } 
    }
}
