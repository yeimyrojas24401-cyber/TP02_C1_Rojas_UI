using UnityEngine;

public class Movement : MonoBehaviour
// the purpose of this class is to handle the movement of the player character through the keyboard input
{
    [SerializeField] private float moveSpeed = 1f; // The speed at which the player moves
    [SerializeField] private KeyCode moveUp = KeyCode.W; // The key to move the player up
    [SerializeField] private KeyCode moveRight = KeyCode.D; // The key to move the player right
    [SerializeField] private KeyCode moveDown = KeyCode.S; // The key to move the player down
    [SerializeField] private KeyCode moveLeft = KeyCode.A; // The key to move the player left

    private void Update()
    {
        if (Input.GetKey(moveUp))
        {
            // Move the player forward
            transform.position += new Vector3(0, moveSpeed * Time.deltaTime);
        }
        if (Input.GetKey(moveRight))
        {             // Move the player right
            transform.position += new Vector3(moveSpeed * Time.deltaTime, 0);
        }
        if (Input.GetKey(moveDown))
        {
            transform.position += new Vector3(0, -moveSpeed * Time.deltaTime);
        }
        if (Input.GetKey(moveLeft))
        {
            transform.position += new Vector3(-moveSpeed * Time.deltaTime,0);
        }
    }
    
}
