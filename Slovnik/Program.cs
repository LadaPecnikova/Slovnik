// See https://aka.ms/new-console-template for more information
using System.Collections.Generic;

// 1. Vypiš aktuální datum a čas, nemusíš řešit, v kterém je to časovém pásmu.
Console.WriteLine(DateTime.Now);

// 2. Vytvoř proměnnou typu DateTime a ulož do ní svoje datum narození. Potom vypiš, kolik dnů od té doby uteklo.
DateTime datumNarozeni = new DateTime(1997, 9, 12);
DateTime aktualni = DateTime.Now;
Console.WriteLine((aktualni - datumNarozeni).Days);

// 3. Vytvoř list stringů a vlož do něj 5 různých hodnot.
List<string> list = new List<string>();
list.Add("zdravim");
list.Add("dobre");
list.Add("dopo");
list.Add("ahoj");
list.Add("cau");

//List<string> list = new List<string>() { "zdravim", "dobre", "dopo", "ahoj", "cau" };

// 4. Smaž z tohoto listu libovolnou hodnotu.
list.Remove("cau");

// 5. Zjisti, jestli tento list obsahuje nějakou hodnotu pomocí list metody Contains
Console.WriteLine(list.Contains("dobre"));

// 6. Vypiš do konzole, kolik je v tom listu prvků a připoj k tomu všechny ty hodnoty (např: "2: modra, zelena").
int pocet = list.Count;
Console.Write($"{pocet}: ");

for (int i = 0; i < list.Count; i++)
{
    Console.WriteLine($"{list[i]} ");
}

// 7. Vytvoř slovník, kde klíčem bude položka nákupu (string) a hodnotou cena té položky, a vlož nějaké hodnoty (např: <"chleba", 20>).
Dictionary<string, int> nakup = new Dictionary<string, int>();
nakup.Add("chleba", 20);
nakup.Add("zmrzlina", 28);
nakup.Add("maslo", 56);
nakup.Add("zelenina", 120);

// 8. Zjisti, jestli slovník obsahuje nějakou konkrétní potravinu a pokud ano, vypiš její cenu, pokud ne, vypiš, že není.
bool nalezeno = false;
foreach(KeyValuePair<string, int> item in nakup)
{
    if(item.Key == "chleba") 
    {
        Console.WriteLine($"Cena chleba je {item.Value} Kč.");
        nalezeno = true;
        break;
    }
}
if (!nalezeno)
{
    Console.WriteLine("Není.");
}

// 9. Řekněme, že už jsi do slovníku přidala např. chleba a zjistila, že máš v nákupní tašce ještě jeden -> uprav hodnotu k tomu klíči tak, aby obsahovala hromadnou cenu za všechny stejné položky.
string hledanyKlic = "chleba";
int novaHromadnaCena = 0;

// Projdi všechny klíče ve slovníku
foreach (string klic in nakup.Keys)
{
    // Pokud je aktuální klíč stejný jako hledaný klíč
    if (klic == hledanyKlic)
    {
        // Přičti hodnotu klíče k celkové hromadné ceně
        novaHromadnaCena += nakup[klic];
    }
}

// Aktualizuj hodnotu klíče "chleba" na novou hromadnou cenu
nakup[hledanyKlic] = novaHromadnaCena;

Console.WriteLine($"Hromadná cena za {hledanyKlic} je {novaHromadnaCena} Kč.");