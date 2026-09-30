// /*Stwórz trzy 5-cio elementowe tablice przechowujące informację o przedmiotach, uzbrojeniu i pancerzu możliwych do zdobycia w grze. 
// Wypisz te elementy na ekran.*/
using System;
using System.Collections.Generic;

string[] items = { "Mikstura życia", "Mikstura many", "Antidotum", "Zwój teleportu", "Bomba dymna" };
string[] weapons = { "Miecz", "Topór", "Łuk", "Kusza", "Kostur" };
string[] armor = {"Hełm", "Napierśnik", "Rękawice", "Buty", "Tarcza" };

Console.WriteLine("=== PRZEDMIOTY ===");
for (int i = 0; i < items.Length; i++)
{
    Console.WriteLine("- " + items[i]);
}

Console.WriteLine("\n=== UZBROJENIE ===");
for (int i = 0; i < weapons.Length; i++)
{
    Console.WriteLine("- " + weapons[i]);
}

Console.WriteLine("\n=== PANCERZE ===");
for (int i = 0; i < armor.Length; i++)
{
    Console.WriteLine("- " + armor[i]);
}

