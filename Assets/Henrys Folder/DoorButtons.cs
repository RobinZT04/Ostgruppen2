using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorButtons : MonoBehaviour
{
    // Variabel för en vald mesh renderer -Henry
    public MeshRenderer rendererer;
    // Variable för en vald box collider -Henry
    public BoxCollider doorOne;

    //public Light buttonlight;

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
        // När man kolliderar med triggern blir både den valda mesh renderern och box collidern avstängda -Henry
        rendererer.enabled = false;
        doorOne.enabled = false;

        /*buttonlight.enabled = true;
        if (true)
        {

        }*/
    }
}
