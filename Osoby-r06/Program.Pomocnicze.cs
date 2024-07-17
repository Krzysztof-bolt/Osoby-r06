using BibliotekaWspolna;

partial class Program
{
    static void WypiszNazwiska(IEnumerable<Osoba?> osoby, string naglowek)
    {
        WriteLine(naglowek);
        foreach (Osoba? o in osoby) 
        {
            WriteLine(" {0}",
                o is null ? "<null> Osoba" : o.Nazwisko ?? "<null> Nazwisko");
        }
    }
}
