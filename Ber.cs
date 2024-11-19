namespace Berek;
internal class Ber
{
    public string Nev { get; set; }
    public bool Nem { get; set; }
    public string Reszleg { get; set; }
    public int Belepes { get; set; }
    public int Berezes { get; set; }

    public Ber(string sor)
    {
        string[] adat = sor.Split(';');

        Nev = adat[0];
        Nem = adat[1].ToLower() == "férfi";
        Reszleg = adat[2];
        Belepes = int.Parse(adat[3]);
        Berezes = int.Parse(adat[4]);
    }

    public override string ToString() => $"{Nev}({(Nem ? "férfi" : "nő")}) - {Reszleg} {Belepes} {Berezes}Ft";
}
