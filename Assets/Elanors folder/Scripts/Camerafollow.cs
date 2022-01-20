using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camerafollow : MonoBehaviour
{
    public float followspeed = 2f; //En referens till en float- Elanor
    public Transform target; //En referens till en transform- Elanor 


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 newPos = new Vector3(target.position.x, target.position.y, -10f); //Den ska följa min targets position- Elanor 
        transform.position = Vector3.Slerp(transform.position, newPos, followspeed * Time.deltaTime); // Ändrar kamerans position till targets position- Elanor 
    }
}
