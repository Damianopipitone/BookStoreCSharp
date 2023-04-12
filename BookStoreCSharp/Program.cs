// See https://aka.ms/new-console-template for more information

string BookName = "Clean Code";

string AuthorName = "Robert C. Martin";

long INumber = 9780132350884;

int PageNumber = 431;

float Widht = 17.8f;

float Height = 23.73f;

float Depth = 2.79f;

float Rating = 4.7f;

int ReviewNumbers = 5415;

bool KindleVersionIsAvailable = true;

bool CoverFlex = true;

Console.WriteLine("IL LIBRO DI OGGI:" + BookName);
Console.WriteLine("SCRITTO DA:" + AuthorName);
Console.WriteLine("ISBN:" +  INumber);
Console.WriteLine("NUMERO DI PAGINE:" + PageNumber);
Console.WriteLine("DIMENSIONI:" + Widht + "x" + Height + "x" + Depth);
Console.WriteLine("RECENSIONI:" + Rating + "/" + ReviewNumbers + " Recensioni");

if (KindleVersionIsAvailable == true && CoverFlex == true)
{
    Console.WriteLine("È disponibile la versione per Kindle e con la copertina flessibile");
};

