// using System;
// using System.Collections.Generic;

// class PracaSamodzielna3
// {
//     static void Main()
//     {
//         string[] items = { "Mikstura życia", "Mikstura many", "Antidotum", "Zwój teleportu", "Bomba dymna" };
//         List<string> inventory = new List<string>();

//         AddItem(inventory, items, 2);

//         Random rng = new Random();
//         AddRandomItem(inventory, items, rng);

//         // Sprawdzanie zapełnienia ekwipunku
//         if (IsInventoryFull(inventory, 5))
//             Console.WriteLine("Plecak jest pełny!");

//         // Sprawdzanie posiadania przedmiotu w ekwipunku
//         if (HasItem(inventory, "Klucz"))
//             Console.WriteLine("Możesz otworzyć drzwi!");

//         // Usuwanie przedmiotu po nazwie
//         UseItem(inventory, "Mikstura życia");

//         // Usuwanie przedmiotu po numerze
//         if (inventory.Count > 0)
//             DropItem(inventory, rng.Next(0, inventory.Count));

//         // Wyświetlenie końcowej zawartości ekwipunku
//         Console.WriteLine("\nZawartość ekwipunku:");
//         foreach (var item in inventory)
//         {
//             Console.WriteLine("- " + item);
//         }
//     }
// // Dodawanie przedmiotu z tablicy items do listy inventory na podstawie indeksu. Wyświetl komunikat o dodaniu przedmiotu.
//     static void AddItem(List<string> inventory, string[] items, int index)
//     {
//         // Kod tutaj 
//     }
// // Dodawanie losowego przedmiotu z tablicy items do listy inventory. Wyświetl komunikat o dodaniu przedmiotu.
//     static void AddRandomItem(List<string> inventory, string[] items, Random rng)
//     {
//        // Kod tutaj
//     }

// // Sprawdzanie, czy ekwipunek jest pełny
//     static bool IsInventoryFull(List<string> inventory, int maxSize)
//     {
//         // Kod tutaj
//     }

// // Sprawdzanie, czy gracz posiada dany przedmiot w ekwipunku
//     static bool HasItem(List<string> inventory, string item)
//     {
//         // Kod tutaj
//     }
// // Usuwanie przedmiotu z ekwipunku po nazwie. Po użyciu przedmiotu, wyświetl komunikat o jego użyciu i go usuń z listy (zepsuł się :( )
//     static void UseItem(List<string> inventory, string item)
//     {
//       // Kod tutaj
//     }
// // Wyrzucanie przedmiotu z ekwipunku po numerze
//     static void DropItem(List<string> inventory, int index)
//     {
//       // Kod tutaj
//     }
// }