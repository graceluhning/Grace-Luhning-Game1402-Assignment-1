using UnityEngine;

public class Collectibles : MonoBehaviour
{
    [SerializeField] private int points = 1;
    public AudioSource audioSource;
    public AudioClip pickupSound;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player")) // only collect if player is the collider
        {
            AudioSource.PlayClipAtPoint(pickupSound, transform.position); // play sound
            Destroy(gameObject); // destroy collectible
            
            ScoreManager.Instance.AddPoints(points); // add points to Score
        }
    }
}

