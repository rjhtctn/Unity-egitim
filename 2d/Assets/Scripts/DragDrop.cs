using UnityEngine;

public class DragDrop : MonoBehaviour
{
    Camera mainCamera;
    bool isClicked = false;
    Vector3 offset;
    void Start()
    {
        mainCamera = Camera.main;
    }

    private void OnMouseDown()
    {
        isClicked = true;

        Vector3 mousePosition = mainCamera.ScreenToWorldPoint(Input.mousePosition);
        offset = transform.position - mousePosition;
    }

    private void OnMouseDrag()
    {
        if (isClicked == true)
        {
            Vector3 mousePosition = mainCamera.ScreenToWorldPoint(Input.mousePosition);
            transform.position = mousePosition + offset;
        }
    }

    private void OnMouseUp()
    {
        isClicked = false;
    }
}