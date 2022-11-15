/*Koleksiyonlar 
 *Dizi içerisinde de aynı tip veriler tutulur
 *Dizilerin boyutları sonradan değiştirilemez fakat koleksiyonlarda ise her zaman değiştirilebilir.
 *1-normal koleksiyonlar
 *2-generik koleksiyonlar
 *
 *1-ArrayList List<>
 *2-Queue Queue<>
 *3-Stack Stack<>
 *4-Hashtable Dictonary<>
 *5-SortedList SortedList<>
 */

using System.Collections;

ArrayList arrayList = new ArrayList(/*istersek buradan kapasiteyi belirleriz*/);

for (int i = 0; i < 0; i++) //koleksiyonlar ihtiyaca göre yer açar
{
    arrayList.Add(i);
}
Console.WriteLine($"kapasite={arrayList.Capacity} adet= {arrayList.Count}");
//varsayılan olarak kapatsite 2^n olarak gider, kapasiteyi biz verirsek n*2 diye gider


ArrayList liste = new ArrayList();
liste.Add("sa");
liste.Add(123);
liste.Add(2.3);
liste.Add(true);
string[] sehirler = { "istanbul", "ankara", "bursa" };
liste.AddRange(sehirler);
liste.Insert(1, 3);
foreach (object obj in liste)
{
    Console.WriteLine(obj);
}
Console.WriteLine(liste.Contains("sa"));
Console.WriteLine(liste.IndexOf(2.3));

liste.Reverse(); // terse çeviriyor
foreach (object obj in liste)
{
    Console.WriteLine(obj);
}
//veriler aynı tip olursa sort kullanılır

ArrayList isimler = new ArrayList() { "b", "e", "c", "a", "d" };
isimler.Sort();
foreach (var isim in isimler)
{
    Console.WriteLine(isim);
}
for (int i = 0; i < isimler.Count; i++)
{
    Console.WriteLine(isimler[i]);
}

/*2-QUEUE
 * FIFO (first in first out)
 */


Queue kuyruk = new Queue();
// kuyruğa ekleme için kullanılır
kuyruk.Enqueue(123);
kuyruk.Enqueue(999);
kuyruk.Enqueue(245);
// kuyruktan çıkarmak için kullanılır
Console.WriteLine(kuyruk.Count);
Console.WriteLine(kuyruk.Dequeue());// sıradaki elemanı çıkarır ----ilk 123 çıktı
Console.WriteLine(kuyruk.Peek);//en üsteki elemanı alır 
Console.WriteLine(kuyruk.Count);

/*3-Stack 
 * Lifo Last in First Out
 */


Stack stack = new Stack();
stack.Push(123);
stack.Push(155);
stack.Push(234);
Console.WriteLine(stack.Pop());
Console.WriteLine(stack.Peek());

//4-hashtable
//key-value pairs(key value ikilisi

//key ile içerisindeki value eşleşir
Hashtable ht = new Hashtable();
ht.Add("34", "istanbul");
ht.Add("35", "İzmir");
ht.Add("06", "Ankara");
ht.Add("15", "Bursa");
Console.WriteLine(ht["06"]);
foreach (object obj in ht.Keys)
{
    Console.WriteLine(obj);
}
foreach (object veri in ht.Values)
{
    Console.WriteLine(veri);
}

/*
 * 5-sorted list
 */

SortedList sortedList = new SortedList();
sortedList.Add(34, "İstanbul");
sortedList.Add(35, "İzmir");
sortedList.Add(6, "Angara");
foreach (object obj in sortedList.Keys)
{
    Console.WriteLine(obj + " " + sortedList[obj]);
}