using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonLights : MonoBehaviour
{
    // Variabel för ett ljus -Henry
    GameObject buttonLight;

    // Start is called before the first frame update
    void Start()
    {
        // Hämtar ljuset som finns under knappen -Henry
        buttonLight = transform.GetChild(0).gameObject;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        // När man kolliderar med triggern sätts lampan på -Henry
        buttonLight.SetActive(true);
    }
}