using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input; //Keyinput
using System.Threading; //Timer
using static System.Math; //Mathe Klasse


namespace Operatoren_Hinweise
{
    class Program
    {
        static void Main(string[] args)
        {
            string strTitle = "Operatoren Hilfe Version 1.0";
            Console.Title = strTitle;
            Console.BackgroundColor = ConsoleColor.Black; //Hintergrund: Schwarz
            Console.ForegroundColor = ConsoleColor.Green; //Schrift: Grün
            Console.Clear(); //cleart die Konsole

            Console.WriteLine();
            Console.WriteLine("Willkommen bei der {0}, du erinnerst dich nicht mehr was welcher Operator macht?", strTitle);
            Console.WriteLine("Kein Problem, ich bin dafür da um dir dabei zu helfen, wähle einfach eine Art von Operatoren aus.\n");
            Console.WriteLine("Alle Infos stammen aus dem Buch Visual C# 2005 von Andreas Kühnel.\n\n");

            //Thread.Sleep(1500); //warte 1,5 sekunden

            Kapitelauswahl();
        }

        static void Kapitelauswahl()
        {
            //Fragen um welchen Operator Bereich es gehen soll.

            Console.WriteLine("Über welche Art von Operatoren möchtest du etwas wissen?");
            Console.WriteLine("Du hast die Wahl zwischen:\n");

            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.WriteLine("1. Arithmetische Operatoren");
            Console.WriteLine("2. Vergleichs Operatoren");
            Console.WriteLine("3. Logische Operatoren");
            Console.WriteLine("4. Bitweise Operatoren");
            Console.WriteLine("5. Zuweisungs Operatoren");
            Console.WriteLine("6. Sonstige Operatoren\n");
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine("Zusatz Kapitel: \n");
            Console.WriteLine("7. Taschenrechner");
            Console.WriteLine("8. Programm beenden\n");
            Console.ForegroundColor = ConsoleColor.Green;

           
            Console.WriteLine("Bitte wähle eine Option anhand der Zahlen!");

            //Zahl auslesen

            //error code wenn keine zahl zwischen 1 und 6 gewählt wurde
            errorcode0:;
            Console.ForegroundColor = ConsoleColor.Blue;
            string strKapitel = Console.ReadLine();
            Console.ForegroundColor = ConsoleColor.Green;

            Console.Clear();

            switch (strKapitel)
            {
                case "1":
                    Arithmetisch();
                    break;
                case "2":
                    Vergleichs();
                    break;
                case "3":
                    Logische();
                    break;
                case "4":
                    Bitweise();
                    break;
                case "5":
                    Zuweisung();
                    break;
                case "6":
                    Sonstige();
                    break;
                case "7":
                    //Taschenrechner();
                    break;
                case "8":
                    Environment.Exit(0);
                    break;
                default:
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Bitte wähle eine gültige Zahl aus, zwischen 1 und 6\a\n");
                    Console.ForegroundColor = ConsoleColor.Green;
                    goto errorcode0;
                    ;

            }

        }

