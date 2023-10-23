namespace diziler;

class Program
{
    static void Main(string[] args)
    {
        //Dizi tanımlama
    /*    
        string[] renkler=new string[5];
        string[] hayvanlar={"kedi" , "kopek","kus"};
        int[] dizi;
        dizi=new int[5];

        //dizilere değer atama
        renkler[0]="mavi";
        
        dizi[3]=10;

        Console.WriteLine(renkler[0]);
        Console.WriteLine(hayvanlar[0]);
        Console.WriteLine(dizi[3]);
*/
        //diziler ile döngü
        //klavyeden girilen n tane sayının ortalamasını hesaplayan program
        Console.WriteLine("Dizinin eleman sayısını giriniz.");
        int diziUzunlugu=int.Parse(Console.ReadLine());
        int[] sayiDizisi=new int[diziUzunlugu];
        for(int i=0;    i<diziUzunlugu; i++){
            Console.WriteLine(i+1 +". sayiyi giriniz:");
            sayiDizisi[i]=int.Parse(Console.ReadLine());

        }
        int toplam=0;

        foreach (var sayi in sayiDizisi)
        {   
            toplam=toplam+sayi;
            
        }
        Console.WriteLine("Ortalama:"+toplam/diziUzunlugu);
        
    }
}
 