using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Rendering.UI;

public class GameManager : MonoBehaviour
{
    // Invoke istediðimiz süre gecikmeden sonra fonksiyonu bir kez çaðýrýr.
    // Invoke("fonksiyon ismi", gecikme süresi);
    // InvokeRepeating belirli bir süre gecikmeden sonra bir fonksiyonu periyodik olarak çaðýrýr
    private float gecikmeSuresi;
    private float tekrarSuresi;
    void YazdirInvoke()
    {
        Debug.Log($"Bu Mesaj {gecikmeSuresi} saniye sonra görüntülenecek: Invoke");
    }

    void YazdirInvokeRepeating()
    {
        Debug.Log($"Bu Mesaj {tekrarSuresi} saniye aralýlarla tekrarlanacak: InvokeRepeating");
    }

    void iptalInvoke()
    {
        CancelInvoke("TekrarliYazdir");
    }

    private void Start()
    {
        gecikmeSuresi = 5.0f;
        Invoke("YazdirInvoke", gecikmeSuresi);
        tekrarSuresi = 3.0f;
        InvokeRepeating("YazdirInvokeRepeating", gecikmeSuresi, tekrarSuresi);
        iptalInvoke();
    }
}