        static void Arithmetisch()
        {
            Console.WriteLine();
            Console.WriteLine("Du hast dich für die Arithmetische Operatoren entschieden.\n");
            Console.WriteLine("Über welchen Arithmetische Operator möchtest du etwas wissen?");
            Console.WriteLine("Du hast die Auswahl zwischen:\n");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(" 1:  + \n 2:  - \n 3:  * \n 4:  / \n 5:  % \n 6:  ++ \n 7:  --\n");

            errorcode1:;

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Bitte gebe deine Auswahl ein:\n");
            Console.ForegroundColor = ConsoleColor.Red;
            string strAuswahl = Console.ReadLine();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Clear();


            switch (strAuswahl)
            {
                case "1":
                    Console.WriteLine();
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write(" + ");
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Hat zwei Funktionalitäten: ");
                    Console.WriteLine("> Als Additionsoperator bildert er die Summe zweier Operanden (x + y).");
                    Console.WriteLine("> Als Vorzeichenoperator beschreibt er eine positive Zahl (+x),\nalso ein einstelliger (unärer) Operator.\n");
                    break;
                case "2":
                    Console.WriteLine();
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write(" - ");
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Hat zwei Funktionalitäten: ");
                    Console.WriteLine("> Als Substraktionsoperator eingesetzt bildet er eine Differenz zwei Operanden (x - y).");
                    Console.WriteLine("> Als unärer Vorzeichenoperator beschreibt er eine negative Zahl (-x).\n");
                    break;
                case "3":
                    Console.WriteLine();
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write(" * ");
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Multiplikationsoperator, multipliziert zwei Operanden (x * y).\n");
                    break;
                case "4":
                    Console.WriteLine();
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write(" / ");
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Divisionsoperator, dividiert zwei Operanden (x / y),\n behält den Nachkommateil der Division.\n");
                    break;
                case "5":
                    Console.WriteLine();
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write(" % ");
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Restwertoperator, dividiert zwei Operanden und \nliefert das Ergebnis den Restwert der Operation (x % y).\n");
                    Console.WriteLine("beispiel: \n\n int x = 100;\n int y = 17;\n");
                    int x = 100, y = 17;
                    Console.WriteLine("Division mit % - Ergebnis = {0}\n", x % y);
                    Console.WriteLine("Die 17 passt 5x in die 100, der Rest der dann ausgegben wird ist 15 da:\n 5 * 17 = 85\nRest zu Hundert wäre somit 15.\n");
                    break;
                case "6":
                    Console.WriteLine();
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write(" ++ ");
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Erhöht den Inhalt eines Operanden um 1. Das Ergebnis der Operation ++x ist der Wert\ndes Operanden nach der Erhöhung (Präfixinkrementoperation).");
                    Console.WriteLine("Das Ergebnis der Operation x++ ist der Wert des Operanden vor der Erhöhung (Postpräfixinkrementoption.)");
                    break;
                case "7":
                    Console.WriteLine();
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write(" -- ");
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Verringert den Inhalt eines Operanden um 1. Das Ergebnis der Operation --x ist der Wert\ndes Operanden nach der Verringerung (Präfixdekrementoperation).");
                    Console.WriteLine("Das Ergebnis der Operation x-- ist der Wert des Operanden vor der Verringerung (Postfixdekrementoption.)");
                    break;
                default:
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Bitte wähle eine gültige Zahl aus, zwischen 1 und 6\a\n");
                    Console.ForegroundColor = ConsoleColor.Green;
                    goto errorcode1;
            }

            ExitArithmetisch();
        }

        static void Vergleichs()
        {
            Console.WriteLine();
            Console.WriteLine("Du hast dich für die Vergleichs Operatoren entschieden.\n");
            Console.WriteLine("Über welchen Vergleichs Operator möchtest du etwas wissen?");
            Console.WriteLine("Du hast die Auswahl zwischen:\n");

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(" 1:  == \n 2:  != \n 3:  > \n 4:  < \n 5:  <= \n 6:  >= \n");
            Console.ForegroundColor = ConsoleColor.Green;

            errorcode2:;

            Console.WriteLine("Bitte gebe deine Auswahl ein:\n");

            Console.ForegroundColor = ConsoleColor.Red;
            string strAuswahl = Console.ReadLine();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Clear(); //für alle übernehmen, cleart die auswahl, sodass nur das ergebnis angezeigt wird.

            switch (strAuswahl)
            {
                case "1":
                    Console.WriteLine();
                    Console.Write("a ");
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write("== ");
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write("b (Vergleichsoperator) prüft, ob der Ausdruck a dem Ausdruck b entspricht,\nund gibt in diesem Fall true zurück.\n\n");
                    break;
                case "2":
                    Console.WriteLine();
                    Console.Write("a ");
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write("!= ");
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("b Ergebnis der Operation ist true, wenn a ungleich b ist.\n");
                    break;
                case "3":
                    Console.WriteLine();
                    Console.Write("a ");
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write("> ");
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("b Ergebnis der Operation ist true, wenn a größer b ist.\n");
                    break;
                case "4":
                    Console.WriteLine();
                    Console.Write("a ");
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write("< ");
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("b Ergebnis der Operation ist true, wenn a kleiner b ist.\n");
                    break;
                case "5":
                    Console.WriteLine();
                    Console.Write("a ");
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write("<= ");
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("b Ergebnis der Operation ist true, wenn a kleiner oder gleich b ist.\n");
                    break;
                case "6":
                    Console.WriteLine();
                    Console.Write("a= ");
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write(">= ");
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("b Ergebnis der Operation ist true, wenn a gößer oder gleich b ist.\n");
                    break;
                default:
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Bitte wähle eine gültige Zahl aus, zwischen 1 und 6\a\n");
                    Console.ForegroundColor = ConsoleColor.Green;
                    goto errorcode2;
            }

            ExitVergleichs();
        }

