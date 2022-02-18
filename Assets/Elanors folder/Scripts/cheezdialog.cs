using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
//Skriven av Elanor
public class cheezdialog : MonoBehaviour
{
    public static bool harsagt; //En bool med namnet harsagt-Elanor
    public Text cheeztext; //En text referens- Elanor
    public static bool ostharsagt; //En bool med namnet ostharsagt-Elanor
   


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (SceneManager.GetActiveScene().name == "Lamppussel" || SceneManager.GetActiveScene().name == "Knappussel" || SceneManager.GetActiveScene().name == "Spegelpussel") //är man i knappussel? Lampussel eller spegelpussel scenen labyrint? - Elanor
        {
            if (!harsagt) //Om harsagt inte har hänt?- Elanor
            {
                cheeztext.text = "What is this smell? it smells so good, I \n need to find out what it is!"; //Skriv ut det som står - Elanor 
                StartCoroutine(Textgone()); //Start på coroutin- Elanor
            }
        }

        if (OstbrickaScript.ostcounter == 1)
        {
            if (!ostharsagt)//Om ostharsagt inte har hänt?- Elanor
            {
                cheeztext.text = "Wooow I got cheez! \n It's my favorite thing, maybe \n there is more to find"; //Skriv ut det som står - Elanor 
                StartCoroutine(Cheestextgone()); //Start på coroutin- Elanor
            }
        

        }

    }
    IEnumerator Textgone()
    {
        yield return new WaitForSeconds(3); //Vänta 3 sekunder innan den försvinner- Elanor
        cheeztext.text = ""; //Texten försvinner- Elanor
        harsagt = true; //Har sagt blir true- Elanor
    }
    IEnumerator Cheestextgone()
    {
        yield return new WaitForSeconds(5); //Vänta 3 sekunder innan den försvinner- Elanor
        cheeztext.text = ""; //Texten försvinner- Elanor
        ostharsagt = true; //Har sagt blir true- Elanor
    }
}
