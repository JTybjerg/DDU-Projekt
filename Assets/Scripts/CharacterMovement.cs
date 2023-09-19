
using UnityEditor.Experimental.GraphView;
using UnityEngine;

public class CharacterMovement : MonoBehaviour
{
    public float moveSpeed = 5f; // Adjust the movement speed as needed
    public float startX = -3f; // Starting X-coordinate
    public float endX = 2.5f; // Ending X-coordinate

    private bool movingRight = true;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            movingRight = false;
        }
        else if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            movingRight = true;
        }

        MoveCharacter();
    }

    void MoveCharacter()
    {
        float moveDistance = moveSpeed * Time.deltaTime;

        if (movingRight)
        {
            if (transform.position.x < endX)
            {
                transform.Translate(Vector3.right * moveDistance);
            }
            else
            {
                transform.position = new Vector3(endX, transform.position.y, transform.position.z);
            }
        }
        else
        {
            if (transform.position.x > startX)
            {
                transform.Translate(Vector3.left * moveDistance);
            }
            else
            {
                transform.position = new Vector3(startX, transform.position.y, transform.position.z);
            }
        }
    }
}