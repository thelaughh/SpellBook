global using SpellBook;

Console.WriteLine("Generátor náhodných spellů");

List<Spell> seznamSpellu = new List<Spell>();
HelperClass pomocneMetody = new HelperClass();

string[] poleForma = pomocneMetody.PoleZTextu("txt/spellform.txt");
string[] poleTypy = pomocneMetody.PoleZTextu("txt/spelltypes.txt");

while (true)
{
    Console.WriteLine("1. vygenerovat nový spell a přidat do Spellbook");
    Console.WriteLine("2. zobrazit Spellbook");
    Console.WriteLine("3. smazat poslední záznam ve SpellBooku");
    Console.WriteLine("4. smazat celý SpellBook");
    Console.WriteLine("5. ukončit aplikaci");

    string input = Console.ReadLine();

    if (input == "1")
    {
        Spell kniha = new Spell();
        kniha.ManaCost = pomocneMetody.VYgenerujCislo(800);
        kniha.Name = pomocneMetody.VygenerujSpellname(poleForma, poleTypy);
        seznamSpellu.Add(kniha);
    }
    else if (input == "2")
    {
        foreach (Spell kniha in seznamSpellu) ;
    }
    else if (input == "3")
    {
        int indexPosledního = seznamSpellu.Count - 1;
        Spell poslední = seznamSpellu[indexPosledního];
        seznamSpellu.Remove(poslední);
    }
    else if (input == "4")
    {
        seznamSpellu.Clear();
    }
    else if (input == "*")
    {
        break; 
    }



}