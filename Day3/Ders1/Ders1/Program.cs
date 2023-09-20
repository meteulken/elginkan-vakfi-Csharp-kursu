using System;

Console.Write("Bir ay ismi giriniz :");

string a = Console.ReadLine().ToLower();

switch (a)
{
    case "aralık":
    case "ocak":
    case "subat":
        Console.WriteLine("KIŞ");
        break;
    case "mart":
    case "nisan":
    case "mayis":
        Console.WriteLine("İLKBAHAR");
        break;

}