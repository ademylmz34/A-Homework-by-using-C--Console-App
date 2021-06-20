/***************************************************************************************************************************
**                                                 SAKARYA ÜNİVERSİTESİ
**                                         BİLGİSAYAR VE BİLİŞİM BİLİMLERİ FAKULTESİ
**                                            BİLGİSAYAR MÜHENDİSLİĞİ BÖLÜMÜ
**                                           NESNEYE DAYALI PROGRAMLAMA DERSİ
**                                                 2020-2021 BAHAR DÖNEMİ
**
**
**                                            ÖDEV NUMARASI........: ...........
**                                            ÖĞRENCİ ADI..........: ADEM YILMAZ
**                                            ÖĞRENCİ NUMARASI.....: G191210305
**                                            DERSİN ALINDIĞI GRUP.: 2D
**
**
****************************************************************************************************************************/

using System;
using System.Collections;

namespace SORU1
{
    class Program
    {
        static void Main(string[] args)
        {
            string[,] kaleler = new string[8, 8];//8x8 lik bir matris tanımlıyorum.
            ArrayList X = new ArrayList();//her bir kalenin x konumu için bir liste tanımlıyorum bu listeye atacağım konumlarımı.
            ArrayList Y = new ArrayList();//her bir kalenin y konumu için bir liste tanımlıyorum.
            //arrraylist kullanmamın sebebi listedeki değerleri tek tek kontrol etmek kolay(contains metodu ile).
            int x, y;// x ve y konumunu tutan değişkenler tanımlıyorum bunlarla kontrolleri sağlayacağım.
            Random rastgele = new Random();
            for (int i = 0; i < 8; i++) /*döngümü 8 e kadar döndürüyorum ve x ve y konumlarıma değerlerimi atayacağım 
                                        ve kalelerin konumlarını belirleyeceğim*/
            {
                if (i == 0)//ilk kale'nin konumunu ilk kale olduğu için kontrolsüz belirliyorum.
                {
                    x = rastgele.Next(0, 8);//x konumu için rastgele bir değer üretiyorum.
                    y = rastgele.Next(0, 8);//y konumu için rastgele bir değer üretiyorum.
                    X.Add(x);//x konumunu x listesine atıyorum çünkü kontrol edeceğim diğer kalelerin x konumları bunlarla aynı olmamalı.
                    Y.Add(y);//y konumunu y listesine atıyorum çünkü kontrol edeceğim diğer kalelerin y konumları bunlarla aynı olmamalı.
                    kaleler[x, y] = "K";//1.kalenin tanımladığım kaleler dizisinin x.ci satırın y ninci sütunundaki değerine K yı atıyorum.
                }
                else//diğer her bir kale için buradan işlem yapacağım.
                {
                    x = rastgele.Next(0, 8); //x konumu için rastgele bir değer üretiyorum.
                    y = rastgele.Next(0, 8); //y konumu için rastgele bir değer üretiyorum.
                    while ((X.Contains(x) == true && Y.Contains(y) == true) || X.Contains(x) == true || Y.Contains(y) == true)
                    {/*ürettiğim bu konumlar diğer x ve y konumları ile aynı mı değilmi diye kontrol ediyorum ve farklı olana kadar 
                      bu döngüyü döndürüyorum ve yeni yeni x ve y konumları üretiyorum*/
                        //1.kaleyi konumlandırmıştım ve diğer kalan her bir kale için bunları yapıyorum.
                        x = rastgele.Next(0, 8);
                        y = rastgele.Next(0, 8);
                    }
                    X.Add(x);//ve son x ve y değerlerimi listeye atıyorum.
                    Y.Add(y);
                    kaleler[x, y] = "K"; //sıradaki kale'nin tanımladığım kaleler dizisinin x.ci satırın y ninci sütunundaki değerine K yı atıyorum.
                }
            }// bu döngü bitince tüm kalelerimin x ye y konumları farklı olacak ve birbirlerini yeme şansı olmayacak.
            for (int k = 0; k < 8; k++)// bu döngümde ise kaleleri 8x8 lik matris  şeklinde yazdırıyorum.
            {
                for (int j = 0; j < 8; j++)
                {
                    if (kaleler[k, j] == "K")/*eğerki kaleler dizisinin k.cı satırının j.ci sütununda k varsa
                                       kaleler dizisindeki k.satırın j.ci sütunundaki K değerini yazdırıyorum*/
                    {
                        Console.Write(kaleler[k, j] + " ");
                    }
                    else//diğer boş kalan yerlere 0 yazdırıyorum.
                    {
                        Console.Write("0" + " ");
                    }

                }
                Console.WriteLine(" " + " ");//herbir kaleyi yazdırdıktan sonra bir alt satıra geçiyorum
            }
        }
    }
}
