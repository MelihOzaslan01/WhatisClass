Calisanlar calisan1 = new Calisanlar();
calisan1.Ad = "İsmail";
calisan1.Soyad = "Kara";
calisan1.No = 1245697;
calisan1.Departman = "Bilgi İşlem";

calisan1.CalisanBilgileri();

Console.WriteLine("***************");


Calisanlar calisan2 = new Calisanlar();

calisan2.Ad = "Gamze";
calisan2.Soyad = "Kayış";
calisan2.No = 5412364;
calisan2.Departman = "Pazarlama";

calisan2.CalisanBilgileri();




class Calisanlar
{
    public string Ad;
    
    public string Soyad;
    
    public int No;

    public string Departman;

    public void CalisanBilgileri()
    {
        Console.WriteLine("Çalışanın Adı:{0}", Ad);
        Console.WriteLine("Çalışanın Soyadı:{0}", Soyad);
        Console.WriteLine("Çalışanın Numarası:{0}", No);
        Console.WriteLine("Çalışanın Departmanı:{0}", Departman);
    }

}