using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace DosyaVeKlasorIslemleri
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //using System.IO; icerisindeki siniflardir
            #region DirectoryInfo Sinifi

            //string yol = "C://users/okan";
            //DirectoryInfo di = new DirectoryInfo(yol);

            //Console.WriteLine("Klasor var mi?" + di.Exists);
            ////di.Create();// Yoksa olustur
            //Console.WriteLine("Adi = " + di.Name);
            //Console.WriteLine("Tam Adi = " + di.FullName);
            //Console.WriteLine("Ebeveyn = " + di.Parent);
            //Console.WriteLine("Root Klasor" + di.Root);
            //Console.WriteLine("Olusturma Zamani = " + di.CreationTime);
            //Console.WriteLine("Olusturma Zamani UTC = " + di.CreationTimeUtc);
            ////if (di.Exists){di.Delete();//Varsa Siler}
            ////di.MoveTo("C//Deneme/Okan");//icerigiyle birlikte tasir
            //Console.WriteLine("Son Erisim Zamani = " + di.LastAccessTime);
            //Console.WriteLine("Son Erisim Zamani UTC = " + di.LastAccessTimeUtc);
            //Console.WriteLine("Son Yazma Zamani = " + di.LastWriteTime);
            //Console.WriteLine("Son Yazma Zamani UTC = " + di.LastWriteTimeUtc);
            #endregion
            #region FileInfo

            //string yoltxt = "C://Nikola/Nikola.txt";
            //string yoljpg = "C://Nikola/resim.jpeg";

            //FileInfo fitxt = new FileInfo(yoltxt);
            //FileInfo fijpg = new FileInfo(yoljpg);

            //Console.WriteLine("Isim = " + fitxt.Name);
            //Console.WriteLine("Isim = " + fijpg.Name);

            //Console.WriteLine("Tam Yol = " + fitxt.FullName);
            //Console.WriteLine("Tam Yol = " + fijpg.FullName);

            //Console.WriteLine("Klasor = " + fitxt.DirectoryName);
            //Console.WriteLine("Klasorl = " + fijpg.DirectoryName);

            //Console.WriteLine("Klasor Adi = " + fitxt.Directory);
            //Console.WriteLine("Klasor Adi = " + fijpg.Directory);

            //Console.WriteLine("Dosya Var mi = " + fitxt.Exists);
            //Console.WriteLine("Dosya Var mi = " + fijpg.Exists);

            //Console.WriteLine("Uzanti = " + fitxt.Extension);
            //Console.WriteLine("Uzanti = " + fijpg.Extension);

            //Console.WriteLine("Boyutu (Byte) = " + fitxt.Length);
            //Console.WriteLine("Boyutu (Byte) = " + fijpg.Length);

            //Console.WriteLine("Olusturma Zamani = " + fitxt.CreationTime);
            //Console.WriteLine("Olusturma Zamani = " + fijpg.CreationTime);

            //Console.WriteLine("Son Erisim Zamani = " + fitxt.LastAccessTime);
            //Console.WriteLine("Son Erisim Zamani = " + fijpg.LastAccessTime);

            //Console.WriteLine("Son Yazma Zamani = " + fitxt.LastWriteTime);
            //Console.WriteLine("Son Yazma Zamani = " + fijpg.LastWriteTime);

            ////FileInfo fi = new FileInfo("C://Nikola/Edison.txt");
            ////fi.Create(); // Var olup olmadigina bakmaksizin yenisini olusturur eskisini siler

            //Console.WriteLine("Sadece Okunabilir mi = " + fitxt.IsReadOnly);
            //Console.WriteLine("Sadece Okunabilir mi = " + fijpg.IsReadOnly);
            #endregion
            #region Directory

            //string yol = "C://";
            ////string[] klasorler = Directory.GetDirectories(yol);

            ////foreach (string item in klasorler)
            ////{
            ////    Console.WriteLine(item);
            ////}

            ////string[] dosyalar = Directory.GetFiles(yol); // gizli dosyalar dahil olmak uzere sistem dosyalariyla birlikte tumunu getirir
            ////foreach (string item in dosyalar)
            ////{
            ////    Console.WriteLine(item);
            ////}

            //DirectoryInfo di = new DirectoryInfo(yol);
            ////DirectoryInfo[] klasorler = di.GetDirectories();

            ////foreach (DirectoryInfo item in klasorler)
            ////{
            ////    Console.WriteLine(item.Name);
            ////}

            //FileInfo[] dosyalar = di.GetFiles();
            //foreach (FileInfo item in dosyalar)
            //{
            //    Console.WriteLine(item.Name);
            //}
            #endregion
            #region Drive Info

            //DriveInfo di = new DriveInfo("C:/");
            //Console.WriteLine("Tur = " + di.Name);
            //Console.WriteLine("Tur = " + di.DriveType);
            //Console.WriteLine("Kok = " + di.RootDirectory);

            //Console.WriteLine("Boyut = " + di.TotalSize);
            //Console.WriteLine("Kullanilabilir alan = " + di.AvailableFreeSpace);
            //Console.WriteLine("Kullanilabilir alan = " + di.TotalFreeSpace);
            //Console.WriteLine("Surucu Formati = " + di.DriveFormat);
            //Console.WriteLine("Surucu Isaretcisi = " + di.VolumeLabel);

            #endregion
            #region Stream Reader

            //string yoltxt = "C://Nikola/Nikola.txt";
            //string yoljpg = "C://Nikola/Nikola.jpg";
            //StreamReader sr = new StreamReader(yoljpg);

            ////Console.WriteLine(sr.Read());//Karakteri okudu
            //Console.WriteLine(sr.ReadLine());//Satiri okudu
            //Console.WriteLine(sr.ReadLine());//Yinelendiginde ayni satiri degil siradaki satiri okur

            //Console.ForegroundColor = ConsoleColor.Green;
            //Console.WriteLine(sr.ReadToEnd());//Sonuna kadar oku
            #endregion
            #region Stream Writer

            //string yoltxt = "C://Nikola/Deneme.txt";
            //string yolokan = "C://Nikola/Deneme.okan"; // kendi uzantimizi olusturabiliriz

            //StreamWriter sw = new StreamWriter(yoltxt,true);//true append ozelligini acar ve uzerine ekleme yapmasini saglar

            //string metin = "merhaba";
            //string encrypted = "";
            //char[] array = metin.ToCharArray();
            //for(int i = 0; i < array.Length; i++)
            //{
            //    int x = (int)array[i];
            //    encrypted += (char)(x + 1);
            //}
            //sw.WriteLine(encrypted); // uzerine yazar
            //sw.Close();//Close yapilmadigi surece islem bekler 

            #endregion
            #region Encoder

            EncodingInfo[] kodlayici = Encoding.GetEncodings();
            //Sistem uzerinde yuku olan ve kullanilabilir olan tum karakter kodlamalarini getirir
            //foreach (EncodingInfo item in kodlayici)
            //{
            //    Console.WriteLine($"{item.Name}{item.DisplayName}{item.CodePage}");
            //}

            Encoding ee = Encoding.GetEncoding("utf-8");
            StreamReader sr = new StreamReader("C//Nikola/Nikola/txt",ee);
            Console.WriteLine(sr.ReadToEnd());
            #endregion
        }
    }
}
