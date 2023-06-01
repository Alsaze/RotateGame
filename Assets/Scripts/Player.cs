using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] private GameObject open;

    [SerializeField] private GameObject player;
    [SerializeField] private GameObject teleport;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Win")
        {
            Debug.Log("You win!!");
        }

        if (collision.gameObject.tag == "Lose")
        {
            Debug.Log("You Lose!!");
        }

        if (collision.gameObject.tag == "Open")
        {
            Debug.Log("Open");
            Destroy(open);
        }

        if (collision.gameObject.tag == "Teleport")
        {
            Debug.Log("Teleport");
            Vector3 vector3Teleport = teleport.transform.position;
            player.transform.position = vector3Teleport;
        }
    }
}