using UnityEngine;

public class HareketManager : MonoBehaviour
{
    private Transform[] hedef;
    private float hiz = 5f;
    private int index = 0;

    private void Start()
    {
        GameObject[] objs = GameObject.FindGameObjectsWithTag("hedef");

        if (objs.Length == 0)
        {
            Debug.Log("hedef bulunamadý!");
            return;
        }

        Debug.Log(objs.Length);

        System.Array.Sort(objs, (a, b) => string.Compare(a.name, b.name));

        hedef = new Transform[objs.Length];

        for(int i = 0; i < objs.Length; i++)
        {
            hedef[i] = objs[i].transform;
        }
    }

    private void Update()
    {
        if (index >= hedef.Length) return;

        if (index < hedef.Length)
        {
            transform.position =
                Vector3.MoveTowards(transform.position, hedef[index].position, hiz * Time.deltaTime);

            if (Vector3.Distance(transform.position, hedef[index].position) < 0.2f)
            {
                index++;
            }
        }
    }
}