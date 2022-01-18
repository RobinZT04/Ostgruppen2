using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorButtons : MonoBehaviour
{
    // Variabel för en vald mesh renderer och box collider -Henry
    public MeshRenderer rendererer;
    public BoxCollider doorOne;

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
    }
}