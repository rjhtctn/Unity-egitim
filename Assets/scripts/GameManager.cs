using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Rendering.UI;

public class GameManager : MonoBehaviour
{
    // update fonksiyonu her karede bir kez çaðýrýlýr.
    private void Update()
    {
        Debug.Log("Update çalýþtý");      
    }

    // FixedUpdate sabit zaman aralýklarý ile çalýþýr. varsayýlan olarak her 0.02 saniyede çalýþýr.
    private void FixedUpdate()
    {
        Debug.Log("FixedUpdate çalýþtý");
    }

    // LateUpdate her karenin sonunda çalýþýr.
    // bu metod genellikle diðer objeler üzerindeki iþlemler tamamlandýktan sonra kullanýlýr.
    // kamera takip hareketleri
    // diðer objelerin güncellenmesini beklemek
    private void LateUpdate()
    {
        Debug.Log("LateUpdate çalýþtý");
    }
}