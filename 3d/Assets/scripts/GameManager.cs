using System.Collections;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    IEnumerator RoutineENC()
    {
        for (int i = 0; i < 10; i++)
        {
            Debug.Log("Döngü adýmý: " + i);
            yield return new WaitForSeconds(1f); // her adýmda 1 saniye bekle
        }
    }

    IEnumerator SonsuzRoutine()
    {
        while (true)
        {
            Debug.Log("Sürekli çalýþýyor.");
            yield return new WaitForSeconds(1f);
        }
    }

    private void Start()
    {
        StartCoroutine(RoutineENC());
        StartCoroutine(SonsuzRoutine());
    }
}