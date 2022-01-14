using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PawStomp : MonoBehaviour
{
    public Transform indicator; //kordinaterna till indicatorn

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector2(indicator.transform.position.x, indicator.transform.position.y + 3); //sätt handen till indikatorns position + 3;
    }

    IEnumerator Attacking() //coroutine Attacking
    {
        transform.position = new Vector2(indicator.transform.position.x, indicator.transform.position.y - 0.25f);
        yield return new WaitForSeconds(2); //väntar i 2 sekunder
    }
}