        static void Logische()
        {
            Console.WriteLine();
            Console.WriteLine("Du hast dich für die Logischen Operatoren entschieden.\n");
            Console.WriteLine("Über welchen Logischen Operator möchtest du etwas wissen?");
            Console.WriteLine("Du hast die Auswahl zwischen:\n");

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(" 1:  ! \n 2:  & \n 3:  | \n 4:  ^ \n 5:  && \n 6:  ||");
            Console.ForegroundColor = ConsoleColor.Green;

            errorcode3:;

            Console.WriteLine("Bitte gebe deine Auswahl ein:\n");

            Console.ForegroundColor = ConsoleColor.Red;
            string strAuswahl = Console.ReadLine();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Clear();

            switch (strAuswahl)
            {
                case "1":
                    Console.WriteLine();
                    Console.Write("Unärer Negationsoperator. Der Ausdruck ");
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write("!");
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write("a ist true, wenn a einen unwahren Wert beschreibt, und false, wenn a wahr ist.\n\n");
                    break;
                case "2":
                    Console.WriteLine();
                    Console.Write("(And-Operator/1.Variante). Der Ausdruck a ");
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write("& ");
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write("b ist dann true, wenn sowohl a als auch b true sind.\nDabei werden in jedem Fall beide Asdrücke gewertet.\n");
                    break;
                case "3":
                    Console.WriteLine();
                    Console.Write("(Or-Operator/1.Variante). Der Ausdruck a ");
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write("| ");
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write("b ist true, wenn entweder a oder b wahr ist.\nDabei werden in jedem Fall beide Asdrücke gewertet.\n");
                    break;
                case "4":
                    Console.WriteLine();
                    Console.Write("(Xor-Operator). Derr Ausdruck a ");
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write("^ ");
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("b ist true. wenn die beiden beteiligten Operanden unterscheidliche Wahrheitswerte haben.\n");
                    break;
                case "5":
                    Console.WriteLine();
                    Console.Write("(And-Operator/2.Variante). Der Ausdruck a ");
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write("&& ");
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("b ist dann true, wenn sowohl a als auch b true sind. Zuerst wird a ausgewertet.");
                    Console.WriteLine("Sollte a false sein, wird ist in jedem Fall der Gesamtausdruck unabhängig\nvon b auch falsch. b wird dann nicht mehr ausgewertet");
                    break;
                case "6":
                    Console.WriteLine();
                    Console.Write("Or - Operator / 2.Variante). Der Ausruck a ");
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write("|| ");
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("b ist true, wenn entweder a oder b true ist. Zuerst wird a ausgewertet.");
                    Console.WriteLine("Sollte a bereits true sein, ist in jedem Fall der Gesamtausdruck unabhängig\nvon b auch wahr. b wird dann nicht mehr ausgewertet");
                    break;
                default:
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Bitte wähle eine gültige Zahl aus, zwischen 1 und 6\a\n");
                    Console.ForegroundColor = ConsoleColor.Green;
                    goto errorcode3;
            }

            ExitLogische();
        }

