using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LeftPaw : MonoBehaviour
{
    public Transform targetPlayer;
    public float speed;
    public float distance;

    public bool following;

    public void Start()
    {
        following = true;
        StartCoroutine(Attackera());
    }
    // Update is called once per frame
    void Update()
    {
        if (following)
        {
            if (Vector2.Distance(transform.position, targetPlayer.position) >= distance)
            {
                transform.position = Vector2.MoveTowards(transform.position, targetPlayer.position, speed * Time.deltaTime);
            }
        }
    }
    IEnumerator Attackera()
    {
        yield return new WaitForSeconds(Random.Range(1, 5));
    }
}
