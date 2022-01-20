using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Dörrar : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        //Vet inte om denna kod kommer funka men den skulle ta upp mindre plats och se bättre ut.
        //Om den inte funkar så kan man använda koden nedanför då jag vet att den funkar. -William
        for (int i = 0; i < SceneManager.sceneCount; i++)
        {
            Scene scene = SceneManager.GetSceneAt(i);
            if (scene.name + "Dörr" == collision.name)
            {
                SceneManager.LoadScene(i);
            }
        } 
        //if (collision.name == "LabyrintDörr")
        //{
        //    SceneManager.LoadScene("LabyrintScen");
        //}
        //if (collision.name == "LamppusselDörr")
        //{
        //    SceneManager.LoadScene("LamppusselScen");
        //}
        //if (collision.name == "KnappusselDörr")
        //{
        //    SceneManager.LoadScene("KnappusselScen");
        //}
        //if (collision.name == "SpegelpusselDörr")
        //{
        //    SceneManager.LoadScene("SpegelpusselScen");
        //}
    }
}
