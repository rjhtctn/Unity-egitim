using System.Collections;
using UnityEngine;

public class HareketManager : MonoBehaviour
{
    private Transform hedef;
    private float gidisSuresi = 2f;

    private void Start()
    {
        hedef = GameObject.FindWithTag("hedef").transform;
        StartCoroutine(HareketEtRoutine(hedef.position, gidisSuresi));
    }

    IEnumerator HareketEtRoutine(Vector3 hedefPos, float sure)
    {
        Vector3 baslangisPos = transform.position;
        float gecenSure = 0f;

        while (gecenSure <  sure)
        {
            transform.position = Vector3.Lerp(baslangisPos, hedefPos, gecenSure / sure);
            gecenSure += Time.deltaTime;

            yield return null; // bir sonraki frame e geçiþ
        }

        // hedef pozisyona tam olarak yerleþ
        transform.position = hedefPos;
    }
}