        static void Bitweise()
        {
            Console.WriteLine();
            Console.WriteLine("Du hast dich für die Bitweise Operatoren entschieden.\n");
            Console.WriteLine("Über welchen Bitweise Operator möchtest du etwas wissen?");
            Console.WriteLine("Du hast die Auswahl zwischen:\n");

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(" 1:  ~ \n 2:  | \n 3:  & \n 4:  ^ \n 5:  << \n 6:  >> \n");
            Console.ForegroundColor = ConsoleColor.Green;

            errorcode4:;

            Console.WriteLine("Bitte gebe deine Auswahl ein:\n");

            Console.ForegroundColor = ConsoleColor.Red;
            string strAuswahl = Console.ReadLine();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Clear();

            switch (strAuswahl)
            {
                case "1":
                    Console.WriteLine();
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write(" ~ ");
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write("Invertiert jedes Bit des Ausdrucks (Einerkomplement).\n");
                    break;
                case "2":
                    Console.WriteLine();
                    Console.WriteLine("Aus x");
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write(" | ");
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("y resultiert ein Wert, bei dem die korresponierenden Bits von x und y");
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write(" Or");
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("-verknüpft werden.\n");
                    break;
                case "3":
                    Console.WriteLine();
                    Console.WriteLine("Aus x");
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write(" & ");
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("y resultiert ein Wert, bei dem die korresponierenden Bits von x und y");
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write(" And");
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("-verknüpft werden.\n");
                    break;
                case "4":
                    Console.WriteLine();
                    Console.WriteLine("Aus x");
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write(" ^ ");
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("y resultiert ein Wert, bei dem die korresponierenden Bits von x und y");
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write(" Xor");
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("-verknüpft werden.\n");
                    break;
                case "5":
                    Console.WriteLine();
                    Console.WriteLine("Aus x");
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write(" << ");
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("y resultiert ein Wert, der durch die Verschiebung der Bits des ersten Operanden\num die durch im zweiten Operanden y angegebene Zahl nach links steht.\n");
                    break;
                case "6":
                    Console.WriteLine();
                    Console.WriteLine("Aus x");
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write(" >> ");
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("y resultiert ein Wert, der durch die Verschiebung der Bits des ersten Operanden\num die durch im zweiten Operanden y angegebene Zahl nach rechts steht.\n");
                    break;
                default:
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Bitte wähle eine gültige Zahl aus, zwischen 1 und 6\a\n");
                    Console.ForegroundColor = ConsoleColor.Green;
                    goto errorcode4;
            }

            ExitBitweise();
        }

        static void Zuweisung()
        {
            Console.WriteLine();
            Console.WriteLine("Du hast dich für die Zuweisungs Operatoren entschieden.\n");
            Console.WriteLine("Über welchen Zuweisungs Operator möchtest du etwas wissen?");
            Console.WriteLine("Du hast die Auswahl zwischen:\n");

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(" 1:  = \n 2:  += \n 3:  -= \n 4:  *= \n 5:  /= \n 6:  %= \n 7:  &= \n 8:  |= \n 9:  ^= \n 10:  <<= \n 11:  >>= \n");
            Console.ForegroundColor = ConsoleColor.Green;

            errorcode5:;

            Console.WriteLine("Bitte gebe deine Auswahl ein:\n");

            Console.ForegroundColor = ConsoleColor.Blue;
            string strAuswahl = Console.ReadLine();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Clear();

            switch (strAuswahl)
            {
                case "1":
                    Console.WriteLine();
                    Console.Write("x ");
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write("= ");
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write("y weist x den wert von y zu.\n");
                    break;
                case "2":
                    Console.WriteLine();
                    Console.Write("x ");
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write("+= ");
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("y weist x den Wert von y zu.\n");
                    break;
                case "3":
                    Console.WriteLine();
                    Console.Write("x ");
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write("-= ");
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("y weist x den Wert von x - y zu.\n");
                    break;
                case "4":
                    Console.WriteLine();
                    Console.Write("x ");
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write("*= ");
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("y weist x den Wert von x * y zu.\n");
                    break;
                case "5":
                    Console.WriteLine();
                    Console.Write("x ");
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write("/= ");
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("y weist x den wert von x / y zu.\n");
                    break;
                case "6":
                    Console.WriteLine();
                    Console.Write("x ");
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write("%= ");
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("y weist x den wert von x % y zu.\n");
                    break;
                case "7":
                    Console.WriteLine();
                    Console.Write("x ");
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write("&= ");
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("y weist x den wert von x & y zu.\n");
                    break;
                case "8":
                    Console.WriteLine();
                    Console.Write("x ");
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write("|= ");
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("y weist x den wert von x | y zu.\n");
                    break;
                case "9":
                    Console.WriteLine();
                    Console.Write("x ");
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write("^= ");
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("y weist x den wert von x ^ y zu.\n");
                    break;
                case "10":
                    Console.WriteLine();
                    Console.Write("x ");
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write("<<= ");
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("y weist x den wert von x << y zu.\n");
                    break;
                case "11":
                    Console.WriteLine();
                    Console.Write("x ");
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write(">>= ");
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("y weist x den wert von x >> y zu.\n");
                    break;
                default:
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Bitte wähle eine gültige Zahl aus, zwischen 1 und 6\a\n");
                    Console.ForegroundColor = ConsoleColor.Green;
                    goto errorcode5;
            }

            ExitZuweisung();
        }

