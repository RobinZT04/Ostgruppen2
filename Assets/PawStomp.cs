using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PawStomp : MonoBehaviour
{
    public Transform indicator;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector2(indicator.transform.position.x, indicator.transform.position.y + 3);
    }
}
