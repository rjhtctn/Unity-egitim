# 🎮 Unity Game Development Bootcamp: Sıfırdan Zirveye

![Unity Version](https://img.shields.io/badge/Unity-2022.3+-blue?logo=unity)
![Language](https://img.shields.io/badge/C%23-Language-green?logo=csharp)
![Platform](https://img.shields.io/badge/Platform-PC%20%7C%20Mobile%20%7C%20Web-orange)

Bu repository, Unity oyun motoru ve C# ile gerçekleştirilen kapsamlı oyun geliştirme eğitiminin tüm projelerini, kodlarını ve notlarını içermektedir. Eğitim süresince **20 ana bölüm** tamamlanmış ve **3 tam kapsamlı oyun** geliştirilmiştir.

---

## 📚 Eğitim Müfredatı ve Tamamlanan Bölümler

### 🟢 Temeller ve Fizik (Bölüm 1-7)
* **Arayüz:** Scene, Game, Hierarchy, Project ve Inspector pencerelerinin efektif kullanımı.
* **Lifecycle (Yaşam Döngüsü):** `Awake`, `Start`, `Update`, `FixedUpdate` ve `LateUpdate` arasındaki farklar.
* **Fizik Dünyası:** Rigidbody ve Collider komponentleri ile fiziksel etkileşimler.
* **Hareket Metotları:** `Transform.Translate`, `AddForce`, `Velocity`, `Lerp` ve `MoveTowards` yöntemleri.
* **Zamanlama:** `Coroutine` (IEnumerator) ve `Invoke` yapıları.



### 🟡 Giriş Sistemleri ve UI (Bölüm 8-10)
* **Input System:** Klasik ve New Input System ile klavye/mouse kontrolleri.
* **Görsel ve Işık:** Material, Texture, Post-Processing ve Işık türleri.
* **UI Tasarımı:** Canvas sistemi, TextMeshPro, Button ve ScrollView bileşenleri.

### 🟣 İleri Seviye Araçlar ve Veri (Bölüm 14-18)
* **Dünya Oluşturma:** TileMap (2D) ve Terrain (3D) ile çevre tasarımı.
* **Ses ve Kamera:** `AudioSource` yönetimi ve **Cinemachine** ile dinamik kamera sistemleri.
* **Efektler:** Particle System ile görsel efekt üretimi.
* **Veri Yönetimi:** `PlayerPrefs` ve `JSON` ile veri kaydetme/okuma işlemleri.

---

## 🚀 Geliştirilen Projeler

Eğitim boyunca teorik bilgilerin pratiğe döküldüğü 3 ana proje:

### 1. 3D Platform Oyunu
Geleneksel platform mekaniklerinin temellerini içeren, engel odaklı bir oyun.
* **Öne Çıkanlar:** Karakter hareketi, tag sistemi, can/puan mekaniği ve sahne geçişleri.

### 2. Resim Eşleştirme Oyunu
Hafıza ve sürükle-bırak mantığına dayalı 2D/3D hibrit çalışma.
* **Öne Çıkanlar:** `Drag & Drop` mekaniği, **DOTween** ile animasyonlar, Mixamo entegrasyonu ve Animator yönetimi.

### 3. Space Shooter (Uzay Savaşı)
Hızlı aksiyon ve sonsuz döngü mantığının kurgulandığı kapsamlı proje.
* **Öne Çıkanlar:** `Instantiate` ile mermi yönetimi, Object Spawner, Wave (Dalga) sistemi ve Infinite Scrolling arka plan.

---

## 🏁 Çıktı Alma (Build)
Eğitim sonunda projeler şu platformlar için optimize edilmiştir:
* 💻 **PC:** Standalone .exe çıktıları.
* 🌐 **Web:** WebGL tarayıcı tabanlı sürümler.
* 📱 **Mobil:** Android (APK) yapılandırmaları.

---

## 💻 Kurulum ve Test

Bu projeyi yerel bilgisayarınızda incelemek için şu adımları izleyin:

1. **Repoyu Klonlayın:**
   ```bash
   git clone [https://github.com/rjhtctn/Unity-egitim.git](https://github.com/rjhtctn/Unity-egitim.git)