using System.Linq.Expressions;
using System.Runtime.CompilerServices;
int überspringen = 0;
int eingabe;
int löschen;
int run = 0;
bool ersteNummer = false;
bool end = false;
List<int> intliste = new List<int>();
List<int> removeList = new List<int>();
Console.WriteLine("Bitte geben sie eine Zahl ein.");
while (end == false)
{
       try
    {
        eingabe = int.Parse(Console.ReadLine());
        if (eingabe <= 0)
        {
            end = true;
        }
        else
        {
            intliste.Add(eingabe);
            if(ersteNummer == false)
            {
                ersteNummer = true;
            }
            Console.WriteLine("Bitte geben sie eine Zahl ein.");
        }
    }
    catch {
        Console.WriteLine("Bitte geben sie eine Zahl ein.");
    }
}
end = false;
ersteNummer = false;
foreach (int nummer in intliste)
{
    Console.WriteLine(nummer);
}
Console.WriteLine("Bitte wählen sie eine Nummer zum löschen");
while(end == false)
{
    
    try
    {
        löschen = int.Parse(Console.ReadLine());
        if (löschen > 0)
        {
            
            foreach (int nummer in intliste)
            {
                if(nummer != löschen)
                {
                    überspringen++;   
                }
                else
                {
                    removeList.Add(überspringen);
                }
                run++;
                
            }
            end = true;
        }
    }

    catch
    {
        Console.WriteLine("Bitte geben sie eine ganze Zahl ein, keine Buchstaben oder Zeichen");
    }
    
} 
foreach (int del in removeList)
{
    intliste.RemoveAt(del);
}
foreach (int nummer in intliste)
{ Console.WriteLine(nummer); }
Console.ReadKey();