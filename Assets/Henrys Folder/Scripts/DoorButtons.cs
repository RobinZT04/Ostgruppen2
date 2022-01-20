using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorButtons : MonoBehaviour
{
    // Variabel för en vald mesh renderer och box collider -Henry
    [SerializeField]
    MeshRenderer rendererer;
    [SerializeField]
    BoxCollider2D doors;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        // När man kolliderar med triggern blir både den valda mesh renderern och box collidern avstängda -Henry
        rendererer.enabled = true;
        doors.enabled = false;
    }
}