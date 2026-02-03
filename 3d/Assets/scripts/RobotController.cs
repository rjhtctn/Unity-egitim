using UnityEngine;

public class RobotController : MonoBehaviour
{
    private float moveSpeed = 5f;
    

    private void Update()
    {
        Vector3 move = Vector3.zero;

        if (Input.GetKey(KeyCode.UpArrow))
        {
            move += Vector3.forward;
        }

        if (Input.GetKey(KeyCode.DownArrow))
        {
            move += Vector3.back;
        }

        if (Input.GetKey(KeyCode.RightArrow))
        {
            move += Vector3.right;
        }

        if (Input.GetKey(KeyCode.LeftArrow))
        {
            move += Vector3.left;
        }

        transform.Translate(move * Time.deltaTime * moveSpeed);
    }
}