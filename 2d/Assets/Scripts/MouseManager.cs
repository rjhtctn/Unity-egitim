using UnityEngine;

public class MouseManager : MonoBehaviour
{
    void Update()
    {
        // 0 = mouse sol
        // 1 = mouse sað
        // 2 = mouse scroll
        if (Input.GetMouseButtonDown(0))
        {
            Debug.Log("Mouse sol tuþ týklandý.");
        }

        if (Input.GetMouseButton(1))
        {
            Debug.Log("Sað tuþa basýlýyor.");
        }
    }
}