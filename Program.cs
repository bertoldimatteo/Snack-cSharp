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

if ( firstWord.Length > secondWord.Length)
{
    Console.WriteLine($"La parola {secondWord} è più corta di {firstWord}");
}
else
{
    Console.WriteLine($"La parola {firstWord} è più corta di {secondWord}");
}