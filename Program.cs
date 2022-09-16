// See https://aka.ms/new-console-template for more information

//Snack 1:

//Chiedo all'user il primo numero
Console.WriteLine("Ciao User, scegli un numero");
int firstNumber = Convert.ToInt32(Console.ReadLine());

//Chiedo all'user il secondo numero
Console.WriteLine("Scegli il secondo numero");
int secondNumber = Convert.ToInt32(Console.ReadLine());

if (firstNumber > secondNumber)
{
    Console.WriteLine($"{firstNumber} è maggiore di {secondNumber}");
}
else
{
    Console.WriteLine($"{secondNumber} è maggiore di {firstNumber}");
}

//Snack 2:

//User inserisce due parole, prima stampo la più corta poi la più lunga

//Chiedo all'user la prima parola
Console.WriteLine("Ciao User, scegli una parola");
string firstWord = Console.ReadLine();

//Chiedo all'user il secondo numero
Console.WriteLine("Scegli una seconda parola");
string secondWord = Console.ReadLine();

if (firstWord.Length > secondWord.Length)
{
    Console.WriteLine($"La parola {secondWord} è più corta di {firstWord}");
}
else
{
    Console.WriteLine($"La parola {firstWord} è più corta di {secondWord}");
}

//Snack 3:
//Chiedo 10 volte all'utente di inserire un numero + stampo somma tutti numeri

int totalNumber = 0;

for (int i = 0; i < 10; i++)
{
    Console.WriteLine("Digita un numero");
    int number = Convert.ToInt32(Console.ReadLine());
    totalNumber += number;
}

Console.WriteLine($"La somma dei numeri che hai digitato è {totalNumber}");

//Snack 4 calcola la somma e la media dei numeri da 2 a 10

int[] number = { 2, 3, 4, 5, 6, 7, 8, 9, 10 };

int sumNumbers = 0;

for (int i = 0; i < number.Length; i++)
{
    sumNumbers += number[i];
}

Console.WriteLine($"La somma dei numeri è {sumNumbers}");

//Calcolo media
int numberLength = number.Length;
int mediaNumber = sumNumbers / numberLength;

Console.WriteLine($"La media dei numeri è {mediaNumber}");

//Snack 5 il software chiede un numero all'utente, se è pari stampa numero, se dispari, stampa numero successivo.

for (int i = 0; i < 10; i++)
{
    Console.WriteLine("Ciao User, scegli un numero");

    int userNumber = Convert.ToInt32(Console.ReadLine());

    if (userNumber % 2 == 0)
    {
        Console.WriteLine($"Il numero che hai digitato è {userNumber}, viene visualizzato poichè è pari");
        break;
    }
    else
    {
        Console.WriteLine("Hai scelto un numero dispari, scegli un'altro numero");
    }
}

// Snack 6

string[] name = { "Thomas", "Anderson", "Michael", "Alexander", "Heisenberg" };

Console.WriteLine("Benvenuto alla festa Sr. Può cortesemente dirmi il suo nome?");

string guestName = Console.ReadLine();

for (int i = 0; i < name.Length; i++)
{
    if (guestName == name[i])
    {
        Console.WriteLine($"Benvenuto alla festa {guestName}, si diverta");
    }
    else
    {
        Console.WriteLine($"Spiacente Sr. il suo nome non è sulla lista degli ospiti");
    }
    break;
}

/// Snack 7

int[] emptyArray = new int[6];

for (int i = 0; i < 6; i++)
{
    Console.WriteLine("Ciao User, digita un numero");
    int userNumber = Convert.ToInt32(Console.ReadLine());

    if (userNumber % 2 == 1 && userNumber != 0)
    {
        emptyArray[i] = userNumber;
    }
}

foreach (int j in emptyArray)
{
    Console.Write(j);
}



//Snack 8:

int[] numbers = { 10, 20, 14, 18, 25, 37, 50, 80, 28, 30 };

int sum = 0;

for (int i = 0; i < numbers.Length; i++)
{
    int index = Array.IndexOf(numbers, numbers[i]);

    if (index % 2 == 1)
    {
        sum += numbers[i];
    }
}
Console.WriteLine(sum);

//Snack 9:

int[] emptyArray = new int[20];

int summ = 0;

while (summ < 50)
{
    Console.WriteLine("Ciao User, digita un numero");
    int userNumber = Convert.ToInt32(Console.ReadLine());
    emptyArray[0] += userNumber;
    summ += userNumber;
}
foreach (int j in emptyArray)
{
    Console.Write(j);
}

// Snack 10

Console.WriteLine("Ciao user inserisci un numero");
int usernumber = Convert.ToInt32(Console.ReadLine());

int[] randomArray = new int[10];
