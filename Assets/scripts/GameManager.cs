using UnityEngine;

public class GameManager : MonoBehaviour
{
    int gecenSure = 0;

    void ZamaniGuncelle()
    {
        gecenSure++;
        Debug.Log("Geçen zaman: " + gecenSure + " saniye.");
    }

    void ZamaniDurdur()
    {
        CancelInvoke("ZamaniGuncelle");
        Debug.Log("Sayaç durduruldu");
    }

    private void Start()
    {
        InvokeRepeating("ZamaniGuncelle", 1f,1f);
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            ZamaniDurdur();
        }
    }
}