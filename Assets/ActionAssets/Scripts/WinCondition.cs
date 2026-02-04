using System;
using UnityEngine;

public class WinCondition : MonoBehaviour
{

    [SerializeField] private WinMenu winMenu;
    
    private void OnTriggerEnter2D(Collider2D other) // when player collides with win condition, trigger game won
    {
        if (other.gameObject.CompareTag("Player")) 
        {
            Debug.Log("You win!"); // debug menu test
            winMenu.Win(); // run win menu
        }
    }
}
