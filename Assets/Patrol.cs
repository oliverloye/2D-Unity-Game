using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Patrol : MonoBehaviour
{
    public float speed;
    public Transform[] moveSpots;
    private int randomSpots;

    void Start ()
    {
        randomSpots = Random.Range(0, moveSpots.Length);
    }

    void Update ()
    {
        transform.position = Vector2.MoveTowards(transform.position, moveSpots[randomSpots].position, speed * Time.deltaTime);
    }
}
