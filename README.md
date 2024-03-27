Çalışmam da "ACDEFGHKLMNPRTXYZ234579" karakterlerini kullanarak 8 haneli 1000 adet kod oluşturdum.
Console uygulamam da oluşturduğum kdoları herhangi bir saklama ortamında tutmadım.
Kullanıcı için şifrelediğim kodları uygulama her çalıştığında sabit olarak kendi tasarladığım algoritmaya göre oluşacak şekilde tasarladım.
İlk kodun ilk karakteri için 12. index ile başladım.
İlişkiler oluşturdum. İlişkileri oluştururken en küçük asal sayı ile başladım.
(0-1 --> 2, 1-2 -->, 2-3 --> 5, 3-4 --> 7, 4-5 --> 11, 5-6 --> 13, 6-7 --> 17)
Karakter setini oluştururken 1000'den 2000'e olan her sayı için ona eş kod ürettim. Kod sırası input olarak gönderiliyor.
(Her defasında index + input  %101 %23 )
