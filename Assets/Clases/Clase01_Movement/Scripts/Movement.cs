using UnityEngine;

public class Movement : MonoBehaviour
// the purpose of this class is to handle the movement of the player character through the keyboard input
{
    private void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            // Move the player forward
            transform.position = new Vector3(0, 1);
        }
    }
    
}
