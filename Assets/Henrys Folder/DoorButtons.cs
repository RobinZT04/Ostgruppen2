using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorButtons : MonoBehaviour
{
    public Light buttonlight;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        buttonlight.enabled = true;
        /*if (true)
        {

        }*/
    }
}