        static void Sonstige()
        {
            Console.WriteLine();
            Console.WriteLine("Du hast dich für die Sonstigen Operatoren entschieden.\n");
            Console.WriteLine("Über welchen Sonstigen Operator möchtest du etwas wissen?");
            Console.WriteLine("Du hast die Auswahl zwischen:\n");

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(" 1:  . \n 2:  [] \n 3:  () \n 4:  ?: \n 5:  new \n 6:  is \n 7:  typeof \n 8:  checked/unchecked \n");
            Console.ForegroundColor = ConsoleColor.Green;

            errorcode6:;

            Console.WriteLine("Bitte gebe deine Auswahl ein:\n");

            Console.ForegroundColor = ConsoleColor.Blue;
            string strAuswahl = Console.ReadLine();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Clear();

            switch (strAuswahl)
            {
                case "1":
                    Console.WriteLine();
                    // Console.WriteLine("Der Punktoperator wird für den Zugriff auf Eigenschaften oder\nMethoden einer Klasse verwendet, z.B. Console.ReadLine();\n");
                    Console.Write("Der ");
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write(". Operator(Punktoperator) ");
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("wird für den Zugriff auf Eigenschaften oder\nMethoden einer Klasse verwendet, z.B. Console.ReadLine();\n");
                    break;
                //goto zurück;
                case "2":
                    Console.WriteLine();
                    Console.Write("Der ");
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write("[] ");
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Operator wird für Arrays, Indexer und Attribute verwendet, z.B. arr[10]\n");
                    break;
                case "3":
                    Console.WriteLine();
                    Console.Write("Der ");
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write("[] ");
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Der () Operator dient zwei Zwecken: Er gibt die Reihenfolge der Operationen vor\nund wird auch zur Typkonvertierung eingesetzt.\n");
                    break;
                case "4":
                    Console.WriteLine();
                    Console.Write("Der ");
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write("?: ");
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Operator gibt einen von zwei Werten in Abhängigkeit von einem dritten zurück.\n Er ist eine einfache Variante der if-Bedingungsprüfung,\n");
                    break;
                case "5":
                    Console.WriteLine();
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write(" new ");
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Dient zur Instanzierung einer Klasse,\n");
                    break;
                case "6":
                    Console.WriteLine();
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write(" is ");
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Prüft den Laufzeittyp eines Objekts mit dem angegebenen Typ.\n");
                    break;
                case "7":
                    Console.WriteLine();
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write(" type of ");
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Ruft das System.Type-Objekt für einen Typ ab.\n");
                    break;
                case "8":
                    Console.WriteLine();
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write(" checked / unchecked ");
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Steuerung der Reaktion der Laufzeit bei einem arithmetischen Überlauf.\n");
                    break;
                default:
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Bitte wähle eine gültige Zahl aus, zwischen 1 und 6\a\n");
                    Console.ForegroundColor = ConsoleColor.Green;
                    goto errorcode6;

            }

            ExitSonstige();

        }


        //static void Taschenrechner()
        //{
        //    Console.WriteLine("Willkommen im Taschenrechner, wir laufen auf Version 1.0\n");

        //    errorcoderechner:;

        //    Console.WriteLine("Bitte wähle eine Option: \n");
        //    Console.ForegroundColor = ConsoleColor.Green;

        //    Console.WriteLine("1:  +");
        //    Console.WriteLine("2:  -");
        //    Console.WriteLine("3:  *");
        //    Console.WriteLine("4:  /");
        //    Console.WriteLine("5:  % aka Prozent");
        //    Console.WriteLine("6:  % alias Modulus");

