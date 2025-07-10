
//using System.Collections.Generic;
using System.Threading;

/*
Console.Write("gimme a number");
int num = int.Parse(Console.ReadLine());
if (num % 2 == 0) {
    Console.WriteLine("tvoje cislo is sude");
}
else { Console.WriteLine("tvoje cislo je liche"); }




Console.Write("Kolik ti je let?");
int věk = int.Parse(Console.ReadLine());
if (věk < 13) {
    Console.WriteLine("GOOO GOOO GAAAA GAAAA");
}

else if (věk > 13 & věk < 18) {
    Console.WriteLine("STOP PLAYING GAMES BOZO");
}

else Console.WriteLine("Get a job unc");



Console.Write("1 numma");
int a = int.Parse(Console.ReadLine());
Console.Write("2 numma");
int b = int.Parse(Console.ReadLine());
Console.WriteLine("Alr lemme cook bro ");
int deez = a + b;
int nuts = a - b;
int uhhhhhh = a * b;
int iForgor = a / b;
Console.WriteLine("scitani " + deez);
Console.WriteLine("odcitani " + nuts);
Console.WriteLine("nasobeni " + uhhhhhh);
Console.WriteLine("deleni " + iForgor);

Console.Write("1 numma des. cislo btw");
float a = float.Parse(Console.ReadLine());
Console.Write("2 numma des. cislo btw");
float b = float.Parse(Console.ReadLine());
Console.Write("3 numma des. cislo btw");
float c = float.Parse(Console.ReadLine());
Console.WriteLine("Alr lemme cook bro ");
float vysledek = a + b + c;
Console.Write("alr bro here it is " + vysledek/3);


Console.WriteLine("whats ur name big boy?");
string name = Console.ReadLine();
Console.WriteLine("alr " + name + " kys");




int score = 0;

score += 10;

Console.WriteLine(score);

score *= 2;

Console.WriteLine(score);

score -= 5;

Console.WriteLine(score);

int a = 12; // 1100
int b = 5; // 0101
int vysledek1 = a & b;
Console.WriteLine(vysledek1);
int vysledek2 = a | b;
Console.WriteLine(vysledek2);
int vysledek3 = a ^ b;
Console.WriteLine(vysledek3);
int vysledek4 = a << 1;
Console.WriteLine(vysledek4);
int vysledek5 = a >> 1;
Console.WriteLine(vysledek5);


int a = 10;
int b = 7;
bool real = a > b;
Console.WriteLine(real);
bool realreal = a <= b;
Console.WriteLine(realreal);
bool realrealreal = a == b;
Console.WriteLine(realrealreal);


Console.WriteLine("Zadejte svůj věk... ");
string věk = Console.ReadLine();
Console.WriteLine("Zadal jste " + věk);
bool ok = int.TryParse(věk, out int věk2);
int věk3 = 18; 
if (věk2 >= 18){ 
    
    Console.WriteLine("Je vám / více než " + věk3);
}
  else if(ok == false) { 
    Console.WriteLine("Nezadali jste číslo... ");
}

else {
    Console.WriteLine("Nejste dost staří");

}





Console.WriteLine("Jak se jmenujete?");
string jmeno = Console.ReadLine();   
Console.WriteLine(" a kolik je vam let?");
string věk = Console.ReadLine(); 
Console.WriteLine($"Ahoj, {jmeno} je ti {věk} let");


string[] měsíce = {"leden", "unor","březen", "duben", "květen", "červen", "červenec", "srpen", "září", "listopad", "prosinec"};
int[]dny = {31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31};
Console.WriteLine("Červenec je " + měsíce[6] + " měsíc a má " + dny[6] + " dnů");
Console.WriteLine("Listopad je " + měsíce[10] + " měsíc a má " + dny[10] + " dnů");


List<int> numbers  = new List<int> { 100, 200, 300 };
numbers.Remove(200);
numbers.Add(400);
Console.WriteLine(numbers[0]);
Console.WriteLine(numbers[1]);
Console.WriteLine(numbers[2]);
int kolik = numbers.Count;
Console.WriteLine(kolik);


string[] zvirata = {"pes", "kocka", "ryba"};

for (int i = 0; i < 3; i++ ) {
    Console.WriteLine(zvirata[i]);
}
*/
/*
string[] funny = {}

foreach( string lol in funny ){
    Console.WriteLine(lol);
    Thread.Sleep(1000);
}
*/
/*
Console.WriteLine("Gimme a number");
int a = int.Parse(Console.ReadLine());
Console.WriteLine("another...");
int b = int.Parse(Console.ReadLine());
Console.WriteLine("AND ANOTHER");
int c = int.Parse(Console.ReadLine());
Console.WriteLine("ur nummers are " + a + b + c);
*/




/*
Console.WriteLine("Zadej nahodne cislo od 1 do 10");
int cislo = int.Parse(Console.ReadLine());
switch (cislo) {

    case 1 :
        Console.WriteLine("Vybral jste 1");
        break;

    case 2 :
        Console.WriteLine("Vybral jste 2");
        break;

    case 3 :
        Console.WriteLine("Vybral jste 3");
        break;

    case 4 :
        Console.WriteLine("Vybral jste 4");
        break;

    case 5 :
        Console.WriteLine("Vybral jste 5");
        break;

    case 6 :
        Console.WriteLine("Vybral jste 6");
        break;

    case 7 :
        Console.WriteLine("Vybral jste 7");
        break;

    case 8 :
        Console.WriteLine("Vybral jste 8");
        break;

    case 9 :
        Console.WriteLine("Vybral jste 9");
        break;

    case 10 :
        Console.WriteLine("Vybral jste 10");
        break;

    default :
        Console.WriteLine("Vybral jste cislo mimo rozsah");
        break ;

}
*/


