using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SvärdScript : MonoBehaviour
{
    public Transform player;
    public float x;
    public float y;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector2(player.transform.position.x + x, player.transform.position.y + y);
    }
}
