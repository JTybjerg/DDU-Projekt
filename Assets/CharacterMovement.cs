using UnityEngine;

public class CharacterMovement : MonoBehaviour
{
    public float moveSpeed = 5f; // Adjust the movement speed as needed
    public float startX = -3.5f; // Starting X-coordinate
    public float endX = 2.5f; // Ending X-coordinate

    private bool movingRight = true;

    void Update()
    {
        MoveCharacter();
    }

    void MoveCharacter()
    {
        if (movingRight)
        {
            transform.Translate(Vector3.right * moveSpeed * Time.deltaTime);

            if (transform.position.x >= endX)
            {
                movingRight = false;
            }
        }
        else
        {
            transform.Translate(Vector3.left * moveSpeed * Time.deltaTime);

            if (transform.position.x <= startX)
            {
                movingRight = true;
            }
        }
    }
}