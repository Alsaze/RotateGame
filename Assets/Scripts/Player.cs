using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Serialization;

public class Player : MonoBehaviour
{
    [SerializeField] private GameObject open;

    [SerializeField] private GameObject player;
    [SerializeField] private GameObject teleportOut;

    [SerializeField] private GameObject gameManager;
    private GameManager _gameManager;
    private void Start()
    {
        _gameManager = gameManager.GetComponent<GameManager>();
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Win")
        {
            _gameManager.Win();
        }

        else if (collision.gameObject.tag == "Lose")
        {
            _gameManager.Lose();
        }

        else if (collision.gameObject.tag == "Open")
        {
            Debug.Log("Open");
            Destroy(open);
        }

        else if (collision.gameObject.tag == "Teleport")
        {
            Debug.Log("Teleport");
            Vector3 teleportPosition = teleportOut.transform.position;
            player.transform.position = teleportPosition;
        }
    }
}