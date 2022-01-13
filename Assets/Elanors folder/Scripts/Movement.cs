using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public Rigidbody2D body; // En rigedbody som heter body- Elanor
    public float speed = 50; // En float som heter speed, speeden är nu 50 men kan ändras i unity eller här- Elanor

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        float vert = Input.GetAxis("Vertical"); //
        float horiz = Input.GetAxis("Horizontal"); //

        body.velocity = new Vector2(horiz * speed * Time.deltaTime, vert * speed * Time.deltaTime);
      
        if (Input.GetKeyDown(KeyCode.A)) //Om man trycker ner A?
        {
            transform.localEulerAngles = new Vector2(0, 180); //Så kommer Spriten spegelvändas- Elanor
        }
        if (Input.GetKeyDown(KeyCode.D)) //Om man trycker ner D?
        {
            transform.localEulerAngles = new Vector2(0, -0);//Så kommer Spriten vändas tillbaka till höger- Elanor
        }
    }

}
