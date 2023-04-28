using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Hastane
{
    class Hastane
    {
        string doktor;
        string hasta;
        string randevu;

    }
    class Doktor : Hastane
    {
        
        string BasDoktor="yunus emre uzun";
        string doktor1="ahmet ateş";
        string doktor2="janset gökçe";
        string doktor3="tolga tekin";

        string ha=" ";
        double tc;
        byte yas;
        string anne;
        string baba;

      
        public void DoktorGiris()
        {
            
            bas:
            Console.Write("Doktorun İsmini Giriniz: ");
            string gdoktor = Console.ReadLine();
            Console.Write("Şifre Giriniz: ");
            string gsifre=Console.ReadLine();
            if(gdoktor.ToLower()== BasDoktor && gsifre == "Yunus123" )
            {
                Console.WriteLine("Hoş Geldiniz Uzman Doktor 'Yunus Emre Uzun' ");
                Console.WriteLine("Yönlendiriliyorsunuz...");
                Thread.Sleep(2000);
                Console.Clear();
            }
            else if (gdoktor.ToLower() == doktor1 && gsifre == "Ahmet123")
            {
                Console.WriteLine("Hoş Geldiniz Aile Hekimi 'Ahmet Ateş' ");
                Console.WriteLine("Yönlendiriliyorsunuz...");
                Thread.Sleep(2000);
                Console.Clear();
            }
            else if (gdoktor.ToLower() == doktor2 && gsifre == "Janset123")
            {
                Console.WriteLine("Hoş Geldiniz Psikolog 'Janset Gökçe' ");
                Console.WriteLine("Yönlendiriliyorsunuz...");
                Thread.Sleep(2000);
                Console.Clear();
            }
            else if (gdoktor.ToLower() == doktor3 && gsifre == "Tolga123")
            {
                Console.WriteLine("Hoş Geldiniz Çocuk ve ergen psikiyatrisi 'Tolga Tekin' ");
                Console.WriteLine("Yönlendiriliyorsunuz...");
                Thread.Sleep(2000);
                Console.Clear();
            }else
            {
                Console.WriteLine("Öyle bir doktor mevcut değil ");
                Console.WriteLine("Lütfen tekrar deneyin ");              
                Thread.Sleep(2000);
                Console.Clear();
                goto bas;
            }

        }
      
      
        public void hastaEkle()
        {
          
            Console.WriteLine("Eklemek İstediğiniz Hastanın adını giriniz: ");
            ha= Console.ReadLine();
            Console.Write("Hasta Tc : ");
            tc = Convert.ToDouble(Console.ReadLine());
            Console.Write("Hasta Yaşı : ");
            yas = Convert.ToByte(Console.ReadLine());
            Console.Write("Anne Adı : ");
            anne = Console.ReadLine();
            Console.Write("Baba Adı : ");
            baba = Console.ReadLine();

            
        }
        public void hastaGoruntule()
        {
           if(ha==" ")
            {
                Console.WriteLine("Kayıtlı bir hasta yok daha sonra tekrar deneyin.");
                Thread.Sleep(1500);
            }
            else
            {
            Console.WriteLine("---------Hasta Randevu Bilgileri---------");
            Console.WriteLine("Hasta Adı-Soyadı :" +ha);
            Console.WriteLine("Hasta Tc :" + tc);
            Console.WriteLine("Hasta Yaş:" + yas);
            Console.WriteLine("Hasta Anne Adı :" + anne);
            Console.WriteLine("Hasta Baba Adı :" + baba);

            }
           
        }


    }

    class Hasta : Hastane
    {
        string hadsoyad=" ";
        string htc;
        string hyas;
        string hanne;
        string hbaba;
        string hastasecim;
        public DateTime randevuTarihi1;
         public string Ad { get; set; }
         public string Soyad { get; set; }
         public bool Taburcu { get; set; }
         public DateTime TaburcuTarihi { get; set; }


         public void taburcu()
        {
            // Hasta listesi oluştur
            var hastalar = new List<Hasta>()
        {
            new Hasta { Ad = "Ahmet", Soyad = "Yılmaz", Taburcu = true, TaburcuTarihi = new DateTime(2022, 4, 25) },
            new Hasta { Ad = "Mehmet", Soyad = "Kaya", Taburcu = false },
            new Hasta { Ad = "Ali", Soyad = "Çelik", Taburcu = true, TaburcuTarihi = new DateTime(2022, 4, 26) },
            new Hasta { Ad = "Ayşe", Soyad = "Demir", Taburcu = false },
            new Hasta { Ad = "Fatma", Soyad = "Bulut", Taburcu = true, TaburcuTarihi = new DateTime(2022, 4, 27) },
        };

            // Taburcu olan hastaları filtrele
            var taburcuHastalar = hastalar.FindAll(hasta => hasta.Taburcu == true);

            // Rastgele bir hastayı seç
            var random = new Random();
            var index = random.Next(taburcuHastalar.Count);
            var secilenHasta = taburcuHastalar[index];

            // Hastanın bilgilerini görüntüle
            Console.WriteLine("{0} {1} adlı hasta {2} tarihinde taburcu oldu.", secilenHasta.Ad, secilenHasta.Soyad, secilenHasta.TaburcuTarihi);
        } 

        public void hastaBilgileri()
        {
            Console.Write("Hasta Adı ve Soyadı : ");
            hadsoyad = Console.ReadLine();  
            Console.Write("Hasta Tc : ");
            htc = Console.ReadLine();
            Console.Write("Hasta Yaşı : ");
            hyas = Console.ReadLine();
            Console.Write("Anne Adı : ");
            hanne = Console.ReadLine();
            Console.Write("Baba Adı : ");
            hbaba = Console.ReadLine();
            Console.Write("Hasta Randevu ister mi?(e/h) : ");
            hastasecim=Console.ReadLine();
            if(hastasecim=="e")
            {
                hastaRandevu();
                Thread.Sleep(4000);
            }
            

        } 
     
        public void hastaRandevu()
        {
            if (hadsoyad == " ")
            {
                Console.WriteLine("Kayıtlı bir hasta yok daha sonra tekrar deneyin.");
                Thread.Sleep(1500);
            }
            else
            {
            string[] doktorlar = { "Yunus Emre Uzun", "Ahmet Ateş", "Tolga Tekin", "Yunus Emre Uzun" };
            Random rastgelesayi = new Random(); 
            int no = rastgelesayi.Next(0, doktorlar.Length);
            Console.WriteLine("---------Hasta Randevu Bilgileri---------");
            Console.WriteLine("İlgilenecek Doktor: " + doktorlar[no]);
                Console.WriteLine("Randevu Tarihi: "+randevuTarihi1);
                Console.WriteLine("Hasta Adı-Soyadı :" + hadsoyad);
            Console.WriteLine("Hasta Tc :"+htc);
            Console.WriteLine("Hasta Yaş:"+hyas);
            Console.WriteLine("Hasta Anne Adı :"+hanne);
            Console.WriteLine("Hasta Baba Adı :" + hbaba);
            
            }
            




        }
       
        public void randevuTarihi()

        {
           

            Console.Write("Randevu tarihini giriniz (gg/aa/yyyy): ");
            randevuTarihi1 = DateTime.Parse(Console.ReadLine());

            if (randevuTarihi1 < DateTime.Now)
            {
                Console.WriteLine("Geçmiş bir tarih girdiniz. Lütfen yeniden deneyin.");
                Console.Write("Randevu tarihini giriniz (gg/aa/yyyy): ");
                randevuTarihi1 = DateTime.Parse(Console.ReadLine());
            }

        }

    }

   
        internal class Program
    {
        static void Main(string[] args)
        {
            Console.BackgroundColor = ConsoleColor.White;
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Doktor doktors = new Doktor();
            Hasta hastas = new Hasta();
            
            secim:
            Console.WriteLine("------------------------------------------------Hastanemize Hoş Geldiniz------------------------------------------------");
            Console.WriteLine("Doktor işlemleri için 1'e basınız. ");
            Console.WriteLine("Hasta işlemleri için 2'ye basınız. ");
            Console.Write("Seçim: ");
            string secim = Console.ReadLine();
            if(secim=="1")
            {
                
                Console.Clear();
                doktors.DoktorGiris();
                basesu:
                Console.WriteLine("Hasta kaydetmek için 1");
                Console.WriteLine("Hasta Randevusu görüntülemek için 2'ye tıklayınız.");
                Console.WriteLine("Hastaneden taburcu olanları görüntülemek için 3'ye tıklayınız.");
                Console.WriteLine("Menüye Dönmek İçin x'e basın");
                string doktirsecm = Console.ReadLine();
                if(doktirsecm == "1")
                {
                    doktors.hastaEkle();
                    Console.Clear();
                    goto basesu;

                }if (doktirsecm == "2")
                {
                  doktors.hastaGoruntule();
                    Thread.Sleep(3000);
                    Console.Clear();
                    goto basesu;
                    
                }
                if (doktirsecm == "3")
                {
                    hastas.taburcu();
                    Thread.Sleep(3000);
                    Console.Clear();
                    goto basesu;
                }

                    if (doktirsecm=="x")
                {
                    Console.Clear();
                    goto secim;
                }

            }
            if(secim=="2")
            {

                bsake:
                Console.Clear();
                Console.WriteLine("1-Hasta Bilgisi Giriş");
                Console.WriteLine("2-Randevu Bilgileri");
                Console.WriteLine("Menüye Dönmek İçin x'e basın");
                string secimhasta=Console.ReadLine();
                if (secimhasta=="1")
                {
                    
                    hastas.randevuTarihi();
                    hastas.hastaBilgileri();
                    goto bsake;
                    
                }if(secimhasta=="2")
                {
                    hastas.hastaRandevu();
                    Thread.Sleep(3000);
                    Console.Clear();
                    goto bsake;
                    
                }

                if (secimhasta == "x")
                {
                    Console.Clear();
                   Thread.Sleep(3000);
                    Console.Clear();
                    goto bsake;
                }



            }
            
            else 
            {              
                Console.WriteLine("Lütfen Doğru Seçim Yapınız");
                Thread.Sleep(1500);
                Console.Clear();
                goto secim;
            }    
            Console.ReadKey();
        }
    }
}
