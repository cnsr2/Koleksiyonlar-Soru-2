using System;
using System.Collections;
using System.Collections.Generic;
    class program
    {
        static void Main(string[] args)
        {
            ArrayList sayilar = new ArrayList();
          try
          {
              for (int i = 0; i < 20; i++)
              {
                Console.WriteLine("Lütfen {0}. Sayınızı Giriniz",i+1);
                sayilar.Add(Convert.ToInt32(Console.ReadLine()));
              }
          }
          catch (System.Exception)
          {
              Console.WriteLine("İşlem Başarısız, Lütfen Sadece Sayı Giriniz.");
          }
          sayilar.Sort();
          int[] enbuyuk = new int[3]; 
          int[] enkucuk = new int[3];
          int sayacbuyuk = 0;
          int sayackucuk = 0;
          for (int i = 0; i < 3; i++)
          {
              enbuyuk[i] = Convert.ToInt32(sayilar[i+17]);
              sayacbuyuk +=enbuyuk[i];
          }
          for (int i = 0; i <3; i++)
          {
              enkucuk[i] = Convert.ToInt32(sayilar[i]);
              sayackucuk +=enkucuk[i];
          }
          Console.WriteLine("En Büyük 3 Sayınız :");
          foreach (var item in enbuyuk)
          {
            Console.WriteLine(item);
          }
          Console.WriteLine("En Küçük 3 Sayınız :");
          foreach (var item in enkucuk)
          {
            Console.WriteLine(item);
          }
          Console.WriteLine("En Büyük 3 Sayınızın Ortalaması : {0}",sayacbuyuk/3);
          Console.WriteLine("En Küçük 3 Sayınızın Ortalaması : {0}",sayackucuk/3);
          int toplam = sayacbuyuk/3+sayackucuk/3;
          Console.WriteLine("En Büyük Ve En Küçük Sayılarınızın Ortalamalarının Toplamı : {0}",toplam);
        }
    }