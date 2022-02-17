using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hitboxplayer : MonoBehaviour
{
    public bool cooldown;
    private void OnTriggerStay2D(Collider2D other)
    {
        if (other.transform.tag == "Enemy")
        {
            if (!cooldown)
            {
                PHealthbar.health -= 1;
                StartCoroutine(CoolDownHit());
            }
        }
    }
    IEnumerator CoolDownHit()
    {
        cooldown = true;
        yield return new WaitForSeconds(1);
        cooldown = false;
    }
}
