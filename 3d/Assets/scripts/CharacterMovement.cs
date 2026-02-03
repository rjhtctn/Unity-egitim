using UnityEngine;

public class CharacterMovement : MonoBehaviour
{
    Vector3 movement;
    private float speed = 5f;
    void Update()
    {
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");
        
        movement = new Vector3(horizontalInput, 0, verticalInput);

        transform.Translate(movement * speed * Time.deltaTime);
    }
}