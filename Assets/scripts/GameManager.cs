using Unity.VisualScripting;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject[] enemies;

    //nesne aktif olduðu zaman çalýþýr
    private void OnEnable()
    {
        Debug.Log("Nesne aktif oldu");
    }

    // nesne deaktif olduðu zaman çalýþýr
    private void OnDisable()
    {
        Debug.Log("nesne devre dýþý býrakýldý");

        foreach (var enemy in enemies) 
        {
            Debug.Log(enemy.name);    
        }
    }
}
