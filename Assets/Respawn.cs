using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Respawn : MonoBehaviour
{
    public Vector2 spawnpointStart; //variabel till vector 2 för respawn - Robin och William
    public Vector2 spawnpoint1; //variabel till vector 2 för spawnpoint 1 - Robin och William
    public Vector2 spawnpoint2; //variabel till vector 2 för spawnpoint 2 - Robin och William
    public Vector2 spawnpoint3; //variabel till vector 2 för spawnpoint 3  - Robin och William

    public static Vector2 currentspawnpoint; //variabel till nuvarande spawnpointen  - Robin och William


    // Start is called before the first frame update
    void Start()
    {
        if (SceneManager.GetActiveScene().name == "Labyrint") //är nuvarande scenen labyrint? - Robin och William
        {
            transform.position = currentspawnpoint; //teleportera spelaren till current spawnpoint - Robin och William
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (SceneManager.GetActiveScene().name == "Labyrint") //är nuvarande scenen labyrint? - Robin och William
        {
            if (Vector2.Distance(transform.position, spawnpoint1) <= 2) //om du är nära spawnpoint  - Robin och William
            {
                currentspawnpoint = spawnpoint1; //sätt currentspawnpoint till spawnpoint1  - Robin och William
            }
            if (Vector2.Distance(transform.position, spawnpoint2) <= 2) //om du är nära spawnpoint  - Robin och William
            {
                currentspawnpoint = spawnpoint2; //sätt currentspawnpoint till spawnpoint2  - Robin och William
            }
            if (Vector2.Distance(transform.position, spawnpoint3) <= 2) //om du är nära spawnpoint  - Robin och William
            {
                currentspawnpoint = spawnpoint3; //sätt currentspawnpoint till spawnpoint3 - Robin och William
            }
            if (Vector2.Distance(transform.position, spawnpoint1) >= 2 && Vector2.Distance(transform.position, spawnpoint2) >= 2 && Vector2.Distance(transform.position, spawnpoint3) >= 2) //om du inte är nära någon av punkterna - Robin och William
            {
                currentspawnpoint = spawnpointStart; //sätt current spawnpint till spawnpoint start  - Robin och William
            }
        }
    }

}
