static void Main()
{
	List<string> inventory = new List<string>();
	
	inventory.Add("Miecz");
	inventory.Add("Mikstura życia");
	inventory.Add("Tarcza");
	
	PrintList("EKWIPUNEK GRACZA", inventory);

}
static void PrintList(string header, List<string> list)
{
    Console.WriteLine("\n=== " + header + " ===");

    if (list.Count == 0)
    {
        Console.WriteLine("(brak elementów)");
        return;
    }

    foreach (string item in list)
    {
        Console.WriteLine("- " + item);
    }
}