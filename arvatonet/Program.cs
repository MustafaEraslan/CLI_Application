using System;
using System.Collections.Generic;

namespace arvatonet
{
    class Program
    {

        static void Main(string[] args)
        {
            Console.Write("TC Kimlik No girebilirsiniz:  ");
            string tc = Console.ReadLine();

            char[] rakamlarDizisi = { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9' };
            Dictionary<string, Personal> dicPersonal = new Dictionary<string, Personal>();
            dicPersonal.Add("11111111111",new Personal { TcNumber= "11111111111", Name= "Mustafa" });
            dicPersonal.Add("22222222222", new Personal { TcNumber = "22222222222", Name = "Ahmet" } );
            dicPersonal.Add("33333333333", new Personal { TcNumber = "33333333333", Name = "Can" });

            Dictionary<string, Product> dicProduct = new Dictionary<string, Product>();
            string appleCode = Guid.NewGuid().ToString();
            string samsungCode = Guid.NewGuid().ToString();
            string xiaomiCode = Guid.NewGuid().ToString();
            dicProduct.Add(appleCode, new Product { Code=appleCode, Name = "Apple", Price = 1000, Stock=10 });
            dicProduct.Add(samsungCode, new Product { Code = samsungCode, Name = "Samsung", Price=750, Stock=100 });
            dicProduct.Add(xiaomiCode, new Product { Code = xiaomiCode, Name = "Xiaomi", Price=400, Stock=1000 });

            Dictionary<string, Order> dicOrder = new Dictionary<string, Order>();

            if (ValidationTc(tc))
            {
                if (dicPersonal.ContainsKey(tc))
                {
                    Console.WriteLine(dicPersonal[tc].Name);
                }
                else
                {
                    Personal personal = new Personal();
                    personal.TcNumber = tc;
                    Console.Write("şimdi girdiğiniz tcye isim ekleyiniz: ");
                    personal.Name = Console.ReadLine();

                    Console.Write("şimdi girdiğiniz tcye soyisim ekleyiniz: ");
                    personal.Surname = Console.ReadLine();
                    Console.Write("şimdi girdiğiniz tcye gsm ekleyiniz: ");
                    personal.GsmNumber = Console.ReadLine();

                    dicPersonal.Add(personal.TcNumber,personal);
                    Console.WriteLine("Kayıt başarılı.");
                }
                foreach(var item in dicProduct)
                {
                    Console.WriteLine($"ÜrünKodu: {item.Key}, Ürünİsmi: {item.Value.Name}, ÜrünFiyatı: {item.Value.Price}, StoktakiÜrünSayısı: {item.Value.Stock}");
                }
                Console.Write("Şimdi apple, samsung veya xiomi den bir tanesini seçebilirsiniz:  ");
                string productCode = Console.ReadLine();
                while (!dicProduct.ContainsKey(productCode))
                {
                    Console.Write("Tekrar deneyiniz  ");
                    productCode = Console.ReadLine();
                }
                Console.Write("Şimdi stok miktarını giriniz:  ");
                string stock = Console.ReadLine();
                int totalPiece ;
                bool isStock = int.TryParse(stock, out totalPiece);
               
                while (!isStock || dicProduct[productCode].Stock < totalPiece)
                {
                    Console.Write("Tekrar deneyiniz. Stok değerlerini kontrol ediniz.  ");
                    stock = Console.ReadLine();
                    isStock = int.TryParse(stock, out totalPiece);
                }
                double productPrice = dicProduct[productCode].Price;
                Order order = new Order();
                order.Code = Guid.NewGuid().ToString();
                order.Personal = dicPersonal[tc];
                order.TotalAmount = productPrice * totalPiece;
                order.TotalPiece = totalPiece;
                order.ProductCode = productCode;
                order.ProductPrice = productPrice;

                Console.WriteLine("Sipariş başarılı bir şekilde oluşturuldu.");
                dicOrder.Add(order.Code, order);
                foreach (var item in dicOrder.Values)//sözlük yapısı kullandık ve bu sebeple for kullanamıyoruz. i değerine sahip değiliz.
                {
                    Console.WriteLine($"Sipariş kodu: {item.Code}, Tutarı: {item.TotalAmount}, Adeti: {item.TotalPiece}, Parça başına fiyatı: {item.ProductPrice}, Siparişi verenin adı : {item.Personal.Name}");
                }//$ ile + kullanımından kurtulduk.


           }
            else
            {
                Console.WriteLine("Girmis oldugunuz tc kimlik numarsi 11 karakterli olmalı, sizin girdiğiniz {0} karakterli", tc.Length);
            }
            Console.Read();

        }
        protected static bool ValidationTc(string tc) {
            //TODO int tryparse ile numara kontrolü yapılacak 11 tane a verdiğimde geçiyor. bunu çöz
            if (tc.Length == 11 && !tc.StartsWith("0"))
            {
                return true;
            }
            return false;
        }

    }

}
