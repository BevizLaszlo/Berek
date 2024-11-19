/*
 * Kezdés: 9:00
 * Végzés: 9:24
 */

using Berek;
using System.Text;

List<Ber> berek = [];
using (StreamReader sr = new StreamReader(path: @"..\..\..\src\berek2020.txt", encoding: Encoding.UTF8))
{
    _ = sr.ReadLine();
    while (!sr.EndOfStream)
        berek.Add(new Ber(sr.ReadLine()));
}

Console.WriteLine($"3. feladat: Összesen {berek.Count} dolgozó adata található a forrásállományban.");
Console.WriteLine($"4. feladat: Az átlagbér {(double)(berek.Average(b => b.Berezes) / 1000):.0} ezer Ft");
Console.Write("5. feladat: Adja meg a részleg nevét: ");
string reszleg = Console.ReadLine();

Console.Write("6. feladat: ");
if (berek.Any(r => r.Reszleg == reszleg))
    Console.WriteLine($"A legnagyobb bérű dolgozó a részlegen: {
        berek.Where(r => r.Reszleg == reszleg)
             .OrderByDescending(b => b.Berezes)
             .First().ToString()}");
else
    Console.WriteLine("A megadott részleg nem rendelkezik a cégnél!");

Console.WriteLine("7. feladat: Részlegen dolgozók száma:");
foreach (IGrouping<string, Ber> resz in berek.GroupBy(r => r.Reszleg))
    Console.WriteLine($"\t{resz.Key}: {resz.Count()} fő");