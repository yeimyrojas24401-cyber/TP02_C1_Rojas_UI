using UnityEngine;

public class Movement : MonoBehaviour
// the purpose of this class is to handle the movement of the player character through the keyboard input
{
    [Header("Speed Settings")] // Here we use header to make a title in the editor
    public float moveSpeed = 1f; // The speed at which the player moves

    [Header("Movement Settings")]
    [SerializeField] private KeyCode moveUp = KeyCode.W; // The key to move the player up
    [SerializeField] private KeyCode moveRight = KeyCode.D; // The key to move the player right
    [SerializeField] private KeyCode moveDown = KeyCode.S; // The key to move the player down
    [SerializeField] private KeyCode moveLeft = KeyCode.A; // The key to move the player left


    [Header("Rotation Settings")]
    [SerializeField] private KeyCode rotationRight = KeyCode.E; // The key to rotate the player right
    [SerializeField] private KeyCode rotationLeft = KeyCode.Q; // The key to rotate the player left
    [SerializeField] private float rotationAngle = 10; // here we define a variable for the speed of the rotation of the player so that we can change it in the inspector of the unity editor

    [Header("Color Settings")]
    [SerializeField] private KeyCode colorChange = KeyCode.R; 
    private SpriteRenderer spriteRenderer; // Reference to the SpriteRenderer component

    private void Awake()
    {
        spriteRenderer = GetComponent<SpriteRenderer>(); //here we call the components of the sprite
    }
    
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
        if (Input.GetKeyDown(rotationLeft))
        {
            // Rotate the player to the left
            transform.Rotate(Vector3.forward * rotationAngle);
        }
        if (Input.GetKeyDown(rotationRight))
        {
            // Rotate the player to the right
            transform.Rotate(Vector3.forward * -rotationAngle);
        }
        if (Input.GetKeyUp(colorChange))
        {
            // change the color of the sprite to a random color (R,G,B for each channel i put a random value)
            spriteRenderer.color = new Color(Random.value, Random.value, Random.value);
        }
    }
    
}