/*
Console.WriteLine("Ocitl jsi se před casinem, vejdeš dovnitř? Y/N");
string vstup = Console.ReadLine();

if(vstup == "N" | vstup == "n") {

    Console.WriteLine("Vzbudil jsi se ze snu...");
    
}

else if(vstup == "Y" | vstup == "y") {

    Console.WriteLine("LETS GO GAMBLING 777");
    Thread.Sleep(2000);
    Console.WriteLine("V casinu jsi došel k hlavnimu stánku a poprosil paní o žetony v hodnotě 1000kč");
    Thread.Sleep(2000);
    Console.WriteLine("Mezi tím ti  vysvětlila pravidla");
    Thread.Sleep(2000);
    Console.WriteLine("Na začátku si vsadíte libovolnou částku, potom se ze stroje vytvoří 3 číslo od 1-3");
    Thread.Sleep(2000);
    Console.WriteLine("Jestlǐže vám padnou 2 stejná čísla vyhráváte 2x dané částky, kterou jste vsadit");
    Thread.Sleep(2000);
    Console.WriteLine("Jestliže vám padnou 3 stejná čísla vyhráváte 10x dáné částky");
    Thread.Sleep(2000);
    Console.WriteLine("Jestliže se žádná čísla nebudou shodovat prohráváte");
    Thread.Sleep(2000);
    Console.WriteLine("Z casina Vás vyhodíme potom co jste broke");
    Thread.Sleep(2000);
    Console.WriteLine("Jak pomalu přicházíš k stroji jsi najednou ovlivněn desítky let gamblingové addikce tvé rodiny");
    Thread.Sleep(2000);
    Console.WriteLine("The house always win? Nah id win");
    Thread.Sleep(2000);
    

    int penize = 1000;
    while(penize != 0)
    {
        
        Console.WriteLine("Vložte prosím částku máte teď " + penize);
        Thread.Sleep(1000);
        string sazka = Console.ReadLine();
        bool cnebop = int.TryParse(sazka, out int castka);
        bool ok = sazka == "exit";
        if(cnebop == false) {
            Console.WriteLine("Are you trying to bet with words bro? GET OUT");
            } 
            
            else {
                if (ok == true)
                {
                Console.WriteLine("Odešel jsi z kasina s " + penize + " a s hanbou");
                break;
            }

             else {
            if (castka > penize) {
                 Console.WriteLine("Not enough money vro");
                break;     
                    }
                    else {

                        penize -= castka;
                         Random rnd1 = new Random();
                         Console.WriteLine(rnd1.Next(1,4));
                         Thread.Sleep(1000);
                         int rnd11 = rnd1.Next(1,3);
                         Random rnd2 = new Random();
                         int rnd22 = rnd2.Next(1,3);
                         Console.WriteLine(rnd1.Next(1,4));
                         Thread.Sleep(1000);
                         Random rnd3 = new Random();
                         Console.WriteLine(rnd3.Next(1,4));
                         Thread.Sleep(1000);
                         int rnd33 = rnd3.Next(1,3);


                         if(rnd11 == rnd22 && rnd22 == rnd33 && rnd33 == rnd11) {
                            int vyhra2 = castka * 10;
                            penize += vyhra2;
                            Console.WriteLine("HOLY SHIT BRO U WON U ACTUALY WON " + vyhra2 + "!");
                            Thread.Sleep(1000);

                         }

                         else if (rnd11 == rnd22 | rnd22 == rnd33 | rnd33 == rnd11) 
                         {
                            int vyhra = castka * 2;
                            penize += vyhra;
                            Console.WriteLine("Congrats bro you won " + vyhra + "!");
                            Thread.Sleep(1000);
                         }

                             else {

                                Console.WriteLine("Womp Womp try again");
                                Thread.Sleep(1000);

                             }


                    }
       
                }

      if (penize == 0)
        {
            Console.WriteLine("You got kicked out cuz ur broke *sad*");
        }
            }
    
    }

}

*/

/*
Console.WriteLine("Zadejte první číslo");
int cislo1 = int.Parse(Console.ReadLine());
Console.WriteLine("Zadejte druhé číslo");
int cislo2 = int.Parse(Console.ReadLine());
Console.WriteLine(Math.Max(cislo1, cislo2));


Console.WriteLine("Zadejte desetine cislo");
double desetinecislo = double.Parse(Console.ReadLine());
double round = Math.Round(desetinecislo);
Console.WriteLine(round);
*/
/*
Console.WriteLine("Zadejte cislo 5");
int cislo = int.Parse(Console.ReadLine());
double power = Math.Pow(cislo, 2);
Console.WriteLine(power);
Console.WriteLine("Zadejte cislo 81");
int cislo1 = int.Parse(Console.ReadLine());
double square = Math.Sqrt(cislo1);
Console.WriteLine(square);
*/

/*
class Program
{
    static void Main()
    {
        Console.WriteLine("Zadejte poloměr");
        double polomer =  double.Parse(Console.ReadLine());
        double pi = Math.PI;
        Console.WriteLine("Obvod kruhu je " + polomer*2*pi);

        
    
    }

}
*/


class Program
{
    static void Main()
    {
        Console.WriteLine("Napiš slovo");
        string slovo = Console.ReadLine();
        char[] samohlasky = {'a', 'e', 'i', 'o', 'u'};
        int pocet = 0;
        foreach (char znak in slovo)
                {
                        if(samohlasky.Contains(znak))
                        pocet++;
                }

        Console.WriteLine("Počet samohlaskek v slově je " + pocet);
    }

}
