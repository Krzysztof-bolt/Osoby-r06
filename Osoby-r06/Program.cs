using BibliotekaWspolna;

Osoba henryk = new()
{
    Nazwisko = "Henryk",
    DataUrodzenia = new(year: 2001, month: 3, day: 25)
};

henryk.WypiszWKonsoli();

//niegeneryczna kolekcja z wyszukiwaniem
System.Collections.Hashtable wyszukiwanieObiektow = new();
wyszukiwanieObiektow.Add(key: 1, value: "Alpha");
wyszukiwanieObiektow.Add(key: 2, value: "Beta");
wyszukiwanieObiektow.Add(key: 3, value: "Gamma");
wyszukiwanieObiektow.Add(key: henryk, value: "Delta");

int klucz = 2;
WriteLine(format: "Klucz {0} ma wartosc : {1}",
    arg0: klucz,
    arg1: wyszukiwanieObiektow[klucz]);

//szukamy wartosci o kluczu rownym zmiennej henryk
WriteLine(format: "Klucz {0} ma wartosc : {1}",
    arg0: henryk,
    arg1: wyszukiwanieObiektow[henryk]);

    //generyczna kolekcja wyszykująca
Dictionary<int, string> slownikIntString = new();
slownikIntString.Add(key: 1, value: "Alpha");
slownikIntString.Add(key: 2, value: "Beta");
slownikIntString.Add(key: 3, value: "Gamma");
slownikIntString.Add(key: 4, value: "Delta");

klucz = 3;

WriteLine(format: "Klucz {0} ma wartosc : {1}",
    arg0: klucz,
    arg1: slownikIntString[klucz]);

//interfejsy

Osoba?[] osoby =
{
    null,
    new Osoba {Nazwisko = "Saniak"},
    new Osoba {Nazwisko = "Janiak"},
    new Osoba {Nazwisko = "Adun"},
    new Osoba {Nazwisko = null},
    new Osoba {Nazwisko = "Rykszak"}
};

WypiszNazwiska(osoby, "Poczatkowa lista osob:");

Array.Sort(osoby);

WypiszNazwiska(osoby, "Do posortowania użyto zaimplementowanego interfejsu IComparable:");



