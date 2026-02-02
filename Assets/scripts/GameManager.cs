using UnityEngine;

public class GameManager : MonoBehaviour
{
    // play butonuna bastýðýmýzda ilk çalýþan fonksiyondur. bir kez çalýþýr
    private void Awake()
    {
        Debug.Log("awake çalýþtý.");
    }
    // awake'ten sonra çalýþýr. bir kez çalýþýr
    void Start()
    {
        print("start çalýþtý");
    }
}
