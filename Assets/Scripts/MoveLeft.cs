using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveLeft : MonoBehaviour
{
    private float speed = 20;
    private float leftBound = -15;
    private PlayerController playerController;

    private void Start()
    {
        playerController = GameObject.Find("Player").GetComponent<PlayerController>();
    }

    // Update is called once per frame
    void Update()
    {
        if (!playerController.gameOver) {
            transform.Translate(speed * Time.deltaTime * Vector3.left);
        }

        if (gameObject.CompareTag("Obstacle") && transform.position.x < leftBound) {
            Destroy(gameObject);
        }
    }
}
