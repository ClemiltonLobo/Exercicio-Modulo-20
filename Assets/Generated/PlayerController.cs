using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class PlayerController : MonoBehaviour
{
    [Tooltip("The speed at which the player moves.")]
    public float moveSpeed = 10f;

    [Tooltip("The minimum x position the player can move to.")]
    public float minX = -5f;

    [Tooltip("The maximum x position the player can move to.")]
    public float maxX = 5f;

    [Tooltip("The force applied to the player when moving forward.")]
    public float forwardForce = 500f;

    private Rigidbody rb;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    private void FixedUpdate()
    {
        // Get the horizontal input axis
        float horizontalInput = Input.GetAxis("Horizontal");

        // Calculate the new position of the player
        Vector3 newPosition = transform.position + new Vector3(horizontalInput * moveSpeed * Time.deltaTime, 0f, 0f);

        // Clamp the new position to the limits of the screen
        newPosition.x = Mathf.Clamp(newPosition.x, minX, maxX);

        // Move the player to the new position
        transform.position = newPosition;

        // Apply forward force to the player
        rb.AddForce(transform.forward * forwardForce * Time.deltaTime);
    }
}