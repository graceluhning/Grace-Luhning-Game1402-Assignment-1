using System;
using UnityEngine;

public class KillPlayer : MonoBehaviour
{

    public GameObject player;
    public Lives livesScript;

    public Transform respawnPoint;

    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Player")) // ensure "player" is the object colliding with the enemy
        {
            player.transform.position = respawnPoint.position; // Move player back to respawn point

            if (livesScript != null)
            {
                livesScript.playerLostLife(); // if there is a lives script, run lose life script
            }

            else
            {
                Debug.LogWarning("Lives Script Unassigned"); // debug for if no lives script assigned.
                
            }
        }
    }
}
