using Ornek;

Depo depo = new Depo();
bool a = true;

Urun UrunAl()
{
    Urun urun = new Urun();
    Console.WriteLine("id");
    urun.Id = int.Parse(Console.ReadLine());
    Console.WriteLine("isim");
    urun.Isim = Console.ReadLine();
    Console.WriteLine("fiyat");
    urun.Fiyat = int.Parse(Console.ReadLine());
    return urun;
}
while (a)
{
    Console.WriteLine("seçim yap");
    switch (Convert.ToInt64(Console.ReadLine()))
    {
        case 1:

            depo.UrunEkle(UrunAl());

            break;
        case 2:
            foreach (Urun listele in depo.Lisetele())
            {
                Console.WriteLine($"urun id ={listele.Id}, urun fiyat ={listele.Fiyat}, urun isim ={listele.Isim}");
            }
            break;
        case 3:
            {
                depo.UrunSil(Convert.ToInt16(Console.ReadLine()));
                break;
            }
        case 4:
            a = false;
            break;
        default:
            break;
    }
}