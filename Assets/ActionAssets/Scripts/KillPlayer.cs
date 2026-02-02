using System;
using UnityEngine;

public class KillPlayer : MonoBehaviour
{

    public GameObject player;
    public Lives livesScript;

    public Transform respawnPoint;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            player.transform.position = respawnPoint.position;

            if (livesScript != null)
            {
                livesScript.playerLostLife();
            }

            else
            {
                Debug.LogWarning("Lives Script Unassigned");
                
            }
        }
    }
}
