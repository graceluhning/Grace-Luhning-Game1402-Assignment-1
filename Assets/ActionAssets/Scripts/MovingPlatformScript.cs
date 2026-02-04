using UnityEngine;

public class MovingPlatformScript : MonoBehaviour
{

    public Transform pointA;
    public Transform pointB;
    public float moveSpeed = 2f;

    private Vector3 nextPosition;

    void Start() // on start, move towards PointA
    {
        nextPosition = pointA.position;
    }
    
    void Update() // logic for movement between waypoints.
    {
        transform.position = Vector3.MoveTowards(transform.position, nextPosition, moveSpeed * Time.deltaTime);

        if (transform.position == nextPosition)
        {
            nextPosition = (nextPosition == pointA.position) ? pointB.position : pointA.position;
        }
        
    }

    private void OnCollisionEnter2D(Collision2D collision) // makes it so the player becomes a child of the platform and moves with it.
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            collision.gameObject.transform.parent = transform;
        }
    }
    
    private void OnCollisionExit2D(Collision2D collision) // removes player as child when they jump off.
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            collision.gameObject.transform.parent = null;
        }
    }
    
}
