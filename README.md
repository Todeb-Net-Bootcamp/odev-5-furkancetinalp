# odev-5

1- Business, Presentation( Yani Web Api), Dto katmanlarını oluşturacağız 

2- FluentValidation ve AutoMapper implementasyonu yapılacak ve odevde bunları kullanacağız 

3- Startup dosyası uygun şekilde düzenlenecek 

4- Proje swagger üzerinden istek atılabilir hale gelsin 

NOT: CRUD işlemleri de kullanılacaktı (Yanlış hatırlıyorsam düzeltin lütfen)

# Son Teslim Tarihi: 29 Temmuz Cuma saat 23.00

### PaymentApp Projesinde bulunan Customer ve Account sınıflarının Business,Presentation ve DTO katmanları oluşturuldu.

#### Customers => Bankalara ait müşterilerin tanımlanmasını sağlayan sınıftır.
#### Accounts => Her bir müşterinin(Customers sınıfı) bir Account(hesap) sınıfı olmasını sağlayan sınıftır.

#### Buna göre bir müşterinin yalnızca 1 Account sınıfı olabilir. 
#### Account sınıfı için; eğer Customer yoksa onun Account'u oluşturulamaz (olmayan müşterinin hesabının açılmasını engellemek için)
#### Customer sınıfı customerList(hangi bankanın listesine dahil olduğunu belirtmek için), Name,Surname, IdentityNumber değişkenlerinden oluşmaktadır.

#### Her iki sınıf için de CRUD işlemleri tanımlanmıştır.

Customer Sınıfının Get Metodunun Çağırılması
![Ekran Görüntüsü (260)](https://user-images.githubusercontent.com/99509540/181817460-c282539a-0d74-41ca-a92c-b7465090a8cc.png)

Customer Sınıfında Veri Eklenmesi (Veritabanında yalnızca '9'numaralı customerList eklendiği için 9 numaralı customerList seçildi)
![Ekran Görüntüsü (265)](https://user-images.githubusercontent.com/99509540/181818500-75d55e6b-de30-4bb2-ba22-7a198c1a3ff0.png)

Put İşlemi İçin Validation
![Ekran Görüntüsü (267)](https://user-images.githubusercontent.com/99509540/181818902-2ba5c7bf-3db1-4365-bcf5-2b9dd439dd92.png)

Account Sınıfında yalnızca id'si 7 olanın hesabı mevcut.
![Ekran Görüntüsü (269)](https://user-images.githubusercontent.com/99509540/181819205-c7b535ad-cb90-4bc5-8385-9a76833e8c84.png)

Yalnızca var olan customer'ların hesabı olabilir, aksi halde hata döner (Bu durumda id'si 8 olan customer için account açılabilir yalnızca)
![Ekran Görüntüsü (271)](https://user-images.githubusercontent.com/99509540/181819369-e7f9e3af-c4ef-40e0-8f8a-1be8c5758ea5.png)

Account için için customerid'sini değiştirme işlemi. Eğer veritabanında değiştirilmek istenen customerId mevcut değilse sistem izin vermez.
![Ekran Görüntüsü (274)](https://user-images.githubusercontent.com/99509540/181820083-5c93e19f-992b-4546-afe1-3fdfc8df14f7.png)

Account verisi silme işlemi. Eğer sistemde yoksa data not found döner.
![Ekran Görüntüsü (276)](https://user-images.githubusercontent.com/99509540/181820533-a98bd4e1-b3cf-44af-add8-ec2e8f6f7e14.png)

