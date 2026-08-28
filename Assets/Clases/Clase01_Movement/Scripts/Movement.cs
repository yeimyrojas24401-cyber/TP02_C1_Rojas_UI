using UnityEngine;

public class Movement : MonoBehaviour
// the purpose of this class is to handle the movement of the player character through the keyboard input
{
    [SerializeField] private float moveSpeed = 1f; // The speed at which the player moves
    private void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            // Move the player forward
            transform.position += new Vector3(0, moveSpeed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.D))
        {             // Move the player right
            transform.position += new Vector3(moveSpeed * Time.deltaTime, 0);
        }
        if (Input.GetKey(KeyCode.S))
        {
            transform.position += new Vector3(0, -moveSpeed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.A))
        {
            transform.position += new Vector3(-moveSpeed * Time.deltaTime,0);
        }
    }
    
}