        //    Console.ResetColor();

        //    string strARechner = Console.ReadLine();
        //    Console.Clear();

        //    switch (strARechner)
        //    {
        //        case "1":
        //            Addition();
        //            break;
        //        case "2":
        //            Substraktion();
        //            break;
        //        case "3":
        //            Mulitiplikation();
        //            break;
        //        case "4":
        //            Dividieren();
        //            break;
        //        case "5":
        //            Prozent();
        //            break;
        //        case "6":
        //            Modulus();
        //            break;
        //        default:
        //            Console.WriteLine("Wähle eine gültige Auwsahl!");
        //            goto errorcoderechner;
        //    }

        //    Console.ReadLine();

        //}

        //static void Addition()
        //{
           

        //}

        //static void Substraktion()
        //{

        //}

        //static void Mulitiplikation()
        //{

        //}

        //static void Dividieren()
        //{

        //}

        //static void Prozent()
        //{

        //}

        //static void Modulus()
        //{

        //}



        static void ExitArithmetisch()
        {
            //lieber ne eigene funktion machen anstatt das selbe ding gefühlt 60x zu pasten, die arme performance O.o
            Console.WriteLine("Was Möchtest du tun?\n");
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine(" 1. Zurück zur Operator auswahl des Kapitels Arithmetische Operatoren\n 2. Zurück zur Kapitelauswahl\n 3. für Programm beenden\n");
            Console.ForegroundColor = ConsoleColor.Green;

            short shtZurück = Convert.ToInt16(Console.ReadLine());
            Console.Clear();
            if (shtZurück == 1)
                Arithmetisch();
            else if (shtZurück == 2)
                Kapitelauswahl();
            else
                Console.WriteLine("Ich Hoffe ich konnte dir helfen :)\n");
            Thread.Sleep(3000);
                Environment.Exit(0); //schließt das Konsolenfenster
        }

        static void ExitVergleichs()
        {
            //lieber ne eigene funktion machen anstatt das selbe ding gefühlt 60x zu pasten, die arme performance O.o
            Console.WriteLine("Was Möchtest du tun?\n");
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine(" 1. Zurück zur Operator auswahl des Kapitels Vergleichs Operatoren\n 2. Zurück zur Kapitelauswahl\n 3. für Programm beenden\n");
            Console.ForegroundColor = ConsoleColor.Green;

            short shtZurück = Convert.ToInt16(Console.ReadLine());
            Console.Clear();

            if (shtZurück == 1)
                Vergleichs();
            else if (shtZurück == 2)
                Kapitelauswahl();
            else
                Console.WriteLine("Ich Hoffe ich konnte dir helfen :)\n");
            Thread.Sleep(3000);
            Environment.Exit(0); //schließt das Konsolenfenster
        }

        static void ExitLogische()
        {
            //lieber ne eigene funktion machen anstatt das selbe ding gefühlt 60x zu pasten, die arme performance O.o
            Console.WriteLine("Was Möchtest du tun?\n");
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine(" 1. Zurück zur Operator auswahl des Kapitels Logische Operatoren\n 2. Zurück zur Kapitelauswahl\n 3. für Programm beenden\n");
            Console.ForegroundColor = ConsoleColor.Green;

            short shtZurück = Convert.ToInt16(Console.ReadLine());
            Console.Clear();

            if (shtZurück == 1)
                Logische();
            else if (shtZurück == 2)
                Kapitelauswahl();
            else
                Console.WriteLine("Ich Hoffe ich konnte dir helfen :)\n");
            Thread.Sleep(3000);
            Environment.Exit(0); //schließt das Konsolenfenster
        }

        static void ExitBitweise()
        {
            //lieber ne eigene funktion machen anstatt das selbe ding gefühlt 60x zu pasten, die arme performance O.o
            Console.WriteLine("Was Möchtest du tun?\n");
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine(" 1. Zurück zur Operator auswahl des Kapitels Bitweise Operatoren\n 2. Zurück zur Kapitelauswahl\n 3. für Programm beenden\n");
            Console.ForegroundColor = ConsoleColor.Green;

            short shtZurück = Convert.ToInt16(Console.ReadLine());
            Console.Clear();

            if (shtZurück == 1)
                Bitweise();
            else if (shtZurück == 2)
                Kapitelauswahl();
            else
                Console.WriteLine("Ich Hoffe ich konnte dir helfen :)\n");
            Thread.Sleep(3000);
            Environment.Exit(0); //schließt das Konsolenfenster
        }

