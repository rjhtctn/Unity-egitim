using UnityEngine;

public class HareketManager : MonoBehaviour
{
    private Rigidbody rb;
    private float force = 500f;

    private void Awake()
    {
        rb = GetComponent<Rigidbody>();
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            rb.AddForce(Vector3.up * force, ForceMode.Force); // f = m * a newton yasasý devamlý uygulanýr
            rb.AddForce(Vector3.up * force, ForceMode.Impulse); // anlýk kuvvet uygulanýr. hýzda ani bir deðiþiklik yapar 
            rb.AddForce(Vector3.up * force, ForceMode.VelocityChange); // kütleden baðýmsýz nesnenin hýzýný doðrudan deðiþtirir.
            rb.AddForce(Vector3.up * force, ForceMode.Acceleration); // kütleden baðýmsýz bir ivme uygulanýr
        }
    }
}