using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Movement : MonoBehaviour
{
    public Rigidbody2D body; // En rigedbody som heter body- Elanor
    public static float speed = 550; // En float som heter speed, speeden är nu 50 men kan ändras i unity eller här- Elanor
    public AudioSource asfotsteg; // Refrens till min audiosorce- Elanor 
    public AudioClip acsteg; //Referens till players audioclip- Elanor
    public static bool död; //En bool som är static- Elanor

    public Animator player; //En referens till min animator- Elanor 

    // Start is called before the first frame update
    void Start()
    {
        speed = 550; //movement speeden är 550 när man startar- Elanor 
    }

    // Update is called once per frame
    void Update()
    {
        if (!död) //Om musen inte är död?
        {


            if (body.velocity.magnitude > 0) //Om bodyns velcoitey är större än 0?- elanor 
            {
                player.SetBool("Walking", true); //Ska min bool bli true- Elanor 

            }
            else //Annars?
            {
                player.SetBool("Walking", false); ////min bool ska bli false- Elanor 
            }


            float vert = Input.GetAxis("Vertical"); // sätter float vert värdet till Input.GetAxis("Vertical")- Elanor 
            float horiz = Input.GetAxis("Horizontal"); // sätter float horiz värdet till Input.GetAxis("Horizontal")- Elanor

            body.velocity = new Vector2(horiz * speed * Time.deltaTime, vert * speed * Time.deltaTime); // Gör så att spelarn kan röra sig - Elanor

            asfotsteg.pitch = Random.Range(-0.5f, 2); //Audiosorces pitch kan ändras mellan -0.5 och 2- Elanor

            if (Input.GetKeyDown(KeyCode.A)) //Om man trycker ner A?
            {
                transform.localEulerAngles = new Vector2(0, 180); //Så kommer Spriten spegelvändas- Elanor
            }
            if (Input.GetKeyDown(KeyCode.D)) //Om man trycker ner D?
            {
                transform.localEulerAngles = new Vector2(0, 0);//Så kommer Spriten vändas tillbaka till höger- Elanor
            }

            if (Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.W)) //Om man trycker på D eller A eller S eller W?
            {
                if (!asfotsteg.isPlaying) //Om audiosorces inte spelas?
                {
                    asfotsteg.PlayOneShot(acsteg, 1); //spela Audioclip med volymen 1- Elanor
                }

            }
        }
    }
}
