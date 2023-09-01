using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float moveSpeed = 5f;

    void Update()
    {
        // Get input for movement
        float horizontalInput = Input.GetAxis("Horizontal");

        // Calculate movement direction
        Vector3 movement = new Vector3(horizontalInput, 0f);

        // Normalize diagonal movement
        if (movement.magnitude > 1f)
        {
            movement.Normalize();
        }

        // Move the player
        transform.Translate(movement * moveSpeed * Time.deltaTime);
    }
}
