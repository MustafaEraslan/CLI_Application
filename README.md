# CLI_Application

# MustafaEraslan
Mustafa Eraslan CLI Odevi

Merhabalar,

Alt bölümdeki gereklilikleri sağlayan bir CLI ugulamasını tamamlamış bulunuyorum.
İlk açılışta tc alır.
Eğer arrayde mevcuta tanımlıysa müşterinin ismi ekrana gelir, yoksa yeni müşteri kayıt ekranı gelir.(ad,soyad,gsm,vb.)
Satılacak ürün seçlir,adet seçilir.(hayal gücünüze göre rengi,indirimi falan seçilebilir.)
Kayıt alındı der ve siparişleri listeler.

Uygulama console ekranı ise şu şekilde;

Eğer kullanıcıdan girilen tc kimlik numarası 11 haneli değilse veya 0 rakamı ile başlıyorsa bu durumda tekrar denemeniz ve kaç hane girdiyseniz o console ekranında uyarı olarak basılıyor.

![image](https://user-images.githubusercontent.com/44713722/174433153-985351a0-7553-44a9-be03-a7c71831b2ae.png)

Diğer taraftan eğer Dictionary yapısıında bulunmayan bir tc girdiyseniz bu durumda kulancıyı kaydetmeniz için sizden ad, soyad, gsm bilgileri alınıyor ve başarılı bir şekilde kaydedildi mesajını console ekranına fırlatıyor. Ardından ürünleri listeliyor ve seçim yapmanız isteniyor. Daha sonrasında productcode bilgisi ile birlikte adet bilgisi de isteniliyor. Eğer ProductCode programın generate ettiği bir değer değilse tekrar denenemeniz isteniliyor. Eğer productCode doğru ise program bir sonraki aşamaya düşüyor ve stok bilgisini soruyor. Burada tekrar stok bilgisinde bir kontrol mevcut. Eğer stok bilgisi daha küçükse tekrar değer girilmesi isteniliyor.

![image](https://user-images.githubusercontent.com/44713722/174433085-5a155904-ab15-4335-9fb8-9cbf446541e9.png)

Eğer girilen tc sistemde mevcutsa ilk önce o numaraya ait isim yazdırılıyor ardından ürünler listeleniyor. Bir önceki adımdaki ürün detayları tekrarlanıyor.

![image](https://user-images.githubusercontent.com/44713722/174432454-98e71b0d-5362-422a-8eaf-d75334cea3bf.png)

O halde projeyi nasıl tamamladığımı, kullandığım metedoloji ve yöntemlerden bahsetmeye başlıyorum.

Projedeki tüm adımları görebilmek ve kullandığım yapıları seçebilmek için algoritmamımı belirledim.

Uygulama için herhangi bir database kullanılması istenilmemişti ve bende bu sebeple Dictionary yapısını tercih ettim. Dictionary yapısı ile kayıtlı memberları isim bilgileri ile beraber kayıt etmiş oldum. Araştırmalarımda validasyon'u kullanmanın önemli olduğunu kullanıcıdan istediğimi değeri alıp almadığımız sorularına yanıt bulabileceğimiz yapılar olduğunu görmüş oldum ve bende kullanmayı tercih ettim.

Diğer taraftan, ürünler için 32 karakterli unique bir değer generate ettim. Burada ürünlere kendim de değer verebilirdim fakat ilerleyen süreçlerde bu şekilde bir yapıyı kullanmanın önemli olduğunu düşündüğüm için projeme dahil etmeye karar verdim. Ek olarak personel, product ve order için tanımlamalarımı program.cs yerine ayrı bir sınıf açarak kullanmayı ve projemi daha görünür bir hale getirmeyi denedim. Nerelerde validasyon kullanmam gerektiğine karar verdim ve bu adımdan sonra kod yazmaya başladım ve projemi tamamlamış oldum.

Teşekkürler,
Sevgiler,





