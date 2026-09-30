static void Main()
{
	string[] items = { "Mikstura życia", "Mikstura many", "Antidotum", "Zwój teleportu", "Bomba dymna" };
	List<string> inventory = new List<string>();
	
	AddItem(inventory, items, 2);

	Random rng = new Random();
	AddRandomItem(inventory, items, rng);

}

static void AddItem(List<string> inventory, string[] items, int index)
{
    if (index < 0 || index >= items.Length)
    {
        Console.WriteLine("Nieprawidłowy indeks przedmiotu!");
        return;
    }

    string item = items[index];
    inventory.Add(item);
    Console.WriteLine("Dodano do ekwipunku: " + item);
}

static void AddRandomItem(List<string> inventory, string[] items, Random rng)
{
    int index = rng.Next(0, items.Length);
    string item = items[index];

    inventory.Add(item);
    Console.WriteLine("Wylosowano i dodano: " + item);
}
