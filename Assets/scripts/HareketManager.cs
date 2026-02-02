using UnityEngine;

public class HareketManager : MonoBehaviour
{
    public float hareketHizi = 5f;

    // Time.deltaTime = 1 / fps
    void Update()
    {
        // transform.position += new Vector3(1, 0, 0) * Time.deltaTime * hareketHizi;
        transform.position += Vector3.right * hareketHizi * Time.deltaTime;
    }
}