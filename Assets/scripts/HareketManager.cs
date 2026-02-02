using UnityEngine;

public class HareketManager : MonoBehaviour
{
    public float hareketHizi = 5f;
    public Vector3 vektor = Vector3.zero;
    void Update()
    {
        vektor.x = 1f;
        transform.Translate(vektor * hareketHizi * Time.deltaTime);
    }
}