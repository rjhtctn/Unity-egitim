using UnityEngine;

public class HareketManager : MonoBehaviour
{
    // Vector3.Lerp(vector3 a, vector3 b, float t);
    // t 0 iken baþlangýç noktasýndadýr 1 olduðunda hedefe varýr.

    private Transform hedef;
    private float hiz = 2f;

    private void Start()
    {
        hedef = GameObject.FindWithTag("hedef").transform;
    }

    private void Update()
    {
        transform.position = Vector3.Lerp(transform.position, hedef.position, hiz * Time.deltaTime);
    }
}