using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Startdialog : MonoBehaviour
{
    public int intruduktion = 4; // En int som har värdet 4 - Elanor 
    public GameObject tankebubblan; //Refrens till ett gameobject- Elanor 
    public Text dialog; //En referens till min text - Elanor 

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space)) //Om man trycker ner space?- Elanor 
        {
            intruduktion -= 1; //När man trycke space kommer intruduktion minska med 1- Elanor 
        }
        switch (intruduktion) //En switch- Elanor 
        {
            case 4: // Case 4- Elanor
                dialog.text = "To move use W,A,S,D, press space for next thought"; //Säger till att min text ska skriva ut det jag har skrivt här - Elanor
                Movement.speed = -0; //Min movement speed blir 0 så playern kan inte gå- Elanor
                break; //Dialogen försvinner- Elanor 
            case 3:// Case 3 - Elanor
                dialog.text = "You also have a sword to use, press \n space, dont be afraid to use it! \n now lets see what this mouse is doing"; //Säger till att min text ska skriva ut det jag har skrivt här - Elanor
                break;//Dialogen försvinner- Elanor 
            case 2:// Case 2 - Elanor
                dialog.text = "What a nice sleep, whait where \n am I, hello is someone there?"; //Säger till att min text ska skriva ut det jag har skrivt här - Elanor
                break;//Dialogen försvinner- Elanor 
            case 1: // Case 1 - Elanor
                dialog.text = "seems like im all alone in this place, well \n lets explore I need to find a way out!"; //Säger till att min text ska skriva ut det jag har skrivt här - Elanor
                break;//Dialogen försvinner- Elanor 
            case 0: // Case 0 - Elanor
                Movement.speed = 1000; //Movement speed blir tillbaka till som vanligt- Elanor
                tankebubblan.SetActive(false); //Tanke bubblan blir inaktiv och försvinner- Elanor 
                break;//Dialogen försvinner- Elanor 
        }
    }
}
