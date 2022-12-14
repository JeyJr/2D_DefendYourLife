using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamBehavior : MonoBehaviour
{
    [SerializeField] private Transform player;
    [SerializeField] private float smoothT, speed, y;
    Vector3 currentVelocity;

    private void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();
    }

    void Update()
    {
        Vector3 target = new Vector3(player.transform.position.x, player.transform.position.y + y, -10);
        transform.position = Vector3.SmoothDamp(transform.position, target, ref currentVelocity, smoothT, speed);
    }
}