        static void ExitZuweisung()
        {
            //dann halt doch aber nur maximal 6 mal also alles easy
            Console.WriteLine("Was Möchtest du tun?\n");
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine(" 1. Zurück zur Operator auswahl des Kapitels Zuweisungs Operatoren\n 2. Zurück zur Kapitelauswahl\n 3. für Programm beenden\n");
            Console.ForegroundColor = ConsoleColor.Green;

            short shtZurück = Convert.ToInt16(Console.ReadLine());
            Console.Clear();

            if (shtZurück == 1)
                Zuweisung();
            else if (shtZurück == 2)
                Kapitelauswahl();
            else
                Console.WriteLine("Ich Hoffe ich konnte dir helfen :)\n");
            Thread.Sleep(3000);
            Environment.Exit(0); //schließt das Konsolenfenster
        }

        static void ExitSonstige()
        {
            //lieber ne eigene funktion machen anstatt das selbe ding gefühlt 60x zu pasten, die arme performance O.o
            Console.WriteLine("Was Möchtest du tun?\n");
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine(" 1. Zurück zur Operator auswahl des Kapitels Sonstige Operatoren\n 2. Zurück zur Kapitelauswahl\n 3. für Programm beenden\n");
            Console.ForegroundColor = ConsoleColor.Green;

            short shtZurück = Convert.ToInt16(Console.ReadLine());
            Console.Clear();

            if (shtZurück == 1)
                Sonstige();
            else if (shtZurück == 2)
                Kapitelauswahl();
            else
                Console.WriteLine("Ich Hoffe ich konnte dir helfen :)\n");
            Thread.Sleep(3000); //wartet 3 sekunden, dann kann man nochmal die Abscheidsbotschaft lesen.
            Environment.Exit(0); //schließt das Konsolenfenster
        }

        void nimmwasdubrauchst() //war so die erste idee. aber switches sind erstens übersichtlicher und zweitens besser.
        {
            Console.WriteLine("Über welchen Logischen Operator möchtest du etwas wissen?");
            Console.WriteLine("Du hast die Auswahl zwischen ! , & , | , ^ , && und || .");
            Console.WriteLine("Bitte gebe deine Auswahl ein:\n");
            string strOperator = Console.ReadLine();



            if (strOperator == "!")
                Console.WriteLine("\n!a ist dann TRUE, wenn a einen unwahren wert beschreibt und false wenn a wahr ist.\n");
            else if (strOperator == "&")
                Console.WriteLine("\na & b ist dann TRUE, wenn sowohl a als auch b true sind.\nBeide werden ausgewertet.\n");
            else if (strOperator == "|")
                Console.WriteLine("\na | b ist dann TRUE, wenn entwerder a oder b wahr sind.\nBeide werden ausgewertet.\n");
            else if (strOperator == "^")
                Console.WriteLine("\na ^ b ist dann TRUE, wenn beide operanden (a und b) unterschiedliche Wahrheitswerte haben.\n");
            else if (strOperator == "&&")
                Console.WriteLine("\na && b ist dann TRUE, wenn sowohl a als auch b true sind.\na wird zuerst ausgewertet, ist es TRUE wird b nicht mehr gecheckt.\n");
            else if (strOperator == "||")
                Console.WriteLine("\na || b ist dann TRUE, wenn entweder a oder b true ist,\na wird zuerst ausgewertet, ist es TRUE wird b nicht mehr gecheckt,\n");

            Console.WriteLine("Beliebige Taste zum schließen drücken, r um von vorne zu starten.\n");
            string strReload = Console.ReadLine();

            if (strReload == "r")
                Console.WriteLine("\n");
            Console.Clear();
            





            //else if (strOperator != "!" || "&" || "^" || "&&" | )
            //    Console.WriteLine("Bitte gebe einen gültigen Logischen Operator ein.");
        }


    }
}
