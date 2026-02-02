using UnityEngine;

public class HareketManager : MonoBehaviour
{
    private Rigidbody rb;
    private Vector3 vektor = Vector3.zero;

    private void Awake()
    {
        rb = GetComponent<Rigidbody>();
        rb.freezeRotation = true;
        vektor.x = 5f;
    }

    private void Update()
    {
        rb.linearVelocity = vektor;
    }
}