using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Låda : MonoBehaviour
{
    public Sprite förstördLådaSprite;
    SpriteRenderer spriteRend;
    // Start is called before the first frame update
    void Start()
    {
        spriteRend = GetComponent<SpriteRenderer>();
    }
    //Ifall lådan blir attackerad så förstörs den. -William
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Sword")
        {
            spriteRend.sprite = förstördLådaSprite;
        }
    }
}
