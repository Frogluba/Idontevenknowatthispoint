using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Followenemy : MonoBehaviour
{
    public Transform player;
    public float attackDistance = 3;
    public float speed = 2;

    private void Update()
    {
        var distence = Vector3.Distance(transform.position, player.position);
        if (distence < attackDistance)
        {
            transform.position = Vector3.MoveTowards(transform.position, player.position, speed * Time.deltaTime);
        }
       
    }
}
