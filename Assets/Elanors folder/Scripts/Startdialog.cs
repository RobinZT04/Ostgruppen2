using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Startdialog : MonoBehaviour
{
    public int intruduktion = 4;
    public GameObject tankebubblan;
    public Text dialog;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            intruduktion -= 1;
        }
        switch (intruduktion)
        {
            case 4:
                dialog.text = "bajs";
                Movement.speed = -0;
                break;
            case 3:
                dialog.text = "Leess goo baby";
                break;
            case 2:
                dialog.text = "Lee go baby";
                break;
            case 1:
                dialog.text = "Les oo bb";
                break;
            case 0:
                Movement.speed = 1000;
                tankebubblan.SetActive(false);
                break;
        }
    }
}
